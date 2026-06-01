namespace DonkeyCarrot;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabcMain = new TabControl();
        tabPage1 = new TabPage();
        txtAngleF = new TextBox();
        txtThrottleF = new TextBox();
        label2 = new Label();
        cmbSpeed = new ComboBox();
        btnThrottleGraph = new Button();
        btnAngleGraph = new Button();
        pic_Graph = new PictureBox();
        lbl_ThrottleV = new Label();
        lbl_Throttle = new Label();
        lbl_AngleV = new Label();
        lbl_Angle = new Label();
        lbl_FrameV = new Label();
        lbl_Frame = new Label();
        list_FileCheck = new ListBox();
        tbar_Dk = new TrackBar();
        btn_Retry = new Button();
        btn_Del = new Button();
        btn_SmallR = new Button();
        btn_Stop = new Button();
        btn_SmallL = new Button();
        btn_BigL = new Button();
        btn_BigR = new Button();
        pic_DkScreen = new PictureBox();
        btnLoadImages = new Button();
        btnLoadCatalog = new Button();
        tabp_Serve = new TabPage();
        btnStopTrain = new Button();
        lblStatus = new Label();
        lblConda = new Label();
        txtCondaEnv = new TextBox();
        txtLog = new TextBox();
        btnTrain = new Button();
        tabControl1 = new TabControl();
        tabPage2 = new TabPage();
        tabPage3 = new TabPage();
        label3 = new Label();
        myTrackbar1 = new myTrackbar();
        tabcMain.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pic_Graph).BeginInit();
        ((System.ComponentModel.ISupportInitialize)tbar_Dk).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pic_DkScreen).BeginInit();
        tabp_Serve.SuspendLayout();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // tabcMain
        // 
        tabcMain.Controls.Add(tabPage1);
        tabcMain.Controls.Add(tabp_Serve);
        tabcMain.Location = new Point(-5, 0);
        tabcMain.Margin = new Padding(2, 2, 2, 2);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(1180, 619);
        tabcMain.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(myTrackbar1);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(tabControl1);
        tabPage1.Controls.Add(txtAngleF);
        tabPage1.Controls.Add(txtThrottleF);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(cmbSpeed);
        tabPage1.Controls.Add(btnThrottleGraph);
        tabPage1.Controls.Add(btnAngleGraph);
        tabPage1.Controls.Add(pic_Graph);
        tabPage1.Controls.Add(lbl_ThrottleV);
        tabPage1.Controls.Add(lbl_Throttle);
        tabPage1.Controls.Add(lbl_AngleV);
        tabPage1.Controls.Add(lbl_Angle);
        tabPage1.Controls.Add(lbl_FrameV);
        tabPage1.Controls.Add(lbl_Frame);
        tabPage1.Controls.Add(list_FileCheck);
        tabPage1.Controls.Add(tbar_Dk);
        tabPage1.Controls.Add(btn_Retry);
        tabPage1.Controls.Add(btn_Del);
        tabPage1.Controls.Add(btn_SmallR);
        tabPage1.Controls.Add(btn_Stop);
        tabPage1.Controls.Add(btn_SmallL);
        tabPage1.Controls.Add(btn_BigL);
        tabPage1.Controls.Add(btn_BigR);
        tabPage1.Controls.Add(pic_DkScreen);
        tabPage1.Controls.Add(btnLoadImages);
        tabPage1.Controls.Add(btnLoadCatalog);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Margin = new Padding(2, 2, 2, 2);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(2, 2, 2, 2);
        tabPage1.Size = new Size(1172, 591);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        tabPage1.Click += tabPage1_Click;
        // 
        // txtAngleF
        // 
        txtAngleF.Location = new Point(763, 480);
        txtAngleF.Margin = new Padding(2, 2, 2, 2);
        txtAngleF.Name = "txtAngleF";
        txtAngleF.Size = new Size(111, 23);
        txtAngleF.TabIndex = 29;
        // 
        // txtThrottleF
        // 
        txtThrottleF.Location = new Point(763, 444);
        txtThrottleF.Margin = new Padding(2, 2, 2, 2);
        txtThrottleF.Name = "txtThrottleF";
        txtThrottleF.Size = new Size(111, 23);
        txtThrottleF.TabIndex = 28;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(693, 452);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(55, 15);
        label2.TabIndex = 27;
        label2.Text = "조건입력";
        // 
        // cmbSpeed
        // 
        cmbSpeed.FormattingEnabled = true;
        cmbSpeed.Location = new Point(450, 32);
        cmbSpeed.Margin = new Padding(2, 2, 2, 2);
        cmbSpeed.Name = "cmbSpeed";
        cmbSpeed.Size = new Size(116, 23);
        cmbSpeed.TabIndex = 23;
        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;
        // 
        // btnThrottleGraph
        // 
        btnThrottleGraph.Location = new Point(513, 534);
        btnThrottleGraph.Margin = new Padding(2, 2, 2, 2);
        btnThrottleGraph.Name = "btnThrottleGraph";
        btnThrottleGraph.Size = new Size(99, 36);
        btnThrottleGraph.TabIndex = 22;
        btnThrottleGraph.Text = "throttle 그래프";
        btnThrottleGraph.UseVisualStyleBackColor = true;
        // 
        // btnAngleGraph
        // 
        btnAngleGraph.Location = new Point(415, 534);
        btnAngleGraph.Margin = new Padding(2, 2, 2, 2);
        btnAngleGraph.Name = "btnAngleGraph";
        btnAngleGraph.Size = new Size(94, 36);
        btnAngleGraph.TabIndex = 21;
        btnAngleGraph.Text = "angle 그래프";
        btnAngleGraph.UseVisualStyleBackColor = true;
        // 
        // pic_Graph
        // 
        pic_Graph.Location = new Point(32, 421);
        pic_Graph.Margin = new Padding(2, 2, 2, 2);
        pic_Graph.Name = "pic_Graph";
        pic_Graph.Size = new Size(610, 111);
        pic_Graph.TabIndex = 20;
        pic_Graph.TabStop = false;
        // 
        // lbl_ThrottleV
        // 
        lbl_ThrottleV.AutoSize = true;
        lbl_ThrottleV.Font = new Font("맑은 고딕", 15F);
        lbl_ThrottleV.Location = new Point(370, 534);
        lbl_ThrottleV.Margin = new Padding(2, 0, 2, 0);
        lbl_ThrottleV.Name = "lbl_ThrottleV";
        lbl_ThrottleV.Size = new Size(23, 28);
        lbl_ThrottleV.TabIndex = 19;
        lbl_ThrottleV.Text = "0";
        lbl_ThrottleV.Click += label5_Click;
        // 
        // lbl_Throttle
        // 
        lbl_Throttle.AutoSize = true;
        lbl_Throttle.Font = new Font("맑은 고딕", 15F);
        lbl_Throttle.Location = new Point(311, 534);
        lbl_Throttle.Margin = new Padding(2, 0, 2, 0);
        lbl_Throttle.Name = "lbl_Throttle";
        lbl_Throttle.Size = new Size(56, 28);
        lbl_Throttle.TabIndex = 18;
        lbl_Throttle.Text = "속도:";
        // 
        // lbl_AngleV
        // 
        lbl_AngleV.AutoSize = true;
        lbl_AngleV.Font = new Font("맑은 고딕", 15F);
        lbl_AngleV.Location = new Point(249, 534);
        lbl_AngleV.Margin = new Padding(2, 0, 2, 0);
        lbl_AngleV.Name = "lbl_AngleV";
        lbl_AngleV.Size = new Size(23, 28);
        lbl_AngleV.TabIndex = 17;
        lbl_AngleV.Text = "0";
        // 
        // lbl_Angle
        // 
        lbl_Angle.AutoSize = true;
        lbl_Angle.Font = new Font("맑은 고딕", 15F);
        lbl_Angle.Location = new Point(178, 534);
        lbl_Angle.Margin = new Padding(2, 0, 2, 0);
        lbl_Angle.Name = "lbl_Angle";
        lbl_Angle.Size = new Size(76, 28);
        lbl_Angle.TabIndex = 16;
        lbl_Angle.Text = "조항각:";
        // 
        // lbl_FrameV
        // 
        lbl_FrameV.AutoSize = true;
        lbl_FrameV.Font = new Font("맑은 고딕", 15F);
        lbl_FrameV.Location = new Point(106, 534);
        lbl_FrameV.Margin = new Padding(2, 0, 2, 0);
        lbl_FrameV.Name = "lbl_FrameV";
        lbl_FrameV.Size = new Size(23, 28);
        lbl_FrameV.TabIndex = 15;
        lbl_FrameV.Text = "0";
        // 
        // lbl_Frame
        // 
        lbl_Frame.AutoSize = true;
        lbl_Frame.Font = new Font("맑은 고딕", 15F);
        lbl_Frame.Location = new Point(32, 534);
        lbl_Frame.Margin = new Padding(2, 0, 2, 0);
        lbl_Frame.Name = "lbl_Frame";
        lbl_Frame.Size = new Size(76, 28);
        lbl_Frame.TabIndex = 14;
        lbl_Frame.Text = "프레임:";
        // 
        // list_FileCheck
        // 
        list_FileCheck.FormattingEnabled = true;
        list_FileCheck.Location = new Point(693, 72);
        list_FileCheck.Margin = new Padding(2, 2, 2, 2);
        list_FileCheck.Name = "list_FileCheck";
        list_FileCheck.Size = new Size(442, 334);
        list_FileCheck.TabIndex = 13;
        list_FileCheck.SelectedIndexChanged += list_FileCheck_SelectedIndexChanged;
        // 
        // tbar_Dk
        // 
        tbar_Dk.Location = new Point(32, 372);
        tbar_Dk.Margin = new Padding(2, 2, 2, 2);
        tbar_Dk.Name = "tbar_Dk";
        tbar_Dk.Size = new Size(610, 45);
        tbar_Dk.TabIndex = 12;
        // 
        // btn_Retry
        // 
        btn_Retry.Location = new Point(1060, 431);
        btn_Retry.Margin = new Padding(2, 2, 2, 2);
        btn_Retry.Name = "btn_Retry";
        btn_Retry.Size = new Size(75, 34);
        btn_Retry.TabIndex = 11;
        btn_Retry.Text = "초기화";
        btn_Retry.UseVisualStyleBackColor = true;
        // 
        // btn_Del
        // 
        btn_Del.Location = new Point(968, 431);
        btn_Del.Margin = new Padding(2, 2, 2, 2);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(75, 34);
        btn_Del.TabIndex = 9;
        btn_Del.Text = "삭제";
        btn_Del.UseVisualStyleBackColor = true;
        // 
        // btn_SmallR
        // 
        btn_SmallR.Location = new Point(402, 336);
        btn_SmallR.Margin = new Padding(2, 2, 2, 2);
        btn_SmallR.Name = "btn_SmallR";
        btn_SmallR.Size = new Size(164, 34);
        btn_SmallR.TabIndex = 8;
        btn_SmallR.Text = ">>";
        btn_SmallR.UseVisualStyleBackColor = true;
        btn_SmallR.Click += btn_SmallR_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Location = new Point(258, 336);
        btn_Stop.Margin = new Padding(2, 2, 2, 2);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(140, 34);
        btn_Stop.TabIndex = 7;
        btn_Stop.Text = "stop";
        btn_Stop.UseVisualStyleBackColor = true;
        btn_Stop.Click += btn_Stop_Click;
        // 
        // btn_SmallL
        // 
        btn_SmallL.Location = new Point(106, 334);
        btn_SmallL.Margin = new Padding(2, 2, 2, 2);
        btn_SmallL.Name = "btn_SmallL";
        btn_SmallL.Size = new Size(148, 34);
        btn_SmallL.TabIndex = 6;
        btn_SmallL.Text = "<<";
        btn_SmallL.UseVisualStyleBackColor = true;
        btn_SmallL.Click += btn_SmallL_Click;
        // 
        // btn_BigL
        // 
        btn_BigL.Location = new Point(32, 72);
        btn_BigL.Margin = new Padding(2, 2, 2, 2);
        btn_BigL.Name = "btn_BigL";
        btn_BigL.Size = new Size(62, 296);
        btn_BigL.TabIndex = 5;
        btn_BigL.Text = "<";
        btn_BigL.UseVisualStyleBackColor = true;
        // 
        // btn_BigR
        // 
        btn_BigR.Location = new Point(580, 72);
        btn_BigR.Margin = new Padding(2, 2, 2, 2);
        btn_BigR.Name = "btn_BigR";
        btn_BigR.Size = new Size(62, 296);
        btn_BigR.TabIndex = 4;
        btn_BigR.Text = ">";
        btn_BigR.UseVisualStyleBackColor = true;
        // 
        // pic_DkScreen
        // 
        pic_DkScreen.BackColor = SystemColors.ActiveCaptionText;
        pic_DkScreen.Location = new Point(106, 72);
        pic_DkScreen.Margin = new Padding(2, 2, 2, 2);
        pic_DkScreen.Name = "pic_DkScreen";
        pic_DkScreen.Size = new Size(460, 258);
        pic_DkScreen.TabIndex = 2;
        pic_DkScreen.TabStop = false;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Location = new Point(1012, 26);
        btnLoadImages.Margin = new Padding(2, 2, 2, 2);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(123, 39);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = true;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Location = new Point(865, 26);
        btnLoadCatalog.Margin = new Padding(2, 2, 2, 2);
        btnLoadCatalog.Name = "btnLoadCatalog";
        btnLoadCatalog.Size = new Size(123, 39);
        btnLoadCatalog.TabIndex = 0;
        btnLoadCatalog.Text = "카탈로그 파일 \r\n불러오기\r\n";
        btnLoadCatalog.UseVisualStyleBackColor = true;
        btnLoadCatalog.Click += btnLoadCatalog_Click_1;
        // 
        // tabp_Serve
        // 
        tabp_Serve.BackColor = SystemColors.WindowFrame;
        tabp_Serve.Controls.Add(btnStopTrain);
        tabp_Serve.Controls.Add(lblStatus);
        tabp_Serve.Controls.Add(lblConda);
        tabp_Serve.Controls.Add(txtCondaEnv);
        tabp_Serve.Controls.Add(txtLog);
        tabp_Serve.Controls.Add(btnTrain);
        tabp_Serve.ForeColor = SystemColors.ControlText;
        tabp_Serve.Location = new Point(4, 24);
        tabp_Serve.Margin = new Padding(2, 2, 2, 2);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(2, 2, 2, 2);
        tabp_Serve.Size = new Size(1172, 591);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "tabPage2";
        tabp_Serve.Click += tabp_Serve_Click;
        // 
        // btnStopTrain
        // 
        btnStopTrain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnStopTrain.BackColor = Color.Brown;
        btnStopTrain.FlatStyle = FlatStyle.Flat;
        btnStopTrain.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnStopTrain.ForeColor = SystemColors.ButtonFace;
        btnStopTrain.Location = new Point(791, 16);
        btnStopTrain.Margin = new Padding(2, 2, 2, 2);
        btnStopTrain.Name = "btnStopTrain";
        btnStopTrain.Size = new Size(109, 45);
        btnStopTrain.TabIndex = 5;
        btnStopTrain.Text = "학습 정지";
        btnStopTrain.UseVisualStyleBackColor = false;
        btnStopTrain.Click += btnStopTrain_Click;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblStatus.ForeColor = Color.White;
        lblStatus.Location = new Point(472, 36);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(140, 25);
        lblStatus.TabIndex = 4;
        lblStatus.Text = "상태 : 대기 중 ";
        // 
        // lblConda
        // 
        lblConda.AutoSize = true;
        lblConda.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblConda.ForeColor = SystemColors.ActiveCaptionText;
        lblConda.Location = new Point(103, 36);
        lblConda.Name = "lblConda";
        lblConda.Size = new Size(165, 25);
        lblConda.TabIndex = 3;
        lblConda.Text = "Conda 환경 이름:";
        // 
        // txtCondaEnv
        // 
        txtCondaEnv.ForeColor = Color.Silver;
        txtCondaEnv.Location = new Point(273, 36);
        txtCondaEnv.Margin = new Padding(2, 2, 2, 2);
        txtCondaEnv.Multiline = true;
        txtCondaEnv.Name = "txtCondaEnv";
        txtCondaEnv.Size = new Size(183, 25);
        txtCondaEnv.TabIndex = 2;
        txtCondaEnv.Enter += txtCondaEnv_Enter;
        txtCondaEnv.Leave += txtCondaEnv_Leave;
        // 
        // txtLog
        // 
        txtLog.BackColor = SystemColors.InfoText;
        txtLog.ForeColor = Color.Lime;
        txtLog.Location = new Point(100, 70);
        txtLog.Margin = new Padding(2, 2, 2, 2);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(950, 491);
        txtLog.TabIndex = 1;
        txtLog.TextChanged += txtLog_TextChanged;
        // 
        // btnTrain
        // 
        btnTrain.BackColor = Color.DarkGreen;
        btnTrain.FlatStyle = FlatStyle.Flat;
        btnTrain.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnTrain.ForeColor = SystemColors.ControlLightLight;
        btnTrain.Location = new Point(913, 16);
        btnTrain.Margin = new Padding(2, 2, 2, 2);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(109, 45);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = false;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Location = new Point(38, 431);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(604, 100);
        tabControl1.TabIndex = 30;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(596, 72);
        tabPage2.TabIndex = 0;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Location = new Point(4, 24);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(192, 72);
        tabPage3.TabIndex = 1;
        tabPage3.Text = "tabPage3";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("한컴 말랑말랑 Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
        label3.Location = new Point(38, 18);
        label3.Name = "label3";
        label3.Size = new Size(216, 37);
        label3.TabIndex = 32;
        label3.Text = "DonkeyCarrot";
        label3.Click += label3_Click;
        // 
        // myTrackbar1
        // 
        myTrackbar1.BackColor = Color.Transparent;
        myTrackbar1.Location = new Point(32, 383);
        myTrackbar1.Maximum = 100;
        myTrackbar1.Minimum = 0;
        myTrackbar1.Name = "myTrackbar1";
        myTrackbar1.Size = new Size(610, 33);
        myTrackbar1.TabIndex = 33;
        myTrackbar1.Value = 30;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1174, 614);
        Controls.Add(tabcMain);
        Margin = new Padding(2, 2, 2, 2);
        Name = "Form1";
        Text = "DonkeyCarrot 1.0 v";
        tabcMain.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pic_Graph).EndInit();
        ((System.ComponentModel.ISupportInitialize)tbar_Dk).EndInit();
        ((System.ComponentModel.ISupportInitialize)pic_DkScreen).EndInit();
        tabp_Serve.ResumeLayout(false);
        tabp_Serve.PerformLayout();
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabcMain;
    private TabPage tabPage1;
    private Button btnLoadCatalog;
    private Button btnLoadImages;
    private PictureBox pic_DkScreen;
    private Button btn_SmallR;
    private Button btn_Stop;
    private Button btn_SmallL;
    private Button btn_BigL;
    private Button btn_BigR;
    private Button btn_Retry;
    private Button btn_Del;
    private TrackBar tbar_Dk;
    private ListBox list_FileCheck;
    private Label lblStatus;
    private Label lbl_ThrottleV;
    private Label lbl_Throttle;
    private Label lbl_AngleV;
    private Label lbl_Angle;
    private Label lbl_FrameV;
    private Label lbl_Frame;
    private TabPage tabp_Serve;
    private TextBox txtLog;
    private Button btnTrain;
    private TextBox txtCondaEnv;
    private PictureBox pic_Graph;
    private Button btnAngleGraph;
    private Button btnThrottleGraph;
    private ComboBox cmbSpeed;
    private Label lblConda;
    private Button btnStopTrain;
    private Label label2;
    private TextBox txtAngleF;
    private TextBox txtThrottleF;
    private TabControl tabControl1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private Label label3;
    private myTrackbar myTrackbar1;
}

