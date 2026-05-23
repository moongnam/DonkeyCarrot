using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

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

    public Form1()
    {
        InitializeComponent();

        // 버튼 클릭 이벤트 연결
        btnLoadCatalog.Click += btnLoadCatalog_Click;
        btnLoadImages.Click += btnLoadImages_Click;
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
        }
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
        }
    }

    private void btnTrain_Click_1(object sender, EventArgs e)
    {
        // WSL 경로 변환
        string linuxProjectPath =
            projectPath.Replace(
                @"\\wsl.localhost\Ubuntu-22.04",
                ""
            );

        string linuxTubPath =
            tubPath.Replace(
                @"\\wsl.localhost\Ubuntu-22.04",
                ""
            );

        // 새로운 프로세스 시작 정보 객체 생성
        ProcessStartInfo psi = new ProcessStartInfo();

        // 실행할 명령어 설정 (wsl을 통해 Python 명령어 실행)
        psi.FileName = "wsl";

        // 실행할 명령어 설정
        psi.Arguments =
            $"bash -c \"cd '{linuxProjectPath}' && source ~/miniconda3/bin/activate e2e_env && python manage.py train --tub '{linuxTubPath}' --model donkeycarrot.model --type linear\"";

        // Python 프로젝트 위치
        psi.WorkingDirectory = projectPath;

        // 로그 출력 받기
        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;

        // 필수 설정
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;

        Process processs = new Process();
        processs.StartInfo = psi;

        // 출력 로그 받기
        processs.OutputDataReceived += (s, ev) =>
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

                // 로그를 TextBox에 추가
                Invoke(new Action(() =>
                {
                    txtLog.AppendText(log + Environment.NewLine);
                }));
            }
        };

        // 에러 로그 받기
        processs.ErrorDataReceived += (s, ev) =>
        {
            if (!string.IsNullOrEmpty(ev.Data))
            {
                string log = ev.Data;

                // 영어를 한글로 변환
                log = log.Replace("ERROR", "오류");
                log = log.Replace("failed", "실패");
                log = log.Replace("No module named", "모듈을 찾을 수 없습니다");

                // 에러 로그를 TextBox에 추가
                Invoke(new Action(() =>
                {
                    txtLog.AppendText("오류: " + log + Environment.NewLine);
                }));
            }
        };

        processs.Start();

        processs.BeginOutputReadLine();
        processs.BeginErrorReadLine();
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