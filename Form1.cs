using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq; // 🔍 LINQ 필터링 검색을 위해 추가
using System.Windows.Forms;
using System.Drawing;

namespace DonkeyCarrot;

public partial class Form1 : Form
{
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

    

    Process trainProcess = null;

    // 학습 중지 요청 여부
    bool stopRequested = false;

    public Form1()
    {
        InitializeComponent();

        // 기존 버튼 클릭 이벤트 연결
        btnLoadImages.Click += btnLoadImages_Click;

        // 그래프 이벤트 연결
        btnAngleGraph.Click += btnAngleGraph_Click;
        btnThrottleGraph.Click += btnThrottleGraph_Click;

        // pic_Graph 외곽선
        pic_Graph.BorderStyle = BorderStyle.FixedSingle;

        // Conda 환경 이름 입력 텍스트박스 초기 설정
        txtCondaEnv.Text = "conda 환경 이름 입력";
        txtCondaEnv.ForeColor = Color.Silver;

        // 텍스트박스 포커스 이벤트 연결
        txtCondaEnv.Enter += txtCondaEnv_Enter;
        txtCondaEnv.Leave += txtCondaEnv_Leave;

        InitializeManagerEvents();

        autoTimer.Interval = 500; // 0.5초 간격으로 자동 재생

        autoTimer.Tick += AutoTimer_Tick; // 타이머 틱 이벤트 핸들러 연결

        // 재생 속도 콤보박스 초기화
        cmbSpeed.Items.Add("0.25");
        cmbSpeed.Items.Add("0.5");
        cmbSpeed.Items.Add("0.75");
        cmbSpeed.Items.Add("1.0");
        cmbSpeed.Items.Add("1.25");
        cmbSpeed.Items.Add("1.5");
        cmbSpeed.Items.Add("1.75");
        cmbSpeed.Items.Add("2.0");

        cmbSpeed.SelectedItem = "1.0"; // 기본값 1.0x 설정

        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged; // 콤보박스 선택 변경 이벤트 핸들러 연결
    }


