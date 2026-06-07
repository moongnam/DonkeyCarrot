using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq; // 🔍 LINQ 필터링 검색을 위해 추가
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;


namespace DonkeyCarrot;

public partial class Form1 : Form
{
    float currentEpochLoss = 0;
    int epochCount = 0;
    float previousTrainLoss = -1;
    float previousValLoss = -1;
    bool isUpdatingUI = false;
    int? spaceStartIndex = null;

    // catalog 데이터를 저장할 리스트 (전체 원본 데이터)
    List<DonkeyData> dataList = new List<DonkeyData>();

    // 🔍 솎아내기(필터링)된 데이터를 추적하기 위한 현재 화면용 리스트
    List<DonkeyData> filteredList = new List<DonkeyData>();

    // 이미지 파일 경로를 저장할 리스트
    List<string> imageList = new List<string>();

    // Python 프로젝트 경로
    string projectPath = "";

    // tub 데이터 폴더 경로
    string tubPath = "";

    private int currentIndex = 0;

    // 자동 재생 타이머
    System.Windows.Forms.Timer autoTimer = new System.Windows.Forms.Timer();

    int autoDirection = 1;

    int frameStep = 1;


    Process trainProcess = null;

    bool isAutoPlaying = false;

    List<float> trainLossList = new List<float>();
    List<float> valLossList = new List<float>();

    private List<DonkeyData> deletedList = new List<DonkeyData>();

    private string deletedCatalogPath;
    private string deletedImagesPath;

    string pilotModelPath = "";

    Process pilotProcess = null;
    StreamWriter pilotInput = null;
    StreamReader pilotOutput = null;

    public Form1()
    {
        InitializeComponent();

        list_FileCheck.SelectionMode = SelectionMode.MultiExtended;
        list_DeletedCheck.SelectionMode = SelectionMode.MultiExtended;

        btn_Restore.Click += btn_Restore_Click;

        this.KeyPreview = true;
        this.KeyDown += Form1_KeyDown;

        list_FileCheck.KeyDown += Form1_KeyDown;

        // 기존 버튼 클릭 이벤트 연결
        btnLoadImages.Click += btnLoadImages_Click;

        // 기본은 Angle만 체크
        chk_Angle.Checked = true;
        chk_Throttle.Checked = false;

        // 체크 상태가 바뀌면 그래프 다시 그림
        chk_Angle.CheckedChanged += chk_Graph_CheckedChanged;
        chk_Throttle.CheckedChanged += chk_Graph_CheckedChanged;

        //화면 크기 바뀔때마다 그래프 다시 호출
        pic_Graph.SizeChanged += (s, e) =>
        {
            if (pic_Graph.Width > 0 && pic_Graph.Height > 0)
            {
                DrawGraph();
            }
        };

        // pic_Graph 외곽선
        pic_Graph.BorderStyle = BorderStyle.FixedSingle;

        // Conda 환경 이름 입력 텍스트박스 초기 설정
        txtCondaEnv.Text = "conda 환경 이름 입력";
        txtCondaEnv.ForeColor = Color.Silver;

        // 텍스트박스 포커스 이벤트 연결
        txtCondaEnv.Enter += txtCondaEnv_Enter;
        txtCondaEnv.Leave += txtCondaEnv_Leave;

        InitializeManagerEvents();

        autoTimer.Tick += AutoTimer_Tick; // 타이머 틱 이벤트 핸들러 연결

        autoTimer.Interval = 100; // 자동재생 기본 속도, 숫자가 작을수록 빠름

        cmbSpeed.Items.Clear();
        cmbSpeed.Items.Add("1");
        cmbSpeed.Items.Add("2");
        cmbSpeed.Items.Add("3");
        cmbSpeed.Items.Add("5");
        cmbSpeed.Items.Add("10");

        cmbSpeed.SelectedItem = "1";

        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;// 속도 조절 콤보박스 이벤트 핸들러 연결

        // 파일 불러오기 버튼 이벤트 연결
        btnLoadPilot.Click += btnLoadPilot_Click;
    }


    private void DisplayCurrentData()
    {
        isUpdatingUI = true;
        // 🔍 현재 활성화된 리스트(필터링 상태 반영) 기준으로 데이터 체크
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;

        // 데이터가 없으면 종료
        if (currentSource == null || currentSource.Count == 0) return;

        // 인덱스가 데이터 범위를 벗어나지 않도록 안전장치 설정
        if (currentIndex < 0) currentIndex = 0;
        if (currentIndex >= currentSource.Count) currentIndex = currentSource.Count - 1;

        // 1. 현재 주행 데이터 가져오기
        DonkeyData currentData = currentSource[currentIndex];

        // 2. 우측 상단 라벨에 값 반영
        lbl_FrameV.Text = currentIndex.ToString();

        // Angle / Throttle 값을 소수점 4자리까지 표시
        lbl_AngleV.Text = currentData.Angle.ToString("F4");
        lbl_ThrottleV.Text = currentData.Throttle.ToString("F4");

        // 3. 하단 커스텀 재생바 위치 동기화
        myTrackbar1.Minimum = 0;
        myTrackbar1.Maximum = currentSource.Count - 1;
        myTrackbar1.Value = currentIndex;

        // 4. 왼쪽 리스트 선택 상태 동기화
        // ⚠️ 여러 개 드래그 선택 중일 때는 SelectedIndex를 강제로 변경하지 않음
        // 안 그러면 다중 선택이 풀려버림
        if (list_FileCheck.Items.Count > currentIndex && currentIndex >= 0)
        {
            if (isAutoPlaying)
            {
                list_FileCheck.ClearSelected();
                list_FileCheck.SelectedIndex = currentIndex;
                list_FileCheck.TopIndex = currentIndex;
            }
            else
            {
                if (list_FileCheck.SelectedIndices.Count <= 1)
                {
                    list_FileCheck.ClearSelected();
                    list_FileCheck.SelectedIndex = currentIndex;
                }
            }
        }

        // 5. 중앙 PictureBox에 주행 이미지 바인딩
        string imageName = Path.GetFileName(currentData.ImagePath);

        // imageList 안에서 실제 이미지 경로 찾기
        string actualImagePath = imageList.Find(path => path.Contains(imageName));

        // 이미지 파일 존재 여부 확인
        if (!string.IsNullOrEmpty(actualImagePath) && File.Exists(actualImagePath))
        {
            // 기존 이미지 제거 (메모리 및 파일 잠김 방지)
            if (pic_DkScreen.Image != null)
                pic_DkScreen.Image.Dispose();

            // ⚠️ FileStream 사용
            // 파일을 독점하지 않고 메모리로 읽어서 삭제 충돌 방지
            using (FileStream fs = new FileStream(actualImagePath, FileMode.Open, FileAccess.Read))
            {
                pic_DkScreen.Image = System.Drawing.Image.FromStream(fs);
            }

            // PictureBox 크기에 맞게 자동 확대/축소
            pic_DkScreen.SizeMode = PictureBoxSizeMode.Zoom;

            // 이미지 위에 조향각 선 그리기
            DrawDirectionLine(currentData.Angle, actualImagePath);
        }
        else
        {
            // 이미지 없으면 PictureBox 비우기
            if (pic_DkScreen.Image != null)
                pic_DkScreen.Image.Dispose();

            pic_DkScreen.Image = null;
        }
        isUpdatingUI = false;
    }
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        // 1. [Delete] 키가 눌렸을 때 기능 추가 ---------------------------------------
        if (e.KeyCode == Keys.Delete)
        {
            e.SuppressKeyPress = true; // 윈도우 기본 띵~ 소리 방지

            // 이미 구현해 두신 삭제 로직 실행!
            // 버튼 클릭 이벤트를 코드로 직접 호출합니다.
            btn_Del_Click(btn_Del, EventArgs.Empty);
            return;
        }
        // -------------------------------------------------------------------------

