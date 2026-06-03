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
        chk_Throttle = new CheckBox();
        chk_Angle = new CheckBox();
        pic_Graph = new PictureBox();
        txtThrottleF = new TextBox();
        txtAngleF = new TextBox();
        myTrackbar1 = new myTrackbar();
        lblTitle = new Label();
        lblFilter = new Label();
        cmbSpeed = new ComboBox();
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
        tabcMain.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pic_Graph).BeginInit();
        ((System.ComponentModel.ISupportInitialize)tbar_Dk).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pic_DkScreen).BeginInit();
        tabp_Serve.SuspendLayout();
        SuspendLayout();
        // 
        // tabcMain
        // 
        tabcMain.Controls.Add(tabPage1);
        tabcMain.Controls.Add(tabp_Serve);
        tabcMain.Location = new Point(-7, 0);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(1686, 1032);
        tabcMain.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(chk_Throttle);
        tabPage1.Controls.Add(chk_Angle);
        tabPage1.Controls.Add(pic_Graph);
        tabPage1.Controls.Add(txtThrottleF);
        tabPage1.Controls.Add(txtAngleF);
        tabPage1.Controls.Add(myTrackbar1);
        tabPage1.Controls.Add(lblTitle);
        tabPage1.Controls.Add(lblFilter);
        tabPage1.Controls.Add(cmbSpeed);
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
        tabPage1.Location = new Point(4, 34);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1678, 994);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        tabPage1.Click += tabPage1_Click;
        // 
        // chk_Throttle
        // 
        chk_Throttle.AutoSize = true;
        chk_Throttle.Location = new Point(185, 718);
        chk_Throttle.Name = "chk_Throttle";
        chk_Throttle.Size = new Size(74, 29);
        chk_Throttle.TabIndex = 37;
        chk_Throttle.Text = "속도";
        chk_Throttle.UseVisualStyleBackColor = true;
        // 
        // chk_Angle
        // 
        chk_Angle.AutoSize = true;
        chk_Angle.Location = new Point(54, 718);
        chk_Angle.Name = "chk_Angle";
        chk_Angle.Size = new Size(92, 29);
        chk_Angle.TabIndex = 36;
        chk_Angle.Text = "조향각";
        chk_Angle.UseVisualStyleBackColor = true;
        // 
        // pic_Graph
        // 
        pic_Graph.Location = new Point(54, 753);
        pic_Graph.Name = "pic_Graph";
        pic_Graph.Size = new Size(871, 162);
        pic_Graph.TabIndex = 20;
        pic_Graph.TabStop = false;
        // 
        // txtThrottleF
        // 
        txtThrottleF.Location = new Point(1096, 744);
        txtThrottleF.Name = "txtThrottleF";
        txtThrottleF.Size = new Size(105, 31);
        txtThrottleF.TabIndex = 35;
        // 
        // txtAngleF
        // 
        txtAngleF.Location = new Point(1096, 709);
        txtAngleF.Name = "txtAngleF";
        txtAngleF.Size = new Size(105, 31);
        txtAngleF.TabIndex = 34;
        // 
        // myTrackbar1
        // 
        myTrackbar1.BackColor = Color.Transparent;
        myTrackbar1.Location = new Point(46, 634);
        myTrackbar1.Margin = new Padding(6, 8, 6, 8);
        myTrackbar1.Maximum = 100;
        myTrackbar1.Minimum = 0;
        myTrackbar1.Name = "myTrackbar1";
        myTrackbar1.Size = new Size(871, 55);
        myTrackbar1.TabIndex = 33;
        myTrackbar1.Value = 30;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("한컴 말랑말랑 Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblTitle.Location = new Point(54, 30);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(321, 57);
        lblTitle.TabIndex = 32;
        lblTitle.Text = "DonkeyCarrot";
        lblTitle.Click += label3_Click;
        // 
        // lblFilter
        // 
        lblFilter.AutoSize = true;
        lblFilter.Location = new Point(990, 689);
        lblFilter.Name = "lblFilter";
        lblFilter.Size = new Size(84, 25);
        lblFilter.TabIndex = 27;
        lblFilter.Text = "조건입력";
        // 
        // cmbSpeed
        // 
        cmbSpeed.FormattingEnabled = true;
        cmbSpeed.Location = new Point(643, 53);
        cmbSpeed.Name = "cmbSpeed";
        cmbSpeed.Size = new Size(164, 33);
        cmbSpeed.TabIndex = 23;
        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;
        // 
        // lbl_ThrottleV
        // 
        lbl_ThrottleV.AutoSize = true;
        lbl_ThrottleV.Font = new Font("맑은 고딕", 15F);
        lbl_ThrottleV.Location = new Point(568, 917);
        lbl_ThrottleV.Name = "lbl_ThrottleV";
        lbl_ThrottleV.Size = new Size(35, 41);
        lbl_ThrottleV.TabIndex = 19;
        lbl_ThrottleV.Text = "0";
        lbl_ThrottleV.Click += label5_Click;
        // 
        // lbl_Throttle
        // 
        lbl_Throttle.AutoSize = true;
        lbl_Throttle.Font = new Font("맑은 고딕", 15F);
        lbl_Throttle.Location = new Point(483, 917);
        lbl_Throttle.Name = "lbl_Throttle";
        lbl_Throttle.Size = new Size(85, 41);
        lbl_Throttle.TabIndex = 18;
        lbl_Throttle.Text = "속도:";
        // 
        // lbl_AngleV
        // 
        lbl_AngleV.AutoSize = true;
        lbl_AngleV.Font = new Font("맑은 고딕", 15F);
        lbl_AngleV.Location = new Point(395, 917);
        lbl_AngleV.Name = "lbl_AngleV";
        lbl_AngleV.Size = new Size(35, 41);
        lbl_AngleV.TabIndex = 17;
        lbl_AngleV.Text = "0";
        // 
        // lbl_Angle
        // 
        lbl_Angle.AutoSize = true;
        lbl_Angle.Font = new Font("맑은 고딕", 15F);
        lbl_Angle.Location = new Point(293, 917);
        lbl_Angle.Name = "lbl_Angle";
        lbl_Angle.Size = new Size(115, 41);
        lbl_Angle.TabIndex = 16;
        lbl_Angle.Text = "조항각:";
        // 
        // lbl_FrameV
        // 
        lbl_FrameV.AutoSize = true;
        lbl_FrameV.Font = new Font("맑은 고딕", 15F);
        lbl_FrameV.Location = new Point(190, 917);
        lbl_FrameV.Name = "lbl_FrameV";
        lbl_FrameV.Size = new Size(35, 41);
        lbl_FrameV.TabIndex = 15;
        lbl_FrameV.Text = "0";
        // 
        // lbl_Frame
        // 
        lbl_Frame.AutoSize = true;
        lbl_Frame.Font = new Font("맑은 고딕", 15F);
        lbl_Frame.Location = new Point(85, 917);
        lbl_Frame.Name = "lbl_Frame";
        lbl_Frame.Size = new Size(115, 41);
        lbl_Frame.TabIndex = 14;
        lbl_Frame.Text = "프레임:";
        // 
        // list_FileCheck
        // 
        list_FileCheck.FormattingEnabled = true;
        list_FileCheck.Location = new Point(990, 120);
        list_FileCheck.Name = "list_FileCheck";
        list_FileCheck.Size = new Size(630, 554);
        list_FileCheck.TabIndex = 13;
        list_FileCheck.SelectedIndexChanged += list_FileCheck_SelectedIndexChanged;
        // 
        // tbar_Dk
        // 
        tbar_Dk.Location = new Point(46, 620);
        tbar_Dk.Name = "tbar_Dk";
        tbar_Dk.Size = new Size(871, 69);
        tbar_Dk.TabIndex = 12;
        // 
        // btn_Retry
        // 
        btn_Retry.Location = new Point(1514, 709);
        btn_Retry.Name = "btn_Retry";
        btn_Retry.Size = new Size(107, 66);
        btn_Retry.TabIndex = 11;
        btn_Retry.Text = "초기화";
        btn_Retry.UseVisualStyleBackColor = true;
        // 
        // btn_Del
        // 
        btn_Del.Location = new Point(1383, 709);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(107, 66);
        btn_Del.TabIndex = 9;
        btn_Del.Text = "삭제";
        btn_Del.UseVisualStyleBackColor = true;
        // 
        // btn_SmallR
        // 
        btn_SmallR.Location = new Point(574, 560);
        btn_SmallR.Name = "btn_SmallR";
        btn_SmallR.Size = new Size(234, 57);
        btn_SmallR.TabIndex = 8;
        btn_SmallR.Text = ">>";
        btn_SmallR.UseVisualStyleBackColor = true;
        btn_SmallR.Click += btn_SmallR_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Location = new Point(369, 560);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(200, 57);
        btn_Stop.TabIndex = 7;
        btn_Stop.Text = "stop";
        btn_Stop.UseVisualStyleBackColor = true;
        btn_Stop.Click += btn_Stop_Click;
        // 
        // btn_SmallL
        // 
        btn_SmallL.Location = new Point(151, 557);
        btn_SmallL.Name = "btn_SmallL";
        btn_SmallL.Size = new Size(211, 57);
        btn_SmallL.TabIndex = 6;
        btn_SmallL.Text = "<<";
        btn_SmallL.UseVisualStyleBackColor = true;
        btn_SmallL.Click += btn_SmallL_Click;
        // 
        // btn_BigL
        // 
        btn_BigL.Location = new Point(46, 120);
        btn_BigL.Name = "btn_BigL";
        btn_BigL.Size = new Size(89, 493);
        btn_BigL.TabIndex = 5;
        btn_BigL.Text = "<";
        btn_BigL.UseVisualStyleBackColor = true;
        // 
        // btn_BigR
        // 
        btn_BigR.Location = new Point(829, 120);
        btn_BigR.Name = "btn_BigR";
        btn_BigR.Size = new Size(89, 493);
        btn_BigR.TabIndex = 4;
        btn_BigR.Text = ">";
        btn_BigR.UseVisualStyleBackColor = true;
        // 
        // pic_DkScreen
        // 
        pic_DkScreen.BackColor = SystemColors.ActiveCaptionText;
        pic_DkScreen.Location = new Point(151, 120);
        pic_DkScreen.Name = "pic_DkScreen";
        pic_DkScreen.Size = new Size(657, 430);
        pic_DkScreen.TabIndex = 2;
        pic_DkScreen.TabStop = false;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Location = new Point(1446, 43);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(176, 65);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = true;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Location = new Point(1236, 43);
        btnLoadCatalog.Name = "btnLoadCatalog";
        btnLoadCatalog.Size = new Size(176, 65);
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
        tabp_Serve.Location = new Point(4, 34);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(3);
        tabp_Serve.Size = new Size(1678, 994);
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
        btnStopTrain.ForeColor = SystemColors.ControlLightLight;
        btnStopTrain.Location = new Point(1130, 27);
        btnStopTrain.Name = "btnStopTrain";
        btnStopTrain.Size = new Size(156, 75);
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
        lblStatus.Location = new Point(674, 60);
        lblStatus.Margin = new Padding(4, 0, 4, 0);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(210, 40);
        lblStatus.TabIndex = 4;
        lblStatus.Text = "상태 : 대기 중 ";
        // 
        // lblConda
        // 
        lblConda.AutoSize = true;
        lblConda.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblConda.ForeColor = SystemColors.ActiveCaptionText;
        lblConda.Location = new Point(147, 60);
        lblConda.Margin = new Padding(4, 0, 4, 0);
        lblConda.Name = "lblConda";
        lblConda.Size = new Size(250, 40);
        lblConda.TabIndex = 3;
        lblConda.Text = "Conda 환경 이름:";
        // 
        // txtCondaEnv
        // 
        txtCondaEnv.ForeColor = Color.Silver;
        txtCondaEnv.Location = new Point(390, 60);
        txtCondaEnv.Multiline = true;
        txtCondaEnv.Name = "txtCondaEnv";
        txtCondaEnv.Size = new Size(260, 39);
        txtCondaEnv.TabIndex = 2;
        txtCondaEnv.Enter += txtCondaEnv_Enter;
        txtCondaEnv.Leave += txtCondaEnv_Leave;
        // 
        // txtLog
        // 
        txtLog.BackColor = SystemColors.InfoText;
        txtLog.ForeColor = Color.Lime;
        txtLog.Location = new Point(143, 117);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(1355, 816);
        txtLog.TabIndex = 1;
        txtLog.TextChanged += txtLog_TextChanged;
        // 
        // btnTrain
        // 
        btnTrain.BackColor = Color.DarkGreen;
        btnTrain.FlatStyle = FlatStyle.Flat;
        btnTrain.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnTrain.ForeColor = SystemColors.ControlLightLight;
        btnTrain.Location = new Point(1304, 27);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(156, 75);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = false;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1677, 1023);
        Controls.Add(tabcMain);
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
    private ComboBox cmbSpeed;
    private Label lblConda;
    private Button btnStopTrain;
    private Label lblFilter;
    private Label lblTitle;
    private myTrackbar myTrackbar1;
    private TextBox txtThrottleF;
    private TextBox txtAngleF;
    private CheckBox chk_Throttle;
    private CheckBox chk_Angle;
}