    private void DisplayCurrentData()
    {
        // 🔍 현재 활성화된 리스트(필터링 상태 반영) 기준으로 데이터 체크
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;

        if (currentSource == null || currentSource.Count == 0) return;

        // 인덱스가 데이터 범위를 벗어나지 않도록 안전장치 설정
        if (currentIndex < 0) currentIndex = 0;
        if (currentIndex >= currentSource.Count) currentIndex = currentSource.Count - 1;

        // 1. 현재 주행 데이터 가져오기
        DonkeyData currentData = currentSource[currentIndex];

        // 2. 우측 상단 라벨에 값 반영
        lbl_FrameV.Text = currentIndex.ToString();
        lbl_AngleV.Text = currentData.Angle.ToString("F4"); // 소수점 4자리 포맷팅
        lbl_ThrottleV.Text = currentData.Throttle.ToString("F4");

        // 3. 하단 트랙바 슬라이더 위치 동기화
        tbar_Dk.Maximum = currentSource.Count - 1;
        tbar_Dk.Value = currentIndex;

        // 4. 왼쪽 아래 파일 리스트의 선택 하이라이트 동기화
        if (list_FileCheck.Items.Count > currentIndex)
        {
            list_FileCheck.SelectedIndex = currentIndex;
        }

        // 5. 중앙 PictureBox에 주행 이미지 바인딩
        string imageName = Path.GetFileName(currentData.ImagePath);
        string actualImagePath = imageList.Find(path => path.Contains(imageName));

        if (!string.IsNullOrEmpty(actualImagePath) && File.Exists(actualImagePath))
        {
            // PictureBox 이미지 해제 (파일 잠김 방지 및 메모리 관리)
            if (pic_DkScreen.Image != null) pic_DkScreen.Image.Dispose();

            // ⚠️ 파일을 독점하지 않고 메모리로만 읽어오도록 개선 (삭제할 때 파일 잠김 오류를 방지합니다!)
            using (FileStream fs = new FileStream(actualImagePath, FileMode.Open, FileAccess.Read))
            {
                pic_DkScreen.Image = System.Drawing.Image.FromStream(fs);
            }
            pic_DkScreen.SizeMode = PictureBoxSizeMode.Zoom;
        }
        else
        {
            if (pic_DkScreen.Image != null) pic_DkScreen.Image.Dispose();
            pic_DkScreen.Image = null;
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

        // tbar_Dk : 트랙바 슬라이더 드래그 시 인덱스 변경 연동
        tbar_Dk.Scroll += (s, e) =>
        {
            currentIndex = tbar_Dk.Value;
            DisplayCurrentData();
        };

        // list_FileCheck : 파일 목록에서 특정 항목 클릭 시 해당 프레임 갱신
        list_FileCheck.SelectedIndexChanged += (s, e) =>
        {
            if (list_FileCheck.SelectedIndex != -1 && list_FileCheck.SelectedIndex != currentIndex)
            {
                currentIndex = list_FileCheck.SelectedIndex;
                DisplayCurrentData();
            }
        };

        // 찾기, 초기화, 삭제 버튼 이벤트 바인딩
        btn_Find.Click += btn_Find_Click;
        btn_Retry.Click += btn_Retry_Click;
        btn_Del.Click += btn_Del_Click;
    }


    // 카탈로그 파일 로드가 성공한 직후 호출하여 왼쪽 리스트박스를 가득 채우는 함수
    private void UpdateFileList()
    {
        list_FileCheck.Items.Clear();
        filteredList.Clear(); // 🔍 원본 파일 리스트를 볼 때는 필터링 리스트 비우기

        foreach (var data in dataList)
        {
            list_FileCheck.Items.Add(Path.GetFileName(data.ImagePath));
        }

        if (dataList.Count > 0)
        {
            currentIndex = 0;
            DisplayCurrentData();
        }
    }

    // 🔍 찾기 버튼 : 사용자가 텍스트 상자에 입력한 동적 수식(부호, 숫자)을 기반으로 정밀 솎아내기 수행
    private void btn_Find_Click(object sender, EventArgs e)
    {
        if (dataList == null || dataList.Count == 0) return;

        // 입력 텍스트 가져오기 및 공백 제거
        string throttleInput = txtThrottleF.Text.Replace(" ", "");
        string angleInput = txtAngleF.Text.Replace(" ", "");

        // 둘 다 아무것도 입력하지 않았을 때 예외 처리
        if ((string.IsNullOrEmpty(throttleInput) || throttleInput == "throttle>0") &&
            (string.IsNullOrEmpty(angleInput) || angleInput == "angle>0"))
        {
            MessageBox.Show("솎아낼 수식 조건을 입력해주세요!\n예: throttle>0.2 또는 angle<-0.1", "알림");
            return;
        }

        // LINQ 필터링을 사용하여 조건에 맞는 데이터만 추출
        filteredList = dataList.Where(d => {
            bool isThrottleMatch = true;
            bool isAngleMatch = true;

            // 스로틀 조건 체크 (사용자가 기본값 외에 다른 수식을 입력했을 때)
            if (!string.IsNullOrEmpty(throttleInput) && throttleInput.Contains("throttle") && throttleInput != "throttle>0")
            {
                isThrottleMatch = EvaluateExpression(throttleInput, "throttle", d.Throttle);
            }

            // 앵글 조건 체크 (사용자가 기본값 외에 다른 수식을 입력했을 때)
            if (!string.IsNullOrEmpty(angleInput) && angleInput.Contains("angle") && angleInput != "angle>0")
            {
                isAngleMatch = EvaluateExpression(angleInput, "angle", d.Angle);
            }

            return isThrottleMatch && isAngleMatch;
        }).ToList();

        // 솎아낸 결과가 있을 경우 화면 갱신
        if (filteredList.Count > 0)
        {
            list_FileCheck.Items.Clear();
            foreach (var d in filteredList)
            {
                list_FileCheck.Items.Add(Path.GetFileName(d.ImagePath));
            }

            currentIndex = 0;
            DisplayCurrentData();
            DrawGraph("Angle"); // 그래프 최신화
            MessageBox.Show($"조건에 맞는 데이터 {filteredList.Count}건을 솎아냈습니다.\n[삭제] 버튼을 누르면 물리 파일 및 학습 대상에서 제외됩니다.");
        }
        else
        {
            filteredList.Clear();
            MessageBox.Show("입력하신 솎아내기 조건과 일치하는 데이터가 존재하지 않습니다.", "알림");
        }
    }

    // 💡 문자열 수식을 해석해서 크고 작음을 판별해 주는 핵심 도우미 메소드
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
        txtThrottleF.Text = "throttle>0";
        txtAngleF.Text = "angle>0";
        UpdateFileList();
        DrawGraph("Angle");
    }