        // 2. 기존 스페이스바 로직 (그대로 유지)
        if (e.KeyCode != Keys.Space)
            return;

        e.SuppressKeyPress = true;

        var currentSource = filteredList.Count > 0 ? filteredList : dataList;

        if (currentSource == null || currentSource.Count == 0)
            return;

        // 스페이스바 처음 누른 경우: 시작점 저장
        if (spaceStartIndex == null)
        {
            spaceStartIndex = currentIndex;

            list_FileCheck.ClearSelected();
            list_FileCheck.SelectedIndex = currentIndex;

            return;
        }

        // 스페이스바 두 번째 누른 경우: 시작점 ~ 현재 위치까지 선택
        int start = spaceStartIndex.Value;
        int end = currentIndex;

        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }

        // 자동재생 멈추기
        autoTimer.Stop();
        isAutoPlaying = false;

        list_FileCheck.ClearSelected();

        for (int i = start; i <= end; i++)
        {
            if (i >= 0 && i < list_FileCheck.Items.Count)
            {
                list_FileCheck.SetSelected(i, true);
            }
        }

        list_FileCheck.TopIndex = start;

        // 다시 다음 범위 선택할 수 있게 초기화
        spaceStartIndex = null;
    }

    private void btn_Restore_Click(object sender, EventArgs e)
    {
        if (deletedList == null || deletedList.Count == 0)
        {
            MessageBox.Show("복구할 파일이 없습니다.", "알림");
            return;
        }

        var selectedIndices = list_DeletedCheck.SelectedIndices.Cast<int>().ToList();

        if (selectedIndices.Count == 0)
        {
            MessageBox.Show("복구할 파일을 선택해주세요.", "알림");
            return;
        }

        DialogResult result = MessageBox.Show(
            $"선택하신 {selectedIndices.Count}개의 파일을 복구하시겠습니까?",
            "파일 복구 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
            return;

        selectedIndices.Sort();
        selectedIndices.Reverse();

        int restoreCount = 0;

        foreach (int idx in selectedIndices)
        {
            if (idx < 0 || idx >= deletedList.Count)
                continue;

            DonkeyData restoreData = deletedList[idx];
            string imageName = Path.GetFileName(restoreData.ImagePath);

            string deletedImagePath = Path.Combine(deletedImagesPath, imageName);

            string imagesFolderPath = Path.Combine(tubPath, "images");
            string restoreImagePath = Path.Combine(imagesFolderPath, imageName);

            try
            {
                if (!Directory.Exists(imagesFolderPath))
                {
                    Directory.CreateDirectory(imagesFolderPath);
                }

                if (File.Exists(deletedImagePath))
                {
                    if (File.Exists(restoreImagePath))
                    {
                        File.Delete(restoreImagePath);
                    }

                    File.Move(deletedImagePath, restoreImagePath);
                }

                dataList.Add(restoreData);
                imageList.Add(restoreImagePath);

                deletedList.RemoveAt(idx);
                list_DeletedCheck.Items.RemoveAt(idx);

                restoreCount++;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"파일 복구 실패 ({imageName}): {ex.Message}");
            }
        }

        dataList = dataList
            .OrderBy(d =>
            {
                string fileName = Path.GetFileName(d.ImagePath);
                string number = fileName.Split('_')[0];
                return int.Parse(number);
            })
            .ToList();

        try
        {
            RewriteCatalog();
            RewriteDeletedCatalog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"복구 후 카탈로그 저장 중 오류가 발생했습니다:\n{ex.Message}",
                "오류",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        UpdateFileList();

        currentIndex = dataList.Count > 0 ? dataList.Count - 1 : 0;

        DisplayCurrentData();
        DrawGraph();

        MessageBox.Show($"{restoreCount}개의 파일이 복구되었습니다.", "복구 완료");
    }



    private void InitializeTrash()
    {
        deletedCatalogPath = Path.Combine(tubPath, "deleted_catalog.catalog");
        deletedImagesPath = Path.Combine(tubPath, "deleted_images");

        if (!Directory.Exists(deletedImagesPath))
        {
            Directory.CreateDirectory(deletedImagesPath);
        }

        LoadDeletedCatalog();
    }

    private void LoadDeletedCatalog()
    {
        deletedList.Clear();
        list_DeletedCheck.Items.Clear();

        if (!File.Exists(deletedCatalogPath))
            return;

        string[] lines = File.ReadAllLines(deletedCatalogPath);

        foreach (string line in lines)
        {
            try
            {
                DonkeyData data =
                    JsonConvert.DeserializeObject<DonkeyData>(line);

                if (data != null)
                {
                    deletedList.Add(data);

                    list_DeletedCheck.Items.Add(
                        Path.GetFileName(data.ImagePath)
                    );
                }
            }
            catch
            {
            }
        }
    }
    //휴지통 목록을 실제 파일에 저장
    private void RewriteDeletedCatalog()
    {
        if (string.IsNullOrEmpty(deletedCatalogPath))
            return;

        using (StreamWriter sw = new StreamWriter(deletedCatalogPath, false, System.Text.Encoding.UTF8))
        {
            foreach (var data in deletedList)
            {
                string jsonLine = JsonConvert.SerializeObject(data);
                sw.WriteLine(jsonLine);
            }
        }
    }

    //현재 살아있는 데이터만 다시 저장
    private void RewriteCatalog()
    {
        if (string.IsNullOrEmpty(tubPath) || !Directory.Exists(tubPath))
            return;

        string[] catalogFiles = Directory.GetFiles(tubPath, "*.catalog", SearchOption.TopDirectoryOnly);

        if (catalogFiles.Length == 0)
            return;

        string targetCatalogPath = catalogFiles[0];

        using (StreamWriter sw = new StreamWriter(targetCatalogPath, false, System.Text.Encoding.UTF8))
        {
            foreach (var data in dataList)
            {
                string jsonLine = JsonConvert.SerializeObject(data);
                sw.WriteLine(jsonLine);
            }
        }
    }

    // 카탈로그 파일 로드가 성공한 직후 호출하여 왼쪽 리스트박스를 가득 채우는 함수
    private void UpdateFileList()
    {
        list_FileCheck.Items.Clear();

        for (int i = 0; i < dataList.Count; i++)
        {
            string fileName = Path.GetFileName(dataList[i].ImagePath);
            list_FileCheck.Items.Add($"{i + 1:D4}. {fileName}");
        }
    }

    // 🔍 찾기 버튼 : 사용자가 텍스트 상자에 입력한 동적 수식(부호, 숫자)을 기반으로 정밀 솎아내기 수행
    private void btn_Find_Click(object sender, EventArgs e)
    {
        if (dataList == null || dataList.Count == 0)
        {
            MessageBox.Show("먼저 카탈로그 데이터를 불러와 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 원본 데이터를 복사하여 필터링의 기준 리스트로 삼습니다.
        var resultList = dataList.ToList();
        bool isFiltered = false;

        // --- [ 1. 조향각(Angle) 솎아내기 조건 체크 ] ---
        // 최소값(txtAngleF)과 최대값(txtAngleF2) 칸이 모두 입력되었을 때만 필터링을 수행합니다.
        if (!string.IsNullOrWhiteSpace(txtAngleF.Text) && !string.IsNullOrWhiteSpace(txtAngleF2.Text))
        {
            if (!float.TryParse(txtAngleF.Text, out float angleMin) ||
                !float.TryParse(txtAngleF2.Text, out float angleMax))
            {
                MessageBox.Show("조향각(Angle) 입력 창에 올바른 숫자를 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (angleMin > angleMax)
            {
                MessageBox.Show("조향각(Angle)의 시작 값이 종료 값보다 클 수 없습니다.", "범위 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 조건 범위에 만족하는 데이터만 필터링
            resultList = resultList.Where(d => d.Angle >= angleMin && d.Angle <= angleMax).ToList();
            isFiltered = true;
        }

        // --- [ 2. 스로틀(Throttle) 솎아내기 조건 체크 ] ---
        // 최소값(txtThrottleF)과 최대값(txtThrottleF2) 칸이 모두 입력되었을 때만 필터링을 수행합니다.
        if (!string.IsNullOrWhiteSpace(txtThrottleF.Text) && !string.IsNullOrWhiteSpace(txtThrottleF2.Text))
        {
            if (!float.TryParse(txtThrottleF.Text, out float throttleMin) ||
                !float.TryParse(txtThrottleF2.Text, out float throttleMax))
            {
                MessageBox.Show("스로틀(Throttle) 입력 창에 올바른 숫자를 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (throttleMin > throttleMax)
            {
                MessageBox.Show("스로틀(Throttle)의 시작 값이 종료 값보다 클 수 없습니다.", "범위 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 앞서 걸러진 리스트에서 스로틀 조건까지 연속으로 만족하는 데이터 필터링 (교집합)
            resultList = resultList.Where(d => d.Throttle >= throttleMin && d.Throttle <= throttleMax).ToList();
            isFiltered = true;
        }

        // --- [ 3. 둘 다 아무것도 입력하지 않았을 때 예외 처리 ] ---
        if (!isFiltered)
        {
            MessageBox.Show("조향각 범위(Angle) 또는 스로틀 범위(Throttle)를 입력창에 정확히 채워주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // --- [ 4. 최종 결과 검증 및 UI 최신화 화면 갱신 ] ---
        if (resultList.Count > 0)
        {
            filteredList = resultList; // 글로벌 솎아내기 데이터 리스트에 할당

            // 왼쪽 UI 파일 목록 리스트박스 갱신
            list_FileCheck.Items.Clear();

            for (int i = 0; i < filteredList.Count; i++)
            {
                string fileName = Path.GetFileName(filteredList[i].ImagePath);
                list_FileCheck.Items.Add($"{i + 1:D4}. {fileName}");
            }

            currentIndex = 0;       // 인덱스를 필터링된 데이터의 첫 번째 항목으로 설정
            DisplayCurrentData();  // 이미지 뷰어 화면 및 상단 데이터 라벨 최신화
            DrawGraph();           // 필터링된 데이터들만 가지고 하단 그래프 다시 그리기

            MessageBox.Show($"조건에 맞는 데이터 {filteredList.Count}건을 성공적으로 솎아냈습니다.", "솎아내기 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // 교집합 결과가 0건일 경우, 기존 데이터를 유지하며 알림창을 띄웁니다.
            MessageBox.Show("입력하신 두 가지 조건을 동시에 만족하는 데이터가 존재하지 않습니다.\n그래프 차트의 수치 스케일을 다시 확인하고 입력해 주세요.", "결과 없음", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private bool EvaluateExpression(string expression, string keyword, float actualValue)
    {
        string formula = expression.Replace(keyword, "");
        string[] operators = { ">=", "<=", "==", ">", "<" };
        string selectedOp = "";
        float targetValue = 0;

        foreach (string op in operators)
        {
            if (formula.StartsWith(op))
            {
                selectedOp = op;
                float.TryParse(formula.Replace(op, ""), out targetValue);
                break;
            }
        }

        if (string.IsNullOrEmpty(selectedOp)) return true;

        switch (selectedOp)
        {
            case ">": return actualValue > targetValue;
            case "<": return actualValue < targetValue;
            case "==": return actualValue == targetValue;
            case ">=": return actualValue >= targetValue;
            case "<=": return actualValue <= targetValue;
            default: return true;
        }
    }

    // 초기화 버튼 : 필터링된 리스트를 풀고 전체 리스트로 복구
    private void btn_Retry_Click(object sender, EventArgs e)
    {
        // 입력창 초기화 (공백 혹은 동키카 데이터 기본 범위인 -1 ~ 1 등을 적어두셔도 됩니다)
        txtAngleF.Text = "";
        txtAngleF2.Text = "";
        txtThrottleF.Text = "";
        txtThrottleF2.Text = "";

        UpdateFileList(); // 전체 원본 데이터 리스트로 복구 및 filteredList.Clear() 수행됨
        DrawGraph();      // 원본 데이터 기준으로 그래프 다시 그리기
    }


    // 🔧 삭제 버튼 : 목록 제거뿐만 아니라 하드디스크의 실제 물리 이미지 파일까지 함께 삭제
    private void btn_Del_Click(object sender, EventArgs e)
    {
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;

        if (currentSource == null || currentSource.Count == 0)
        {
            isUpdatingUI = false;
            return;
        }

        // 🔍 현재 ListBox에서 선택된 항목들의 인덱스 모음 가져오기
        var selectedIndices = list_FileCheck.SelectedIndices.Cast<int>().ToList();

        if (selectedIndices.Count == 0)
        {
            MessageBox.Show("삭제할 파일들을 마우스로 드래그하거나 선택해주세요!", "알림");
            return;
        }

        DialogResult result = MessageBox.Show(
            $"선택하신 {selectedIndices.Count}개의 파일을 하드디스크와 카탈로그에서 '일괄 삭제'하시겠습니까?",
            "다중 파일 삭제 경고",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (result != DialogResult.OK && result != DialogResult.Yes) return;

        // 1. 이미지 뷰어 프로세스 잠김 방지를 위해 PictureBox 이미지 해제 및 리소스 완전 비우기
        if (pic_DkScreen.Image != null)
        {
            pic_DkScreen.Image.Dispose();
            pic_DkScreen.Image = null;
        }

        // 💡 중요: 리스트박스 항목을 삭제할 때는 인덱스가 밀리지 않도록 '뒤에서부터(역순으로)' 지워야 안전합니다.
        selectedIndices.Sort();
        selectedIndices.Reverse();

        int deleteCount = 0;

        foreach (int idx in selectedIndices)
        {
            if (idx < 0 || idx >= currentSource.Count) continue;

            DonkeyData targetData = currentSource[idx];
            string imageName = Path.GetFileName(targetData.ImagePath);

            // 2. 물리 이미지 파일을 삭제하지 않고 deleted_images 폴더로 이동
            string actualImagePath = imageList.Find(path => Path.GetFileName(path) == imageName);

            try
            {
                if (!string.IsNullOrEmpty(actualImagePath) && File.Exists(actualImagePath))
                {
                    string deletedImagePath = Path.Combine(deletedImagesPath, imageName);

                    // deleted_images 안에 같은 이름 파일이 있으면 덮어쓰기 방지용으로 삭제
                    if (File.Exists(deletedImagePath))
                    {
                        File.Delete(deletedImagePath);
                    }

                    File.Move(actualImagePath, deletedImagePath);

                    imageList.Remove(actualImagePath);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"파일 휴지통 이동 실패 ({imageName}): {ex.Message}");
            }

            // 복구용 휴지통 리스트에 추가
            deletedList.Add(targetData);
            list_DeletedCheck.Items.Add(imageName);

            // 3. 메모리 데이터 리스트에서 삭제 진행 (양쪽 동시 동기화)
            if (filteredList.Count > 0)
            {
                filteredList.Remove(targetData);
            }
            dataList.Remove(targetData); // 원본 목록에서는 제거

            // 4. UI 리스트박스 항목 제거
            list_FileCheck.Items.RemoveAt(idx);
            deleteCount++;
        }
        deletedList = deletedList
            .OrderBy(d =>
            {
                string fileName = Path.GetFileName(d.ImagePath);
                string number = fileName.Split('_')[0];
                return int.Parse(number);
            })
            .ToList();

        list_DeletedCheck.Items.Clear();

        foreach (var data in deletedList)
        {
            list_DeletedCheck.Items.Add(
                Path.GetFileName(data.ImagePath)
            );
        }

        // 5. 카탈로그 파일 저장
        try
        {
            RewriteCatalog();          // 현재 살아있는 데이터 저장
            RewriteDeletedCatalog();   // 휴지통 데이터 저장
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"카탈로그 동기화 중 오류가 발생했습니다:\n{ex.Message}",
                "오류",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        MessageBox.Show($"총 {deleteCount}개의 이미지 파일과 카탈로그 로그가 일괄 삭제 및 동기화되었습니다.", "완료");

        // 6. 후속 인덱스 바운더리 체크 및 UI 화면 재조정
        var checkSource = filteredList.Count > 0 ? filteredList : dataList;
        if (checkSource.Count == 0)
        {
            currentIndex = 0;
            list_FileCheck.Items.Clear();
        }
        else
        {
            if (currentIndex >= checkSource.Count)
            {
                currentIndex = checkSource.Count - 1;
            }
        }
        // 파일 리스트 업데이트
        UpdateFileList();

        DisplayCurrentData();
        DrawGraph(); // 변동된 상태로 그래프 최신화
    }

    // catalog 파일 불러오기 버튼
    private void btnLoadCatalog_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        fbd.Description = "data 폴절 선택";
        fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (fbd.ShowDialog() == DialogResult.OK)
        {
            dataList.Clear();
            filteredList.Clear(); // 초기화

            string dataFolderPath = fbd.SelectedPath;

            lbl_CatalogRoute.Text = Path.GetFileName(dataFolderPath);
            toolTipPath.SetToolTip(lbl_CatalogRoute, dataFolderPath);

            tubPath = dataFolderPath;

            // 휴지통 준비
            InitializeTrash();

            DirectoryInfo currentDir = new DirectoryInfo(dataFolderPath);

            while (currentDir != null)
            {
                string managePath = Path.Combine(currentDir.FullName, "manage.py");

                if (File.Exists(managePath))
                {
                    projectPath = currentDir.FullName;
                    break;
                }
                currentDir = currentDir.Parent;
            }

            string[] catalogFiles = Directory.GetFiles(
                dataFolderPath,
                "*.catalog",
                SearchOption.TopDirectoryOnly
            );

            foreach (string catalogFile in catalogFiles)
            {
                foreach (string line in File.ReadLines(catalogFile))
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    DonkeyData data = JsonConvert.DeserializeObject<DonkeyData>(line);

                    if (data != null)
                    {
                        dataList.Add(data);
                    }
                }
            }

            MessageBox.Show(
                "Catalog 전체 불러오기 완료\n" +
                "Catalog 파일 개수 : " + catalogFiles.Length + "\n" +
                "데이터 개수 : " + dataList.Count
            );

            UpdateFileList();
            DrawGraph();
        }
    }

    // 체크박스 상태 변경 시 실행
    private void chk_Graph_CheckedChanged(object sender, EventArgs e)
    {
        DrawGraph();
    }

    // 그래프 그리는 함수
    private void DrawGraph()
    {
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;

        if (currentSource.Count == 0)
        {
            pic_Graph.Image = null;
            return;
        }

        // 둘 다 체크 안 되어 있으면 그래프 비우기
        if (!chk_Angle.Checked && !chk_Throttle.Checked)
        {
            pic_Graph.Image = null;
            return;
        }

        int width = pic_Graph.Width;
        int height = pic_Graph.Height;

        Bitmap bmp = new Bitmap(width, height);
        Graphics g = Graphics.FromImage(bmp);

        g.Clear(Color.White);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        int left = 60;
        int right = 45;
        int top = 25;
        int bottom = 45;

        int graphLeft = left;
        int graphRight = width - right;
        int graphTop = top;
        int graphBottom = height - bottom;

        int graphWidth = graphRight - graphLeft;
        int graphHeight = graphBottom - graphTop;

        Pen gridPen = new Pen(Color.LightGray, 1);
        Pen axisPen = new Pen(Color.Black, 1);

        // Angle은 빨간색, Throttle은 파란색
        Pen anglePen = new Pen(Color.Red, 2);
        Pen throttlePen = new Pen(Color.Blue, 2);

        Font font = new Font("Arial", 8);
        Brush textBrush = Brushes.Black;

        float minValue = 0;
        float maxValue = 0;

        foreach (var data in currentSource)
        {
            if (chk_Angle.Checked)
            {
                if (data.Angle < minValue) minValue = data.Angle;
                if (data.Angle > maxValue) maxValue = data.Angle;
            }

            if (chk_Throttle.Checked)
            {
                if (data.Throttle < minValue) minValue = data.Throttle;
                if (data.Throttle > maxValue) maxValue = data.Throttle;
            }
        }

        if (maxValue == minValue)
        {
            maxValue += 1;
            minValue -= 1;
        }

        float padding = (maxValue - minValue) * 0.1f;
        maxValue += padding;
        minValue -= padding;

        g.DrawRectangle(axisPen, graphLeft, graphTop, graphWidth, graphHeight);

        int yTickCount = 5;

        for (int i = 0; i <= yTickCount; i++)
        {
            int y = graphBottom - (i * graphHeight / yTickCount);
            float value = minValue + (i * (maxValue - minValue) / yTickCount);

            g.DrawLine(gridPen, graphLeft, y, graphRight, y);
            g.DrawString(value.ToString("0.00"), font, textBrush, 5, y - 7);
        }

        int xStep;

        if (currentSource.Count <= 100) xStep = 10;
        else if (currentSource.Count <= 300) xStep = 20;
        else if (currentSource.Count <= 800) xStep = 50;
        else if (currentSource.Count <= 1500) xStep = 100;
        else if (currentSource.Count <= 3000) xStep = 200;
        else xStep = 500;

        int lastTextX = -9999;

        for (int i = 0; i < currentSource.Count; i += xStep)
        {
            int x = graphLeft + (i * graphWidth / (currentSource.Count - 1));

            g.DrawLine(gridPen, x, graphTop, x, graphBottom);

            if (x - lastTextX > 35)
            {
                g.DrawString(i.ToString(), font, textBrush, x - 10, graphBottom + 5);
                lastTextX = x;
            }
        }

        // Angle 그래프
        if (chk_Angle.Checked)
        {
            for (int i = 0; i < currentSource.Count - 1; i++)
            {
                float value1 = currentSource[i].Angle;
                float value2 = currentSource[i + 1].Angle;

                int x1 = graphLeft + (i * graphWidth / (currentSource.Count - 1));
                int x2 = graphLeft + ((i + 1) * graphWidth / (currentSource.Count - 1));

                int y1 = graphBottom - (int)((value1 - minValue) / (maxValue - minValue) * graphHeight);
                int y2 = graphBottom - (int)((value2 - minValue) / (maxValue - minValue) * graphHeight);

                g.DrawLine(anglePen, x1, y1, x2, y2);
            }

            g.DrawString("user/angle", font, Brushes.Red, graphRight - 90, graphTop - 20);
        }

        // Throttle 그래프
        if (chk_Throttle.Checked)
        {
            for (int i = 0; i < currentSource.Count - 1; i++)
            {
                float value1 = currentSource[i].Throttle;
                float value2 = currentSource[i + 1].Throttle;

                int x1 = graphLeft + (i * graphWidth / (currentSource.Count - 1));
                int x2 = graphLeft + ((i + 1) * graphWidth / (currentSource.Count - 1));

                int y1 = graphBottom - (int)((value1 - minValue) / (maxValue - minValue) * graphHeight);
                int y2 = graphBottom - (int)((value2 - minValue) / (maxValue - minValue) * graphHeight);

                g.DrawLine(throttlePen, x1, y1, x2, y2);
            }

            g.DrawString("user/throttle", font, Brushes.Blue, graphRight - 90, graphTop - 8);
        }

        if (pic_Graph.Image != null)
        {
            pic_Graph.Image.Dispose();
        }

        pic_Graph.Image = bmp;
    }

    private void DrawTrainGraph()
    {
        if (trainLossList.Count < 2)
            return;

        Bitmap bmp = new Bitmap(
            picTrainGraph.Width,
            picTrainGraph.Height);

        Graphics g = Graphics.FromImage(bmp);

        g.Clear(Color.White);

        float minLoss = float.MaxValue;
        float maxLoss = float.MinValue;

        foreach (float v in trainLossList)
        {
            minLoss = Math.Min(minLoss, v);
            maxLoss = Math.Max(maxLoss, v);
        }

        foreach (float v in valLossList)
        {
            minLoss = Math.Min(minLoss, v);
            maxLoss = Math.Max(maxLoss, v);
        }

        if (maxLoss == minLoss)
            maxLoss += 0.001f;

        for (int i = 0; i < trainLossList.Count - 1; i++)
        {
            int x1 = i * bmp.Width / (trainLossList.Count - 1);
            int x2 = (i + 1) * bmp.Width / (trainLossList.Count - 1);

            int y1 = bmp.Height -
                     (int)((trainLossList[i] - minLoss) /
                     (maxLoss - minLoss) * bmp.Height);

            int y2 = bmp.Height -
                     (int)((trainLossList[i + 1] - minLoss) /
                     (maxLoss - minLoss) * bmp.Height);

            g.DrawLine(Pens.Red, x1, y1, x2, y2);
        }

        for (int i = 0; i < valLossList.Count - 1; i++)
        {
            int x1 = i * bmp.Width / (valLossList.Count - 1);
            int x2 = (i + 1) * bmp.Width / (valLossList.Count - 1);

            int y1 = bmp.Height -
                     (int)((valLossList[i] - minLoss) /
                     (maxLoss - minLoss) * bmp.Height);

            int y2 = bmp.Height -
                     (int)((valLossList[i + 1] - minLoss) /
                     (maxLoss - minLoss) * bmp.Height);

            g.DrawLine(Pens.Blue, x1, y1, x2, y2);
        }

        picTrainGraph.Image = bmp;
    }

    // 이미지 폴더 불러오기 버튼
    private void btnLoadImages_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        fbd.Description = "images 폴더 선택";
        fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (fbd.ShowDialog() == DialogResult.OK)
        {
            imageList.Clear();

            lbl_ImageRoute.Text = Path.GetFileName(fbd.SelectedPath);
            toolTipPath.SetToolTip(lbl_ImageRoute, fbd.SelectedPath);

            string[] jpgFiles = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
            string[] pngFiles = Directory.GetFiles(fbd.SelectedPath, "*.png");

            imageList.AddRange(jpgFiles);
            imageList.AddRange(pngFiles);

            MessageBox.Show(
                "이미지 불러오기 완료\n" +
                "이미지 개수 : " + imageList.Count
            );

            DisplayCurrentData();
        }
    }

    private void btnTrain_Click_1(object sender, EventArgs e)
    {
        trainLossList.Clear();
        valLossList.Clear();
        picTrainGraph.Image = null;
        epochCount = 0;
        txtTrainLoss.Clear();

        txtLog.Clear();

        string linuxProjectPath = projectPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        string linuxTubPath = tubPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");


        ProcessStartInfo psi = new ProcessStartInfo();

        psi.FileName = @"C:\Windows\System32\wsl.exe";

        string condaEnv = GetPilotCondaEnv();

        if (string.IsNullOrWhiteSpace(condaEnv))
        {
            lblStatus.Text = "상태: 대기 중";
            lblStatus.ForeColor = Color.White;
            return;
        }

        lblStatus.Text = "상태: 학습 진행 중...";
        lblStatus.ForeColor = Color.Lime;

        psi.Arguments = $"-d Ubuntu-22.04 -- bash -c \"cd '{linuxProjectPath}' && source ~/miniconda3/bin/activate {condaEnv} && python train.py --tub '{linuxTubPath}' --model ./models/donkeycarrot.h5 --type linear\"";
        psi.EnvironmentVariables["PATH"] = @"C:\Windows\System32";

        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;

        trainProcess = new Process();
        trainProcess.StartInfo = psi;

        trainProcess.OutputDataReceived += (s, ev) =>
        {
            if (!string.IsNullOrEmpty(ev.Data))
            {
                string log = ev.Data;

                bool graphUpdated = false;

                Match valMatch = Regex.Match(ev.Data, @"val_loss:\s*([0-9.]+)");
                if (valMatch.Success)
                {
                    float valLoss = float.Parse(valMatch.Groups[1].Value);

                    string trainStatus = "";
                    string valStatus = "";

                    if (previousTrainLoss >= 0)
                    {
                        trainStatus = currentEpochLoss < previousTrainLoss
                            ? " (개선됨 ↑)"
                            : " (악화됨 ↓)";
                    }

                    if (previousValLoss >= 0)
                    {
                        valStatus = valLoss < previousValLoss
                            ? " (개선됨 ↑)"
                            : " (악화됨 ↓)";
                    }

                    valLossList.Add(valLoss);
                    epochCount++;

                    graphUpdated = true;

                    if (!IsDisposed && txtTrainLoss.IsHandleCreated)
                    {
                        Invoke(new Action(() =>
                        {
                            txtTrainLoss.AppendText(
                                $"[학습 {epochCount}회차]" +
                                Environment.NewLine +
                                $"▶ 학습 오차값 : {currentEpochLoss:F4}{trainStatus}" +
                                Environment.NewLine +
                                $"▶ 검증 오차값 : {valLoss:F4}{valStatus}" +
                                Environment.NewLine +
                                Environment.NewLine);
                        }));
                    }

                    previousTrainLoss = currentEpochLoss;
                    previousValLoss = valLoss;
                }

                Match trainMatch = Regex.Match(ev.Data, @"loss:\s*([0-9.]+)");
                if (trainMatch.Success && !ev.Data.Contains("val_loss"))
                {
                    currentEpochLoss = float.Parse(trainMatch.Groups[1].Value);

                    trainLossList.Add(currentEpochLoss);

                    graphUpdated = true;
                }

                // 깨지는 문자 제거
                log = log.Replace("\b", "");
                log = log.Replace("\r", "");

                log = log.Replace("Epoch", "학습");

                log = log.Replace("val_n_outputs0_loss", "검증 조향각 오차값");
                log = log.Replace("val_n_outputs1_loss", "검증 속도 오차값");
                log = log.Replace("val_loss", "검증 전체 오차값");

                log = log.Replace("n_outputs0_loss", "조향각 오차값");
                log = log.Replace("n_outputs1_loss", "속도 오차값");
                log = log.Replace("loss", "전체 오차값");

                log = log.Replace("Loading", "불러오는 중");
                log = log.Replace("Saving", "저장 중");
                log = log.Replace("Training", "학습");
                log = log.Replace("Complete", "완료");
                log = log.Replace("Model", "모델");
                log = log.Replace("ETA", "예상 시간");

                log = log.Replace("did not improve from", "이전 최고값보다 좋아지지 않음:");
                log = log.Replace("improved from", "개선됨:");
                log = log.Replace("saving model to", "모델 저장 위치:");

                if (!IsDisposed && !Disposing && IsHandleCreated && txtLog.IsHandleCreated)
                {
                    BeginInvoke(new Action(() =>
                    {
                        if (IsDisposed || Disposing)
                            return;

                        txtLog.AppendText(log + Environment.NewLine);

                        if (graphUpdated &&
                            picTrainGraph != null &&
                            picTrainGraph.IsHandleCreated)
                        {
                            DrawTrainGraph();
                        }
                    }));
                }
            }
        };

        trainProcess.ErrorDataReceived += (s, ev) =>
        {
            if (!string.IsNullOrEmpty(ev.Data))
            {
                string log = ev.Data;

                log = log.Replace("\b", "");
                log = log.Replace("\r", "");

                log = log.Replace("ERROR", "오류");
                log = log.Replace("failed", "실패");
                log = log.Replace("No module named", "모듈을 찾을 수 없습니다");

                if (!IsDisposed && !Disposing && IsHandleCreated && txtLog.IsHandleCreated)
                {
                    BeginInvoke(new Action(() =>
                    {
                        if (IsDisposed || Disposing)
                            return;

                        txtLog.AppendText(log + Environment.NewLine);
                    }));
                }
            }
        };

        trainProcess.EnableRaisingEvents = true;

        trainProcess.Exited += (s, ev) =>
        {
            int exitCode = trainProcess.ExitCode;

            if (!IsDisposed && txtLog.IsHandleCreated)
            {
                Invoke(new Action(() =>
                {
                    txtLog.AppendText(Environment.NewLine);

                    if (exitCode == 0 || exitCode == 130)
                    {
                        DrawTrainGraph();

                        txtLog.AppendText("학습이 완료되었습니다." + Environment.NewLine);
                        lblStatus.Text = "상태: 학습 완료";
                        lblStatus.ForeColor = Color.DodgerBlue;
                        MessageBox.Show("학습이 완료되었습니다.");
                    }
                    else
                    {
                        txtLog.AppendText($"학습이 비정상 종료되었습니다. 종료 코드: {exitCode}" + Environment.NewLine);
                        lblStatus.Text = "상태: 비정상 종료";
                        lblStatus.ForeColor = Color.OrangeRed;
                        MessageBox.Show("학습이 비정상 종료되었습니다.");
                    }
                }));
            }
            trainProcess.Dispose();
        };

        trainProcess.Start();
        trainProcess.BeginOutputReadLine();
        trainProcess.BeginErrorReadLine();
    }

    private void label5_Click(object sender, EventArgs e) { }
    private void btn_BigL_Click(object sender, EventArgs e) { }
    private void btnLoadCatalog_Click_1(object sender, EventArgs e) { btnLoadCatalog_Click(sender, e); }

    private void txtCondaEnv_Enter(object sender, EventArgs e)
    {
        if (txtCondaEnv.Text == "conda 환경 이름 입력")
        {
            txtCondaEnv.Text = "";
            txtCondaEnv.ForeColor = Color.Black;
        }
    }

    private void txtCondaEnv_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCondaEnv.Text))
        {
            txtCondaEnv.Text = "conda 환경 이름 입력";
            txtCondaEnv.ForeColor = Color.Silver;
        }
    }

    private void btn_SmallR_Click(object sender, EventArgs e)
    {
        autoDirection = 1;
        isAutoPlaying = true;
        autoTimer.Start();
    }

    private void AutoTimer_Tick(object sender, EventArgs e)
    {
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;
        if (currentSource == null || currentSource.Count == 0) return;

        currentIndex += autoDirection * frameStep;

        if (currentIndex >= currentSource.Count) currentIndex = 0;
        if (currentIndex < 0) currentIndex = currentSource.Count - 1;

        DisplayCurrentData();
    }

    private void btn_Stop_Click(object sender, EventArgs e)
    {
        isAutoPlaying = false;
        autoTimer.Stop();
    }

    private void btn_SmallL_Click(object sender, EventArgs e)
    {
        autoDirection = -1;
        isAutoPlaying = true;
        autoTimer.Start();
    }

    private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
    {
        frameStep = Convert.ToInt32(cmbSpeed.SelectedItem);
    }

    private void txtLog_TextChanged(object sender, EventArgs e) { }

    private void btnStopTrain_Click(object sender, EventArgs e)
    {
        try
        {
            ProcessStartInfo stopPsi = new ProcessStartInfo();

            stopPsi.FileName = @"C:\Windows\System32\wsl.exe";
            stopPsi.Arguments = "-d Ubuntu-22.04 -- bash -c \"pkill -INT -f 'python train.py'\"";

            stopPsi.UseShellExecute = false;
            stopPsi.CreateNoWindow = true;

            Process.Start(stopPsi);

            txtLog.AppendText("학습 중지 요청됨..." + Environment.NewLine);

            lblStatus.Text = "상태: 안전 종료 중...";
            lblStatus.ForeColor = Color.Orange;
        }
        catch (Exception ex)
        {
            MessageBox.Show("학습 중지 요청 실패: " + ex.Message);
        }
    }



    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void list_FileCheck_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void tabp_Serve_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    // 이미지 뷰어에 조향각 방향선 그리는 함수
    private void DrawDirectionLine(float realAngle, string imagePath)
    {
        if (pic_DkScreen.Image == null)
            return;

        Bitmap bmp = new Bitmap(pic_DkScreen.Image);

        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int startX = bmp.Width / 2;
            int startY = bmp.Height - 45;

            DrawOneDirection(g, startX, startY, realAngle, Color.Lime);

            float? predictedAngle = GetPilotPredictionFast(imagePath);

            if (predictedAngle.HasValue)
            {
                DrawOneDirection(g, startX, startY, predictedAngle.Value, Color.Red);
            }
        }

        pic_DkScreen.Image.Dispose();
        pic_DkScreen.Image = bmp;
    }

    // 한 방향선 그리는 함수 (실제 또는 예측)
    private void DrawOneDirection(Graphics g, int startX, int startY, float angle, Color color)
    {
        using (Pen pen = new Pen(color, 7))
        using (Brush brush = new SolidBrush(color))
        {
            int endX = startX + (int)(angle * 300);
            int endY = startY - 170;

            g.DrawLine(pen, startX, startY, endX, endY);
            g.FillEllipse(brush, endX - 10, endY - 10, 20, 20);
        }
    }

    // 학습된 모델 불러오기 버튼
    private void btnLoadPilot_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "H5 Model (*.h5)|*.h5";

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            pilotModelPath = ofd.FileName;

            StartPilotServer();

            MessageBox.Show("학습 모델 선택 및 예측 서버 시작 완료");
        }
    }

    // 예측 파일이 없으면 생성하는 함수
    private void EnsurePredictServerFile()
    {
        if (string.IsNullOrEmpty(projectPath))
            return;

        string serverPath = Path.Combine(projectPath, "predict_server.py");

        if (File.Exists(serverPath))
            return;

        string code = @"
import sys
import numpy as np
from PIL import Image
from tensorflow.keras.models import load_model

model_path = sys.argv[1]
model = load_model(model_path)

print('READY', flush=True)

while True:
    line = sys.stdin.readline()

    if not line:
        break

    image_path = line.strip()

    if image_path == 'EXIT':
        break

    try:
        img = Image.open(image_path).convert('RGB')
        img = img.resize((160, 120))
        arr = np.array(img).astype(np.float32) / 255.0
        arr = np.expand_dims(arr, axis=0)

        pred = model.predict(arr, verbose=0)

        if isinstance(pred, list):
            angle = float(pred[0][0][0])
            throttle = float(pred[1][0][0])
        else:
            angle = float(pred[0][0])
            throttle = float(pred[0][1])

        print(f'{angle},{throttle}', flush=True)

    except Exception as e:
        print('ERROR:' + str(e), flush=True)
";

        File.WriteAllText(serverPath, code);
    }

    // WSL에서 모델로 예측을 수행하는 함수
    private float? GetPilotPredictionFast(string imagePath)
    {
        if (pilotProcess == null || pilotProcess.HasExited)
            return null;

        string linuxImagePath = imagePath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        pilotInput.WriteLine(linuxImagePath);
        pilotInput.Flush();

        string result = pilotOutput.ReadLine();

        if (string.IsNullOrWhiteSpace(result))
            return null;

        if (result.StartsWith("ERROR:"))
        {
            txtLog.AppendText("예측 오류: " + result + Environment.NewLine);
            return null;
        }

        string[] parts = result.Split(',');

        if (parts.Length >= 1 && float.TryParse(parts[0], out float angle))
            return angle;

        return null;
    }

    // 예측 서버 시작 함수
    private void StartPilotServer()
    {
        if (string.IsNullOrEmpty(projectPath) || string.IsNullOrEmpty(pilotModelPath))
            return;

        EnsurePredictServerFile();

        if (pilotProcess != null && !pilotProcess.HasExited)
        {
            try
            {
                pilotInput.WriteLine("EXIT");
                pilotProcess.Kill();
            }
            catch { }
        }

        string linuxProjectPath = projectPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        string linuxModelPath = pilotModelPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        string condaEnv = GetPilotCondaEnv();

        if (string.IsNullOrWhiteSpace(condaEnv))
            return;

        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = @"C:\Windows\System32\wsl.exe";
        psi.Arguments =
            $"-d Ubuntu-22.04 -- bash -c \"cd '{linuxProjectPath}' && source ~/miniconda3/bin/activate {condaEnv} && python predict_server.py '{linuxModelPath}'\"";

        psi.RedirectStandardInput = true;
        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;

        pilotProcess = Process.Start(psi);
        pilotInput = pilotProcess.StandardInput;
        pilotOutput = pilotProcess.StandardOutput;

        string ready = pilotOutput.ReadLine();

        if (ready != "READY")
        {
            txtLog.AppendText("예측 서버 시작 실패" + Environment.NewLine);
        }
    }

    // Conda 환경 이름을 한 곳에서만 입력받도록 하는 함수
    private string GetPilotCondaEnv()
    {
        string env1 = txtCondaEnv.Text.Trim();
        string env2 = txtCondaEnv2.Text.Trim();

        bool hasEnv1 = !string.IsNullOrWhiteSpace(env1) &&
                       env1 != "conda 환경 이름 입력";

        bool hasEnv2 = !string.IsNullOrWhiteSpace(env2) &&
                       env2 != "conda 환경 이름 입력";

        // 둘 다 비어있음
        if (!hasEnv1 && !hasEnv2)
        {
            MessageBox.Show("Conda 환경 이름을 입력하세요.");
            return "";
        }

        // 둘 다 입력됨
        if (hasEnv1 && hasEnv2)
        {
            // 값이 다르면 오류
            if (env1 != env2)
            {
                MessageBox.Show(
                    "Conda 환경 이름이 서로 다릅니다.\n같은 이름을 입력하거나 한 곳만 입력하세요."
                );
                return "";
            }

            // 값이 같으면 사용
            return env1;
        }

        // 하나만 입력된 경우
        return hasEnv1 ? env1 : env2;
    }

    private void txtCondaEnv2_Enter(object sender, EventArgs e)
    {
        if (txtCondaEnv2.Text == "conda 환경 이름 입력")
        {
            txtCondaEnv2.Text = "";
            txtCondaEnv2.ForeColor = Color.Black;
        }
    }

    private void txtCondaEnv2_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCondaEnv2.Text))
        {
            txtCondaEnv2.Text = "conda 환경 이름 입력";
            txtCondaEnv2.ForeColor = Color.Silver;
        }
    }


    private void InitializeManagerEvents()
    {
        // > 버튼 : 다음 프레임 데이터로 1건 이동
        btn_BigR.Click += (s, e) =>
        {
            var currentSource = filteredList.Count > 0 ? filteredList : dataList;
            if (currentIndex < currentSource.Count - 1) { currentIndex++; DisplayCurrentData(); }
        };

        // < 버튼 : 이전 프레임 데이터로 1건 이동
        btn_BigL.Click += (s, e) =>
        {
            if (currentIndex > 0) { currentIndex--; DisplayCurrentData(); }
        };

        // myTrackbar1 : 커스텀 재생바 드래그 시 인덱스 변경 연동
        myTrackbar1.ValueChanged += (s, e) =>
        {
            if (isUpdatingUI) return;

            currentIndex = myTrackbar1.Value;
            DisplayCurrentData();
        };

        // 리스트 선택 이벤트
        list_FileCheck.SelectedIndexChanged += (s, e) =>
        {
            // 자동재생 중에는 수동 선택 막기
            if (isAutoPlaying) return;

            // ⚠️ 여러 개 선택 중일 때는 현재 이미지 이동 및 자동 동기화 중단
            if (list_FileCheck.SelectedIndices.Count != 1)
                return;

            // 정상적으로 1개만 선택된 경우
            if (list_FileCheck.SelectedIndex != -1 &&
                list_FileCheck.SelectedIndex != currentIndex)
            {
                currentIndex = list_FileCheck.SelectedIndex;

                // 현재 선택된 이미지 표시
                DisplayCurrentData();
            }
        };

        // 찾기, 초기화, 삭제 버튼 이벤트 바인딩
        btn_Find.Click += btn_Find_Click;
        btn_Retry.Click += btn_Retry_Click;
        btn_Del.Click += btn_Del_Click;

   
    }
}


// catalog JSON 데이터 클래스
public class DonkeyData
{
    [JsonProperty("cam/image_array")]
    public string ImagePath { get; set; }

    [JsonProperty("user/angle")]
    public float Angle { get; set; }

    [JsonProperty("user/throttle")]
    public float Throttle { get; set; }
}

