using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace DonkeyCarrot;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
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
        psi.WorkingDirectory = @"c:\mycar"; //파일 받아오면 그곳 위치로 입력되게 바꿀예정

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
