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
        components = new System.ComponentModel.Container();
        tabcMain = new TabControl();
        tabPage1 = new TabPage();
        txtCondaEnv2 = new TextBox();
        btnLoadPilot = new Button();
        btn_Restore = new Button();
        lbl_To2 = new Label();
        lbl_To = new Label();
        lblThrottle = new Label();
        lblAngle = new Label();
        txtThrottleF2 = new TextBox();
        txtAngleF2 = new TextBox();
        btn_Find = new Button();
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
        tab_Trash = new TabControl();
        tabPage2 = new TabPage();
        list_FileCheck = new ListBox();
        tabPage3 = new TabPage();
        list_DeletedCheck = new ListBox();
        tabp_Serve = new TabPage();
        txtTrainLoss = new TextBox();
        label2 = new Label();
        label1 = new Label();
        picTrainGraph = new PictureBox();
        btnStopTrain = new Button();
        lblStatus = new Label();
        lblConda = new Label();
        txtCondaEnv = new TextBox();
        txtLog = new TextBox();
        btnTrain = new Button();
        toolTip1 = new ToolTip(components);
        tabcMain.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pic_Graph).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pic_DkScreen).BeginInit();
        tab_Trash.SuspendLayout();
        tabPage2.SuspendLayout();
        tabPage3.SuspendLayout();
        tabp_Serve.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picTrainGraph).BeginInit();
        SuspendLayout();
        // 
        // tabcMain
        // 
        tabcMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabcMain.Controls.Add(tabPage1);
        tabcMain.Controls.Add(tabp_Serve);
        tabcMain.Location = new Point(-8, 0);
        tabcMain.Margin = new Padding(6, 3, 6, 3);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(2431, 1405);
        tabcMain.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(txtCondaEnv2);
        tabPage1.Controls.Add(btnLoadPilot);
        tabPage1.Controls.Add(btn_Restore);
        tabPage1.Controls.Add(lbl_To2);
        tabPage1.Controls.Add(lbl_To);
        tabPage1.Controls.Add(lblThrottle);
        tabPage1.Controls.Add(lblAngle);
        tabPage1.Controls.Add(txtThrottleF2);
        tabPage1.Controls.Add(txtAngleF2);
        tabPage1.Controls.Add(btn_Find);
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
        tabPage1.Controls.Add(tab_Trash);
        tabPage1.Location = new Point(8, 46);
        tabPage1.Margin = new Padding(6, 3, 6, 3);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(6, 3, 6, 3);
        tabPage1.Size = new Size(2415, 1351);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "메인";
        tabPage1.UseVisualStyleBackColor = true;
        tabPage1.Click += tabPage1_Click;
        // 
        // txtCondaEnv2
        // 
        txtCondaEnv2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtCondaEnv2.ForeColor = Color.Silver;
        txtCondaEnv2.Location = new Point(1395, 69);
        txtCondaEnv2.Margin = new Padding(5, 5, 5, 5);
        txtCondaEnv2.Name = "txtCondaEnv2";
        txtCondaEnv2.Size = new Size(284, 39);
        txtCondaEnv2.TabIndex = 48;
        txtCondaEnv2.Text = "conda 환경 이름 입력";
        txtCondaEnv2.Enter += txtCondaEnv2_Enter;
        txtCondaEnv2.Leave += txtCondaEnv2_Leave;
        // 
        // btnLoadPilot
        // 
        btnLoadPilot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadPilot.Location = new Point(1185, 54);
        btnLoadPilot.Margin = new Padding(5, 5, 5, 5);
        btnLoadPilot.Name = "btnLoadPilot";
        btnLoadPilot.Size = new Size(184, 69);
        btnLoadPilot.TabIndex = 47;
        btnLoadPilot.Text = "학습 모델 선택";
        btnLoadPilot.UseVisualStyleBackColor = true;
        // 
        // btn_Restore
        // 
        btn_Restore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Restore.Location = new Point(2120, 1029);
        btn_Restore.Margin = new Padding(5, 3, 5, 3);
        btn_Restore.Name = "btn_Restore";
        btn_Restore.Size = new Size(143, 83);
        btn_Restore.TabIndex = 15;
        btn_Restore.Text = "복구";
        btn_Restore.UseVisualStyleBackColor = true;
        // 
        // lbl_To2
        // 
        lbl_To2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lbl_To2.AutoSize = true;
        lbl_To2.Location = new Point(1650, 966);
        lbl_To2.Margin = new Padding(6, 0, 6, 0);
        lbl_To2.Name = "lbl_To2";
        lbl_To2.Size = new Size(31, 32);
        lbl_To2.TabIndex = 45;
        lbl_To2.Text = "~";
        // 
        // lbl_To
        // 
        lbl_To.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lbl_To.AutoSize = true;
        lbl_To.Location = new Point(1650, 923);
        lbl_To.Margin = new Padding(6, 0, 6, 0);
        lbl_To.Name = "lbl_To";
        lbl_To.Size = new Size(31, 32);
        lbl_To.TabIndex = 44;
        lbl_To.Text = "~";
        // 
        // lblThrottle
        // 
        lblThrottle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblThrottle.AutoSize = true;
        lblThrottle.Location = new Point(1352, 970);
        lblThrottle.Margin = new Padding(6, 0, 6, 0);
        lblThrottle.Name = "lblThrottle";
        lblThrottle.Size = new Size(62, 32);
        lblThrottle.TabIndex = 43;
        lblThrottle.Text = "속도";
        // 
        // lblAngle
        // 
        lblAngle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblAngle.AutoSize = true;
        lblAngle.Location = new Point(1352, 923);
        lblAngle.Margin = new Padding(6, 0, 6, 0);
        lblAngle.Name = "lblAngle";
        lblAngle.Size = new Size(86, 32);
        lblAngle.TabIndex = 42;
        lblAngle.Text = "조항각";
        // 
        // txtThrottleF2
        // 
        txtThrottleF2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtThrottleF2.Location = new Point(1692, 963);
        txtThrottleF2.Margin = new Padding(6, 3, 6, 3);
        txtThrottleF2.Name = "txtThrottleF2";
        txtThrottleF2.Size = new Size(146, 39);
        txtThrottleF2.TabIndex = 41;
        // 
        // txtAngleF2
        // 
        txtAngleF2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtAngleF2.Location = new Point(1692, 915);
        txtAngleF2.Margin = new Padding(6, 3, 6, 3);
        txtAngleF2.Name = "txtAngleF2";
        txtAngleF2.Size = new Size(146, 39);
        txtAngleF2.TabIndex = 39;
        // 
        // btn_Find
        // 
        btn_Find.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Find.Location = new Point(1938, 1029);
        btn_Find.Margin = new Padding(6, 3, 6, 3);
        btn_Find.Name = "btn_Find";
        btn_Find.Size = new Size(148, 83);
        btn_Find.TabIndex = 38;
        btn_Find.Text = "찾기";
        btn_Find.UseVisualStyleBackColor = true;
        // 
        // chk_Throttle
        // 
        chk_Throttle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chk_Throttle.AutoSize = true;
        chk_Throttle.Location = new Point(258, 920);
        chk_Throttle.Margin = new Padding(6, 3, 6, 3);
        chk_Throttle.Name = "chk_Throttle";
        chk_Throttle.Size = new Size(94, 36);
        chk_Throttle.TabIndex = 37;
        chk_Throttle.Text = "속도";
        chk_Throttle.UseVisualStyleBackColor = true;
        // 
        // chk_Angle
        // 
        chk_Angle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chk_Angle.AutoSize = true;
        chk_Angle.Location = new Point(76, 920);
        chk_Angle.Margin = new Padding(6, 3, 6, 3);
        chk_Angle.Name = "chk_Angle";
        chk_Angle.Size = new Size(118, 36);
        chk_Angle.TabIndex = 36;
        chk_Angle.Text = "조향각";
        chk_Angle.UseVisualStyleBackColor = true;
        // 
        // pic_Graph
        // 
        pic_Graph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pic_Graph.Location = new Point(76, 963);
        pic_Graph.Margin = new Padding(6, 3, 6, 3);
        pic_Graph.Name = "pic_Graph";
        pic_Graph.Size = new Size(1220, 206);
        pic_Graph.TabIndex = 20;
        pic_Graph.TabStop = false;
        // 
        // txtThrottleF
        // 
        txtThrottleF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtThrottleF.Location = new Point(1490, 963);
        txtThrottleF.Margin = new Padding(6, 3, 6, 3);
        txtThrottleF.Name = "txtThrottleF";
        txtThrottleF.Size = new Size(146, 39);
        txtThrottleF.TabIndex = 35;
        // 
        // txtAngleF
        // 
        txtAngleF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtAngleF.Location = new Point(1490, 915);
        txtAngleF.Margin = new Padding(6, 3, 6, 3);
        txtAngleF.Name = "txtAngleF";
        txtAngleF.Size = new Size(146, 39);
        txtAngleF.TabIndex = 34;
        // 
        // myTrackbar1
        // 
        myTrackbar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        myTrackbar1.BackColor = Color.Transparent;
        myTrackbar1.Location = new Point(64, 802);
        myTrackbar1.Margin = new Padding(8, 10, 8, 10);
        myTrackbar1.Maximum = 100;
        myTrackbar1.Minimum = 0;
        myTrackbar1.Name = "myTrackbar1";
        myTrackbar1.Size = new Size(1220, 70);
        myTrackbar1.TabIndex = 33;
        myTrackbar1.Value = 30;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblTitle.Location = new Point(76, 38);
        lblTitle.Margin = new Padding(6, 0, 6, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(397, 67);
        lblTitle.TabIndex = 32;
        lblTitle.Text = "DonkeyCarrot";
        lblTitle.Click += label3_Click;
        // 
        // lblFilter
        // 
        lblFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblFilter.AutoSize = true;
        lblFilter.Location = new Point(1386, 882);
        lblFilter.Margin = new Padding(6, 0, 6, 0);
        lblFilter.Name = "lblFilter";
        lblFilter.Size = new Size(110, 32);
        lblFilter.TabIndex = 27;
        lblFilter.Text = "조건입력";
        // 
        // cmbSpeed
        // 
        cmbSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbSpeed.FormattingEnabled = true;
        cmbSpeed.Location = new Point(902, 67);
        cmbSpeed.Margin = new Padding(6, 3, 6, 3);
        cmbSpeed.Name = "cmbSpeed";
        cmbSpeed.Size = new Size(228, 40);
        cmbSpeed.TabIndex = 23;
        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;
        // 
        // lbl_ThrottleV
        // 
        lbl_ThrottleV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_ThrottleV.AutoSize = true;
        lbl_ThrottleV.Font = new Font("맑은 고딕", 15F);
        lbl_ThrottleV.Location = new Point(795, 1174);
        lbl_ThrottleV.Margin = new Padding(6, 0, 6, 0);
        lbl_ThrottleV.Name = "lbl_ThrottleV";
        lbl_ThrottleV.Size = new Size(45, 54);
        lbl_ThrottleV.TabIndex = 19;
        lbl_ThrottleV.Text = "0";
        lbl_ThrottleV.Click += label5_Click;
        // 
        // lbl_Throttle
        // 
        lbl_Throttle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Throttle.AutoSize = true;
        lbl_Throttle.Font = new Font("맑은 고딕", 15F);
        lbl_Throttle.Location = new Point(678, 1174);
        lbl_Throttle.Margin = new Padding(6, 0, 6, 0);
        lbl_Throttle.Name = "lbl_Throttle";
        lbl_Throttle.Size = new Size(112, 54);
        lbl_Throttle.TabIndex = 18;
        lbl_Throttle.Text = "속도:";
        // 
        // lbl_AngleV
        // 
        lbl_AngleV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_AngleV.AutoSize = true;
        lbl_AngleV.Font = new Font("맑은 고딕", 15F);
        lbl_AngleV.Location = new Point(554, 1174);
        lbl_AngleV.Margin = new Padding(6, 0, 6, 0);
        lbl_AngleV.Name = "lbl_AngleV";
        lbl_AngleV.Size = new Size(45, 54);
        lbl_AngleV.TabIndex = 17;
        lbl_AngleV.Text = "0";
        // 
        // lbl_Angle
        // 
        lbl_Angle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Angle.AutoSize = true;
        lbl_Angle.Font = new Font("맑은 고딕", 15F);
        lbl_Angle.Location = new Point(412, 1174);
        lbl_Angle.Margin = new Padding(6, 0, 6, 0);
        lbl_Angle.Name = "lbl_Angle";
        lbl_Angle.Size = new Size(152, 54);
        lbl_Angle.TabIndex = 16;
        lbl_Angle.Text = "조항각:";
        // 
        // lbl_FrameV
        // 
        lbl_FrameV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_FrameV.AutoSize = true;
        lbl_FrameV.Font = new Font("맑은 고딕", 15F);
        lbl_FrameV.Location = new Point(266, 1174);
        lbl_FrameV.Margin = new Padding(6, 0, 6, 0);
        lbl_FrameV.Name = "lbl_FrameV";
        lbl_FrameV.Size = new Size(45, 54);
        lbl_FrameV.TabIndex = 15;
        lbl_FrameV.Text = "0";
        // 
        // lbl_Frame
        // 
        lbl_Frame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Frame.AutoSize = true;
        lbl_Frame.Font = new Font("맑은 고딕", 15F);
        lbl_Frame.Location = new Point(118, 1174);
        lbl_Frame.Margin = new Padding(6, 0, 6, 0);
        lbl_Frame.Name = "lbl_Frame";
        lbl_Frame.Size = new Size(152, 54);
        lbl_Frame.TabIndex = 14;
        lbl_Frame.Text = "프레임:";
        // 
        // btn_Retry
        // 
        btn_Retry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Retry.Location = new Point(2120, 909);
        btn_Retry.Margin = new Padding(6, 3, 6, 3);
        btn_Retry.Name = "btn_Retry";
        btn_Retry.Size = new Size(148, 83);
        btn_Retry.TabIndex = 11;
        btn_Retry.Text = "초기화";
        btn_Retry.UseVisualStyleBackColor = true;
        // 
        // btn_Del
        // 
        btn_Del.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Del.Location = new Point(1938, 909);
        btn_Del.Margin = new Padding(6, 3, 6, 3);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(148, 83);
        btn_Del.TabIndex = 9;
        btn_Del.Text = "삭제";
        btn_Del.UseVisualStyleBackColor = true;
        // 
        // btn_SmallR
        // 
        btn_SmallR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_SmallR.Location = new Point(804, 717);
        btn_SmallR.Margin = new Padding(6, 3, 6, 3);
        btn_SmallR.Name = "btn_SmallR";
        btn_SmallR.Size = new Size(328, 74);
        btn_SmallR.TabIndex = 8;
        btn_SmallR.Text = ">>";
        btn_SmallR.UseVisualStyleBackColor = true;
        btn_SmallR.Click += btn_SmallR_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btn_Stop.Location = new Point(516, 717);
        btn_Stop.Margin = new Padding(6, 3, 6, 3);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(280, 74);
        btn_Stop.TabIndex = 7;
        btn_Stop.Text = "stop";
        btn_Stop.UseVisualStyleBackColor = true;
        btn_Stop.Click += btn_Stop_Click;
        // 
        // btn_SmallL
        // 
        btn_SmallL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btn_SmallL.Location = new Point(212, 714);
        btn_SmallL.Margin = new Padding(6, 3, 6, 3);
        btn_SmallL.Name = "btn_SmallL";
        btn_SmallL.Size = new Size(296, 74);
        btn_SmallL.TabIndex = 6;
        btn_SmallL.Text = "<<";
        btn_SmallL.UseVisualStyleBackColor = true;
        btn_SmallL.Click += btn_SmallL_Click;
        // 
        // btn_BigL
        // 
        btn_BigL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        btn_BigL.Location = new Point(64, 154);
        btn_BigL.Margin = new Padding(6, 3, 6, 3);
        btn_BigL.Name = "btn_BigL";
        btn_BigL.Size = new Size(124, 630);
        btn_BigL.TabIndex = 5;
        btn_BigL.Text = "<";
        btn_BigL.UseVisualStyleBackColor = true;
        // 
        // btn_BigR
        // 
        btn_BigR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btn_BigR.Location = new Point(1160, 154);
        btn_BigR.Margin = new Padding(6, 3, 6, 3);
        btn_BigR.Name = "btn_BigR";
        btn_BigR.Size = new Size(124, 630);
        btn_BigR.TabIndex = 4;
        btn_BigR.Text = ">";
        btn_BigR.UseVisualStyleBackColor = true;
        // 
        // pic_DkScreen
        // 
        pic_DkScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pic_DkScreen.BackColor = SystemColors.ActiveCaptionText;
        pic_DkScreen.Location = new Point(212, 154);
        pic_DkScreen.Margin = new Padding(6, 3, 6, 3);
        pic_DkScreen.Name = "pic_DkScreen";
        pic_DkScreen.Size = new Size(918, 550);
        pic_DkScreen.TabIndex = 2;
        pic_DkScreen.TabStop = false;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadImages.Location = new Point(2024, 54);
        btnLoadImages.Margin = new Padding(6, 3, 6, 3);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(246, 83);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = true;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadCatalog.Location = new Point(1730, 54);
        btnLoadCatalog.Margin = new Padding(6, 3, 6, 3);
        btnLoadCatalog.Name = "btnLoadCatalog";
        btnLoadCatalog.Size = new Size(246, 83);
        btnLoadCatalog.TabIndex = 0;
        btnLoadCatalog.Text = "카탈로그 파일 \r\n불러오기\r\n";
        btnLoadCatalog.UseVisualStyleBackColor = true;
        btnLoadCatalog.Click += btnLoadCatalog_Click_1;
        // 
        // tab_Trash
        // 
        tab_Trash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        tab_Trash.Controls.Add(tabPage2);
        tab_Trash.Controls.Add(tabPage3);
        tab_Trash.Location = new Point(1361, 144);
        tab_Trash.Margin = new Padding(5, 3, 5, 3);
        tab_Trash.Name = "tab_Trash";
        tab_Trash.SelectedIndex = 0;
        tab_Trash.Size = new Size(907, 741);
        tab_Trash.TabIndex = 46;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(list_FileCheck);
        tabPage2.Location = new Point(8, 46);
        tabPage2.Margin = new Padding(5, 3, 5, 3);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(5, 3, 5, 3);
        tabPage2.Size = new Size(891, 687);
        tabPage2.TabIndex = 0;
        tabPage2.Text = "파일 목록";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // list_FileCheck
        // 
        list_FileCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        list_FileCheck.FormattingEnabled = true;
        list_FileCheck.Location = new Point(-6, 6);
        list_FileCheck.Margin = new Padding(6, 3, 6, 3);
        list_FileCheck.Name = "list_FileCheck";
        list_FileCheck.Size = new Size(880, 612);
        list_FileCheck.TabIndex = 13;
        list_FileCheck.SelectedIndexChanged += list_FileCheck_SelectedIndexChanged;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(list_DeletedCheck);
        tabPage3.Location = new Point(8, 46);
        tabPage3.Margin = new Padding(5, 3, 5, 3);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(5, 3, 5, 3);
        tabPage3.Size = new Size(891, 687);
        tabPage3.TabIndex = 1;
        tabPage3.Text = "복구";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // list_DeletedCheck
        // 
        list_DeletedCheck.FormattingEnabled = true;
        list_DeletedCheck.Location = new Point(0, 8);
        list_DeletedCheck.Margin = new Padding(5, 3, 5, 3);
        list_DeletedCheck.Name = "list_DeletedCheck";
        list_DeletedCheck.Size = new Size(881, 676);
        list_DeletedCheck.TabIndex = 14;
        // 
        // tabp_Serve
        // 
        tabp_Serve.BackColor = SystemColors.WindowFrame;
        tabp_Serve.Controls.Add(txtTrainLoss);
        tabp_Serve.Controls.Add(label2);
        tabp_Serve.Controls.Add(label1);
        tabp_Serve.Controls.Add(picTrainGraph);
        tabp_Serve.Controls.Add(btnStopTrain);
        tabp_Serve.Controls.Add(lblStatus);
        tabp_Serve.Controls.Add(lblConda);
        tabp_Serve.Controls.Add(txtCondaEnv);
        tabp_Serve.Controls.Add(txtLog);
        tabp_Serve.Controls.Add(btnTrain);
        tabp_Serve.ForeColor = SystemColors.ControlText;
        tabp_Serve.Location = new Point(8, 46);
        tabp_Serve.Margin = new Padding(6, 3, 6, 3);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(6, 3, 6, 3);
        tabp_Serve.Size = new Size(2415, 1351);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "학습";
        tabp_Serve.Click += tabp_Serve_Click;
        // 
        // txtTrainLoss
        // 
        txtTrainLoss.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtTrainLoss.Location = new Point(1909, 898);
        txtTrainLoss.Margin = new Padding(5, 3, 5, 3);
        txtTrainLoss.Multiline = true;
        txtTrainLoss.Name = "txtTrainLoss";
        txtTrainLoss.ScrollBars = ScrollBars.Vertical;
        txtTrainLoss.Size = new Size(419, 238);
        txtTrainLoss.TabIndex = 11;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(1678, 957);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(227, 32);
        label2.TabIndex = 10;
        label2.Text = "파란선: 검증 오차값";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(1678, 902);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(227, 32);
        label1.TabIndex = 9;
        label1.Text = "빨간선: 학습 오차값";
        // 
        // picTrainGraph
        // 
        picTrainGraph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        picTrainGraph.BackColor = SystemColors.WindowText;
        picTrainGraph.Location = new Point(204, 898);
        picTrainGraph.Margin = new Padding(5, 3, 5, 3);
        picTrainGraph.Name = "picTrainGraph";
        picTrainGraph.Size = new Size(1465, 294);
        picTrainGraph.TabIndex = 6;
        picTrainGraph.TabStop = false;
        // 
        // btnStopTrain
        // 
        btnStopTrain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnStopTrain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnStopTrain.BackColor = Color.Brown;
        btnStopTrain.FlatStyle = FlatStyle.Flat;
        btnStopTrain.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnStopTrain.ForeColor = SystemColors.ControlLightLight;
        btnStopTrain.Location = new Point(1582, 35);
        btnStopTrain.Margin = new Padding(6, 3, 6, 3);
        btnStopTrain.Name = "btnStopTrain";
        btnStopTrain.Size = new Size(218, 96);
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
        lblStatus.Location = new Point(944, 77);
        lblStatus.Margin = new Padding(6, 0, 6, 0);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(274, 51);
        lblStatus.TabIndex = 4;
        lblStatus.Text = "상태 : 대기 중 ";
        // 
        // lblConda
        // 
        lblConda.AutoSize = true;
        lblConda.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblConda.ForeColor = SystemColors.ActiveCaptionText;
        lblConda.Location = new Point(204, 77);
        lblConda.Margin = new Padding(6, 0, 6, 0);
        lblConda.Name = "lblConda";
        lblConda.Size = new Size(326, 51);
        lblConda.TabIndex = 3;
        lblConda.Text = "Conda 환경 이름:";
        // 
        // txtCondaEnv
        // 
        txtCondaEnv.ForeColor = Color.Silver;
        txtCondaEnv.Location = new Point(546, 77);
        txtCondaEnv.Margin = new Padding(6, 3, 6, 3);
        txtCondaEnv.Multiline = true;
        txtCondaEnv.Name = "txtCondaEnv";
        txtCondaEnv.Size = new Size(362, 49);
        txtCondaEnv.TabIndex = 2;
        txtCondaEnv.Text = "conda 환경 이름 입력";
        txtCondaEnv.Enter += txtCondaEnv_Enter;
        txtCondaEnv.Leave += txtCondaEnv_Leave;
        // 
        // txtLog
        // 
        txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtLog.BackColor = SystemColors.InfoText;
        txtLog.ForeColor = Color.Lime;
        txtLog.Location = new Point(202, 150);
        txtLog.Margin = new Padding(6, 3, 6, 3);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(1896, 705);
        txtLog.TabIndex = 1;
        txtLog.TextChanged += txtLog_TextChanged;
        // 
        // btnTrain
        // 
        btnTrain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTrain.BackColor = Color.DarkGreen;
        btnTrain.FlatStyle = FlatStyle.Flat;
        btnTrain.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnTrain.ForeColor = SystemColors.ControlLightLight;
        btnTrain.Location = new Point(1826, 35);
        btnTrain.Margin = new Padding(6, 3, 6, 3);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(218, 96);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = false;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(14F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2430, 1350);
        Controls.Add(tabcMain);
        Margin = new Padding(6, 3, 6, 3);
        Name = "Form1";
        Text = "DonkeyCarrot 1.0 v";
        tabcMain.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pic_Graph).EndInit();
        ((System.ComponentModel.ISupportInitialize)pic_DkScreen).EndInit();
        tab_Trash.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        tabPage3.ResumeLayout(false);
        tabp_Serve.ResumeLayout(false);
        tabp_Serve.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picTrainGraph).EndInit();
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
    private Label lblThrottle;
    private Label lblAngle;
    private TextBox txtThrottleF2;
    private TextBox txtAngleF2;
    private Button btn_Find;
    private Label lbl_To2;
    private Label lbl_To;
    private PictureBox picTrainGraph;
    private Label label1;
    private Label label2;
    private TextBox txtTrainLoss;
    private TabControl tab_Trash;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private Button btn_Restore;
    private ListBox list_DeletedCheck;
    private Button btnLoadPilot;
    private TextBox txtCondaEnv2;
    private ToolTip toolTip1;
}

