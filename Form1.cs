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
        OpenFileDialog ofd = new OpenFileDialog();

        ofd.Title = "catalog 파일 아무거나 1개 선택";
        ofd.Filter = "Catalog File (*.catalog)|*.catalog";

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            dataList.Clear();

            // 선택한 catalog가 들어있는 폴더
            string folderPath = Path.GetDirectoryName(ofd.FileName);

            // 같은 폴더 안의 모든 .catalog 파일 가져오기
            string[] catalogFiles = Directory.GetFiles(
                folderPath,
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
        // 새로운 프로세스 시작 정보 객체 생성
        ProcessStartInfo psi = new ProcessStartInfo();

        // 실행할 프로그램과 인자 설정
        psi.FileName = "python";

        // 실행할 명령어 설정
        psi.Arguments = "python manage.py train";

        // Python 프로젝트 위치
        psi.WorkingDirectory = @"c:\mycar"; //파일 받아오면 그곳 위치로 입력되게 바꿀 예정임

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