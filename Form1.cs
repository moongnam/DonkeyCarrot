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
    // catalog 데이터를 저장할 리스트
    List<DonkeyData> dataList = new List<DonkeyData>();

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

    public Form1()
    {
        InitializeComponent();

        // 기존 버튼 클릭 이벤트 연결

        btnLoadImages.Click += btnLoadImages_Click;

        //그래프 이벤트 연결
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

        cmbSpeed.SelectedItem = "1.0";// 기본값 1.0x 설정

        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged; // 콤보박스 선택 변경 이벤트 핸들러 연결
    }


    private void DisplayCurrentData()
    {
        // 데이터 리스트가 비어 있으면 화면 갱신을 하지 않음
        if (dataList == null || dataList.Count == 0) return;

        // 인덱스가 데이터 범위를 벗어나지 않도록 안전장치 설정
        if (currentIndex < 0) currentIndex = 0;
        if (currentIndex >= dataList.Count) currentIndex = dataList.Count - 1;

        // 1. 현재 주행 데이터 가져오기
        DonkeyData currentData = dataList[currentIndex];

        // 2. 우측 상단 라벨(lbl_FrameV, lbl_AngleV, lbl_ThrottleV)에 값 반영
        lbl_FrameV.Text = currentIndex.ToString();
        lbl_AngleV.Text = currentData.Angle.ToString("F4");       // 소수점 4자리 포맷팅
        lbl_ThrottleV.Text = currentData.Throttle.ToString("F4");

        // 3. 하단 트랙바(tbar_Dk) 슬라이더 위치 동기화
        tbar_Dk.Maximum = dataList.Count - 1;
        tbar_Dk.Value = currentIndex;

        // 4. 왼쪽 아래 파일 리스트(list_FileCheck)의 선택 하이라이트 동기화
        if (list_FileCheck.Items.Count > currentIndex)
        {
            list_FileCheck.SelectedIndex = currentIndex;
        }

        // 5. 중앙 PictureBox(pic_DkScreen)에 주행 이미지 바인딩
        string imageName = Path.GetFileName(currentData.ImagePath);
        string actualImagePath = imageList.Find(path => path.Contains(imageName));

        if (!string.IsNullOrEmpty(actualImagePath) && File.Exists(actualImagePath))
        {
            // 메모리 누수 방지를 위해 기존 이미지 리소스 자원 해제
            if (pic_DkScreen.Image != null) pic_DkScreen.Image.Dispose();

            pic_DkScreen.Image = System.Drawing.Image.FromFile(actualImagePath);
            pic_DkScreen.SizeMode = PictureBoxSizeMode.Zoom; // 이미지 비율 유지 모드
        }
        else
        {
            pic_DkScreen.Image = null;
        }
    }


    private void InitializeManagerEvents()
    {
        // > 버튼 : 다음 프레임 데이터로 1건 이동
        btn_BigR.Click += (s, e) =>
        {
            if (currentIndex < dataList.Count - 1) { currentIndex++; DisplayCurrentData(); }
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

    // 찾기 버튼 : 누르면 자동으로 '직진 주행 데이터(Angle이 0에 가까운 프레임)'만 필터링
    private void btn_Find_Click(object sender, EventArgs e)
    {
        if (dataList == null || dataList.Count == 0) return;

        // 조향각(Angle) 오차가 -0.01 ~ +0.01 사이인 클린 직진 데이터만 LINQ로 추출
        var filtered = dataList.Where(d => Math.Abs(d.Angle) < 0.01).ToList();

        if (filtered.Count > 0)
        {
            list_FileCheck.Items.Clear();
            foreach (var d in filtered)
            {
                list_FileCheck.Items.Add($"[직진구간] {Path.GetFileName(d.ImagePath)} (Angle:{d.Angle:F3})");
            }
            MessageBox.Show($"전체 데이터 중 완전 직진 구간 데이터 {filtered.Count}건을 필터링했습니다.");
        }
        else
        {
            MessageBox.Show("직진 주행 조건과 일치하는 데이터가 존재하지 않습니다.");
        }
    }

    // 초기화 버튼 : 필터링된 리스트를 풀고 전체 리스트로 복구
    private void btn_Retry_Click(object sender, EventArgs e)
    {
        UpdateFileList();
    }


    private void btn_Del_Click(object sender, EventArgs e)
    {
        if (dataList == null || dataList.Count == 0) return;

        DialogResult result = MessageBox.Show(
            $"현재 선택된 {currentIndex + 1}번째 주행 프레임을 모델 학습 대상에서 제외하시겠습니까?",
            "데이터 정제 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (result == DialogResult.Yes)
        {
            // 메모리 리스트와 UI 리스트박스에서 동시 삭제
            dataList.RemoveAt(currentIndex);
            list_FileCheck.Items.RemoveAt(currentIndex);

            MessageBox.Show("해당 프레임 데이터가 성공적으로 제외되었습니다.");

            // 데이터 삭제 후 인덱스 범위 재조정 및 새로고침
            if (currentIndex >= dataList.Count) currentIndex = dataList.Count - 1;
            DisplayCurrentData();
        }
    }

    // catalog 파일 불러오기 버튼
    private void btnLoadCatalog_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        fbd.Description = "data 폴더 선택";
        fbd.InitialDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (fbd.ShowDialog() == DialogResult.OK)
        {
            dataList.Clear();

            string dataFolderPath = fbd.SelectedPath;

            // tub 경로 저장
            tubPath = dataFolderPath;

            // 현재 폴더부터 manage.py 찾기
            DirectoryInfo currentDir =
                new DirectoryInfo(dataFolderPath);

            while (currentDir != null)
            {
                string managePath =
                    Path.Combine(currentDir.FullName, "manage.py");

                // manage.py 발견
                if (File.Exists(managePath))
                {
                    projectPath = currentDir.FullName;
                    break;
                }

                // 상위 폴더 이동
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

                    DonkeyData data =
                        JsonConvert.DeserializeObject<DonkeyData>(line);

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

    //그래프 angle 이나 throttle 선택 버튼
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
        if (dataList.Count == 0)
            return;

        int width = pic_Graph.Width;
        int height = pic_Graph.Height;

        Bitmap bmp = new Bitmap(width, height);
        Graphics g = Graphics.FromImage(bmp);

        g.Clear(Color.White);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // 여백
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

        foreach (var data in dataList)
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

        // 테두리
        g.DrawRectangle(axisPen, graphLeft, graphTop, graphWidth, graphHeight);

        // Y축 눈금
        int yTickCount = 5;

        for (int i = 0; i <= yTickCount; i++)
        {
            int y = graphBottom - (i * graphHeight / yTickCount);
            float value = minValue + (i * (maxValue - minValue) / yTickCount);

            g.DrawLine(gridPen, graphLeft, y, graphRight, y);
            g.DrawString(value.ToString("0.00"), font, textBrush, 5, y - 7);
        }

        // X축 눈금 간격 자동 계산
        int xStep;

        if (dataList.Count <= 100)
            xStep = 10;
        else if (dataList.Count <= 300)
            xStep = 20;
        else if (dataList.Count <= 800)
            xStep = 50;
        else if (dataList.Count <= 1500)
            xStep = 100;
        else if (dataList.Count <= 3000)
            xStep = 200;
        else
            xStep = 500;

        int lastTextX = -9999;

        // X축 눈금
        for (int i = 0; i < dataList.Count; i += xStep)
        {
            int x = graphLeft + (i * graphWidth / (dataList.Count - 1));

            g.DrawLine(gridPen, x, graphTop, x, graphBottom);

            // 글자가 너무 가까우면 안 쓰기
            if (x - lastTextX > 35)
            {
                g.DrawString(i.ToString(), font, textBrush, x - 10, graphBottom + 5);
                lastTextX = x;
            }
        }

        // 그래프 선 그리기
        for (int i = 0; i < dataList.Count - 1; i++)
        {
            float value1 = graphType == "Angle" ? dataList[i].Angle : dataList[i].Throttle;
            float value2 = graphType == "Angle" ? dataList[i + 1].Angle : dataList[i + 1].Throttle;

            int x1 = graphLeft + (i * graphWidth / (dataList.Count - 1));
            int x2 = graphLeft + ((i + 1) * graphWidth / (dataList.Count - 1));

            int y1 = graphBottom - (int)((value1 - minValue) / (maxValue - minValue) * graphHeight);
            int y2 = graphBottom - (int)((value2 - minValue) / (maxValue - minValue) * graphHeight);

            g.DrawLine(linePen, x1, y1, x2, y2);
        }

        // 제목
        g.DrawString("user/" + graphType.ToLower(), font, Brushes.Red, graphRight - 90, graphTop - 20);

        pic_Graph.Image = bmp;
    }

    // 이미지 폴더 불러오기 버튼
    private void btnLoadImages_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        fbd.Description = "images 폴더 선택";
        fbd.InitialDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (fbd.ShowDialog() == DialogResult.OK)
        {
            imageList.Clear();

            string[] jpgFiles =
                Directory.GetFiles(fbd.SelectedPath, "*.jpg");

            string[] pngFiles =
                Directory.GetFiles(fbd.SelectedPath, "*.png");

            imageList.AddRange(jpgFiles);
            imageList.AddRange(pngFiles);

            MessageBox.Show(
                "이미지 불러오기 완료\n" +
                "이미지 개수 : " + imageList.Count
            );

            // 이미지 폴더까지 마저 로드되면 화면 싱크를 다시 한번 리프레시해 줌
            DisplayCurrentData();
        }
    }

    private void btnTrain_Click_1(object sender, EventArgs e)
    {
        //로그 초기화
        txtLog.Clear();

        // WSL 경로 변환
        string linuxProjectPath = projectPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        string linuxTubPath = tubPath
            .Replace(@"\\wsl.localhost\Ubuntu-22.04", "")
            .Replace("\\", "/");

        // 학습 프로세스 객체 초기화
        Process trainProcess = null;

        // 새로운 프로세스 시작 정보 객체 생성
        ProcessStartInfo psi = new ProcessStartInfo();

        // 실행할 명령어 설정 (wsl을 통해 Python 명령어 실행)
        psi.FileName = @"C:\Windows\System32\wsl.exe";

        // Conda 환경 이름을 텍스트박스에서 읽어오기
        string condaEnv = txtCondaEnv.Text;

        // Conda 환경 이름이 비어 있으면 경고 메시지 출력 후 종료
        if (string.IsNullOrWhiteSpace(condaEnv) || condaEnv == "conda 환경 이름 입력")
        {
            MessageBox.Show("Conda 환경 이름을 입력하세요.");
            return;
        }

        // 실행할 명령어 설정 (WSL 내에서 Python 스크립트 실행)
        psi.Arguments =
            $"-d Ubuntu-22.04 -- bash -c \"cd '{linuxProjectPath}' && source ~/miniconda3/bin/activate {condaEnv} && python train.py --tub '{linuxTubPath}' --model ./models/donkeycarrot.h5 --type linear\"";
        // 작업 디렉토리 설정 (WSL 내에서의 경로)
        psi.EnvironmentVariables["PATH"] =
            @"C:\Windows\System32";

        // 로그 출력 받기
        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;

        // 필수 설정
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;

        trainProcess = new Process();
        trainProcess.StartInfo = psi;

        // 출력 로그 받기
        trainProcess.OutputDataReceived += (s, ev) =>
        {
            if (!string.IsNullOrEmpty(ev.Data))
            {
                string log = ev.Data;

                // 영어를 한글로 변환
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
                }
            }
        };

        // 에러 로그 받기
        trainProcess.ErrorDataReceived += (s, ev) =>
        {
            if (!string.IsNullOrEmpty(ev.Data))
            {
                string log = ev.Data;

                // 영어를 한글로 변환
                log = log.Replace("ERROR", "오류");
                log = log.Replace("failed", "실패");
                log = log.Replace("No module named", "모듈을 찾을 수 없습니다");

                Invoke(new Action(() =>
                {
                    // 실제 오류만 "오류:" 붙이기
                    if (log.Contains("오류") ||
                        log.Contains("실패") ||
                        log.Contains("Traceback") ||
                        log.Contains("Exception"))
                    {
                        txtLog.AppendText("[오류] " + log + Environment.NewLine);
                    }
                    else
                    {
                        txtLog.AppendText("[로그] " + log + Environment.NewLine);
                    }
                }));
            }
        };

        // 프로세스 종료 이벤트 핸들러 등록
        trainProcess.EnableRaisingEvents = true;

        // 학습 프로세스가 종료될 때 호출되는 이벤트 핸들러
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
                        MessageBox.Show("학습이 완료되었습니다.");
                    }
                    else
                    {
                        txtLog.AppendText($"학습이 비정상 종료되었습니다. 종료 코드: {exitCode}" + Environment.NewLine);
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

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void btn_BigL_Click(object sender, EventArgs e)
    {

    }

    // 🛡️ [디자이너 충돌 방지용 안전 필드 생성]
    private void btnLoadCatalog_Click_1(object sender, EventArgs e)
    {
        // 실수로 더블클릭해서 생긴 디자이너 에러를 무해하게 넘어가도록 빈 껍데기 선언
        btnLoadCatalog_Click(sender, e);
    }

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

    // 자동 재생 타이머 이벤트 핸들러
    private void AutoTimer_Tick(object sender, EventArgs e)
    {
        if (dataList == null || dataList.Count == 0) return;

        currentIndex += autoDirection;

        if (currentIndex >= dataList.Count)
            currentIndex = 0;

        if (currentIndex < 0)
            currentIndex = dataList.Count - 1;

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
        double speed =
        Convert.ToDouble(cmbSpeed.SelectedItem);

        autoTimer.Interval =
            (int)(1000 / speed);
    }
}

// catalog JSON 데이터 클래스
public class DonkeyData
{
    // 이미지 파일 이름
    [JsonProperty("cam/image_array")]
    public string ImagePath { get; set; }

    // 조향값(angle)
    [JsonProperty("user/angle")]
    public float Angle { get; set; }

    // 속도값(throttle)
    [JsonProperty("user/throttle")]
    public float Throttle { get; set; }
}