    // 🔧 삭제 버튼 : 목록 제거뿐만 아니라 하드디스크의 실제 물리 이미지 파일까지 함께 삭제
    private void btn_Del_Click(object sender, EventArgs e)
    {
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;

        if (currentSource == null || currentSource.Count == 0 || currentIndex < 0 || currentIndex >= currentSource.Count) return;

        DonkeyData targetData = currentSource[currentIndex];
        string imageName = Path.GetFileName(targetData.ImagePath);

        DialogResult result = MessageBox.Show(
            $"선택된 {imageName} 파일을 하드디스크와 모델 학습 대상에서 영구히 삭제하시겠습니까?",
            "실제 파일 영구 삭제 경고",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (result == DialogResult.Yes)
        {
            // 1. 실제 물리 이미지 파일 찾아서 지우기
            string actualImagePath = imageList.Find(path => path.Contains(imageName));

            try
            {
                // 이미지 뷰어 잠금 해제를 위해 PictureBox 리소스 완전 비우기
                if (pic_DkScreen.Image != null)
                {
                    pic_DkScreen.Image.Dispose();
                    pic_DkScreen.Image = null;
                }

                if (!string.IsNullOrEmpty(actualImagePath) && File.Exists(actualImagePath))
                {
                    File.Delete(actualImagePath); // 하드디스크에서 영구 제거
                    imageList.Remove(actualImagePath); // 내부 경로 목록 리스트에서도 제거
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"물리 파일 삭제 중 프로세스 잠금 오류가 발생했습니다:\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. 데이터 메모리 리스트에서 삭제 진행 (양쪽 동시 동기화)
            if (filteredList.Count > 0)
            {
                filteredList.RemoveAt(currentIndex);
            }
            dataList.Remove(targetData); // 원본 소스에서도 완전히 파괴

            // 3. UI 리스트박스 항목 제거
            list_FileCheck.Items.RemoveAt(currentIndex);

            MessageBox.Show("실제 이미지 파일과 데이터 로그가 완전히 삭제되었습니다.");

            // 4. 후속 인덱스 및 UI 재조정
            var checkSource = filteredList.Count > 0 ? filteredList : dataList;
            if (checkSource.Count == 0)
            {
                currentIndex = 0;
                list_FileCheck.Items.Clear();
            }
            else if (currentIndex >= checkSource.Count)
            {
                currentIndex = checkSource.Count - 1;
            }

            DisplayCurrentData();
            DrawGraph("Angle"); // 데이터가 변동되었으므로 그래프 최신화
        }
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
            tubPath = dataFolderPath;

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
            DrawGraph("Angle");
        }
    }

    // 그래프 angle 이나 throttle 선택 버튼
    private void btnAngleGraph_Click(object sender, EventArgs e)
    {
        DrawGraph("Angle");
    }

    private void btnThrottleGraph_Click(object sender, EventArgs e)
    {
        DrawGraph("Throttle");
    }

    // 그래프 그리는 함수
    private void DrawGraph(string graphType)
    {
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;

        if (currentSource.Count == 0)
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
        Pen linePen = new Pen(Color.Red, 2);

        Font font = new Font("Arial", 8);
        Brush textBrush = Brushes.Black;

        float minValue = 0;
        float maxValue = 0;

        foreach (var data in currentSource)
        {
            float v = graphType == "Angle" ? data.Angle : data.Throttle;

            if (v < minValue) minValue = v;
            if (v > maxValue) maxValue = v;
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

        for (int i = 0; i < currentSource.Count - 1; i++)
        {
            float value1 = graphType == "Angle" ? currentSource[i].Angle : currentSource[i].Throttle;
            float value2 = graphType == "Angle" ? currentSource[i + 1].Angle : currentSource[i + 1].Throttle;

            int x1 = graphLeft + (i * graphWidth / (currentSource.Count - 1));
            int x2 = graphLeft + ((i + 1) * graphWidth / (currentSource.Count - 1));

            int y1 = graphBottom - (int)((value1 - minValue) / (maxValue - minValue) * graphHeight);
            int y2 = graphBottom - (int)((value2 - minValue) / (maxValue - minValue) * graphHeight);

            g.DrawLine(linePen, x1, y1, x2, y2);
        }

        g.DrawString("user/" + graphType.ToLower(), font, Brushes.Red, graphRight - 90, graphTop - 20);

        pic_Graph.Image = bmp;
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
        txtLog.Clear();

        string linuxProjectPath = projectPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        string linuxTubPath = tubPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        
        ProcessStartInfo psi = new ProcessStartInfo();

        psi.FileName = @"C:\Windows\System32\wsl.exe";

        string condaEnv = txtCondaEnv.Text;

        if (string.IsNullOrWhiteSpace(condaEnv) || condaEnv == "conda 환경 이름 입력")
        {
            lblStatus.Text = "상태: 대기 중";
            lblStatus.ForeColor = Color.White;

            MessageBox.Show("Conda 환경 이름을 입력하세요.");
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

                log = log.Replace("Epoch", "학습");
                log = log.Replace("loss", "손실값");
                log = log.Replace("Loading", "불러오는 중");
                log = log.Replace("Saving", "저장 중");
                log = log.Replace("Training", "학습");
                log = log.Replace("Complete", "완료");
                log = log.Replace("Model", "모델");

                if (!IsDisposed && txtLog.IsHandleCreated)
                {
                    Invoke(new Action(() =>
                    {
                        txtLog.AppendText(log + Environment.NewLine);
                    }));

                    if (log.Contains("학습"))
                    {
                        if (stopRequested)
                        {
                            trainProcess.Kill();

                            Invoke(new Action(() =>
                            {
                                txtLog.AppendText(
                                    "학습 종료 요청" +
                                    Environment.NewLine
                                );

                                lblStatus.Text = "상태: 학습 중지";
                                lblStatus.ForeColor = Color.Orange;
                            }));

                            stopRequested = false;
                        }
                    }
                }
            }
        };

        trainProcess.ErrorDataReceived += (s, ev) =>
        {
            if (!string.IsNullOrEmpty(ev.Data))
            {
                string log = ev.Data;

                log = log.Replace("ERROR", "오류");
                log = log.Replace("failed", "실패");
                log = log.Replace("No module named", "모듈을 찾을 수 없습니다");

                Invoke(new Action(() =>
                {
                    if (log.Contains("오류") || log.Contains("실패") || log.Contains("모듈을 찾을 수 없습니다"))
                    {
                        txtLog.AppendText("[오류] " + log + Environment.NewLine);
                        lblStatus.Text = "상태: 오류 발생!";
                        lblStatus.ForeColor = Color.Red;
                    }
                    else
                    {
                        txtLog.AppendText("[로그] " + log + Environment.NewLine);
                    }
                }));
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

                    if (exitCode == 0)
                    {
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
        autoTimer.Start();
    }

    private void AutoTimer_Tick(object sender, EventArgs e)
    {
        var currentSource = filteredList.Count > 0 ? filteredList : dataList;
        if (currentSource == null || currentSource.Count == 0) return;

        currentIndex += autoDirection;

        if (currentIndex >= currentSource.Count) currentIndex = 0;
        if (currentIndex < 0) currentIndex = currentSource.Count - 1;

        DisplayCurrentData();
    }

    private void btn_Stop_Click(object sender, EventArgs e)
    {
        autoTimer.Stop();
    }

    private void btn_SmallL_Click(object sender, EventArgs e)
    {
        autoDirection = -1;
        autoTimer.Start();
    }

    private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
    {
        double speed = Convert.ToDouble(cmbSpeed.SelectedItem);
        autoTimer.Interval = (int)(1000 / speed);
    }

    private void txtLog_TextChanged(object sender, EventArgs e) { }

    private void btnStopTrain_Click(object sender, EventArgs e)
    {
        if (trainProcess != null && !trainProcess.HasExited)
        {
            stopRequested = true;

            txtLog.AppendText(
                "학습 중지 요청됨..." +
                Environment.NewLine
            );
        }
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