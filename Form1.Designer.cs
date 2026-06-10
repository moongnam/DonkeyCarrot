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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        tabcMain = new TabControl();
        tabPage1 = new TabPage();
        Carrotpic = new PictureBox();
        label4 = new Label();
        label3 = new Label();
        lbl_ImageRoute = new Label();
        lbl_CatalogRoute = new Label();
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
        toolTipPath = new ToolTip(components);
        tabcMain.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)Carrotpic).BeginInit();
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
        tabcMain.Location = new Point(-5, 0);
        tabcMain.Margin = new Padding(4, 3, 4, 3);
        tabcMain.Multiline = true;
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(1563, 877);
        tabcMain.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.BackColor = Color.Orange;
        tabPage1.Controls.Add(Carrotpic);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(lbl_ImageRoute);
        tabPage1.Controls.Add(lbl_CatalogRoute);
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
        tabPage1.Location = new Point(4, 29);
        tabPage1.Margin = new Padding(4, 3, 4, 3);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(4, 3, 4, 3);
        tabPage1.Size = new Size(1555, 844);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "메인";
        tabPage1.Click += tabPage1_Click;
        // 
        // Carrotpic
        // 
        Carrotpic.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        Carrotpic.BackColor = Color.Transparent;
        Carrotpic.Image = (Image)resources.GetObject("Carrotpic.Image");
        Carrotpic.Location = new Point(1038, 463);
        Carrotpic.Name = "Carrotpic";
        Carrotpic.Size = new Size(118, 109);
        Carrotpic.SizeMode = PictureBoxSizeMode.Zoom;
        Carrotpic.TabIndex = 53;
        Carrotpic.TabStop = false;
        Carrotpic.Click += pictureBox1_Click;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(307, 55);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(127, 20);
        label4.TabIndex = 52;
        label4.Text = "빨간선: 학습 모델";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(307, 38);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(142, 20);
        label3.TabIndex = 51;
        label3.Text = "초록선: 실제 운전자";
        // 
        // lbl_ImageRoute
        // 
        lbl_ImageRoute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lbl_ImageRoute.AutoSize = true;
        lbl_ImageRoute.ForeColor = SystemColors.ButtonHighlight;
        lbl_ImageRoute.Location = new Point(1335, 16);
        lbl_ImageRoute.Name = "lbl_ImageRoute";
        lbl_ImageRoute.Size = new Size(89, 20);
        lbl_ImageRoute.TabIndex = 50;
        lbl_ImageRoute.Text = "이미지 경로";
        // 
        // lbl_CatalogRoute
        // 
        lbl_CatalogRoute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lbl_CatalogRoute.AutoSize = true;
        lbl_CatalogRoute.ForeColor = SystemColors.ButtonHighlight;
        lbl_CatalogRoute.Location = new Point(1146, 16);
        lbl_CatalogRoute.Name = "lbl_CatalogRoute";
        lbl_CatalogRoute.Size = new Size(104, 20);
        lbl_CatalogRoute.TabIndex = 49;
        lbl_CatalogRoute.Text = "카탈로그 경로";
        // 
        // txtCondaEnv2
        // 
        txtCondaEnv2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtCondaEnv2.BackColor = Color.White;
        txtCondaEnv2.ForeColor = Color.Silver;
        txtCondaEnv2.Location = new Point(927, 28);
        txtCondaEnv2.Name = "txtCondaEnv2";
        txtCondaEnv2.Size = new Size(184, 27);
        txtCondaEnv2.TabIndex = 48;
        txtCondaEnv2.Text = "conda 환경 이름 입력";
        txtCondaEnv2.Enter += txtCondaEnv2_Enter;
        txtCondaEnv2.Leave += txtCondaEnv2_Leave;
        // 
        // btnLoadPilot
        // 
        btnLoadPilot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadPilot.BackColor = Color.LimeGreen;
        btnLoadPilot.FlatStyle = FlatStyle.Flat;
        btnLoadPilot.Location = new Point(556, 40);
        btnLoadPilot.Margin = new Padding(2);
        btnLoadPilot.Name = "btnLoadPilot";
        btnLoadPilot.Size = new Size(98, 32);
        btnLoadPilot.TabIndex = 47;
        btnLoadPilot.Text = "학습 모델 선택";
        btnLoadPilot.UseVisualStyleBackColor = false;
        // 
        // btn_Restore
        // 
        btn_Restore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Restore.BackColor = Color.LimeGreen;
        btn_Restore.FlatStyle = FlatStyle.Flat;
        btn_Restore.Location = new Point(949, 540);
        btn_Restore.Margin = new Padding(2);
        btn_Restore.Name = "btn_Restore";
        btn_Restore.Size = new Size(93, 43);
        btn_Restore.TabIndex = 15;
        btn_Restore.Text = "복구";
        btn_Restore.UseVisualStyleBackColor = false;
        // 
        // lbl_To2
        // 
        lbl_To2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lbl_To2.AutoSize = true;
        lbl_To2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
        lbl_To2.Location = new Point(885, 500);
        lbl_To2.Name = "lbl_To2";
        lbl_To2.Size = new Size(26, 25);
        lbl_To2.TabIndex = 45;
        lbl_To2.Text = "~";
        lbl_To2.Click += lbl_To2_Click;
        // 
        // lbl_To
        // 
        lbl_To.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lbl_To.AutoSize = true;
        lbl_To.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
        lbl_To.Location = new Point(885, 473);
        lbl_To.Name = "lbl_To";
        lbl_To.Size = new Size(26, 25);
        lbl_To.TabIndex = 44;
        lbl_To.Text = "~";
        // 
        // lblThrottle
        // 
        lblThrottle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblThrottle.AutoSize = true;
        lblThrottle.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblThrottle.Location = new Point(711, 499);
        lblThrottle.Name = "lblThrottle";
        lblThrottle.Size = new Size(78, 28);
        lblThrottle.TabIndex = 43;
        lblThrottle.Text = "속도   :";
        // 
        // lblAngle
        // 
        lblAngle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblAngle.AutoSize = true;
        lblAngle.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblAngle.Location = new Point(707, 475);
        lblAngle.Name = "lblAngle";
        lblAngle.Size = new Size(84, 28);
        lblAngle.TabIndex = 42;
        lblAngle.Text = "조항각 :";
        lblAngle.Click += lblAngle_Click;
        // 
        // txtThrottleF2
        // 
        txtThrottleF2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtThrottleF2.BackColor = Color.White;
        txtThrottleF2.Location = new Point(917, 503);
        txtThrottleF2.Margin = new Padding(3, 2, 3, 2);
        txtThrottleF2.Name = "txtThrottleF2";
        txtThrottleF2.Size = new Size(95, 23);
        txtThrottleF2.TabIndex = 41;
        // 
        // txtAngleF2
        // 
        txtAngleF2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtAngleF2.BackColor = Color.White;
        txtAngleF2.Location = new Point(917, 473);
        txtAngleF2.Margin = new Padding(3, 2, 3, 2);
        txtAngleF2.Name = "txtAngleF2";
        txtAngleF2.Size = new Size(95, 23);
        txtAngleF2.TabIndex = 39;
        // 
        // btn_Find
        // 
        btn_Find.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Find.BackColor = Color.LimeGreen;
        btn_Find.BackgroundImageLayout = ImageLayout.None;
        btn_Find.FlatStyle = FlatStyle.Flat;
        btn_Find.Location = new Point(710, 541);
        btn_Find.Margin = new Padding(3, 2, 3, 2);
        btn_Find.Name = "btn_Find";
        btn_Find.Size = new Size(95, 43);
        btn_Find.TabIndex = 38;
        btn_Find.Text = "찾기";
        btn_Find.UseVisualStyleBackColor = false;
        // 
        // chk_Throttle
        // 
        chk_Throttle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chk_Throttle.AutoSize = true;
        chk_Throttle.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
        chk_Throttle.Location = new Point(147, 432);
        chk_Throttle.Margin = new Padding(3, 2, 3, 2);
        chk_Throttle.Name = "chk_Throttle";
        chk_Throttle.Size = new Size(74, 32);
        chk_Throttle.TabIndex = 37;
        chk_Throttle.Text = "속도";
        chk_Throttle.UseVisualStyleBackColor = true;
        chk_Throttle.CheckedChanged += chk_Throttle_CheckedChanged;
        // 
        // chk_Angle
        // 
        chk_Angle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chk_Angle.AutoSize = true;
        chk_Angle.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
        chk_Angle.ForeColor = SystemColors.ActiveCaptionText;
        chk_Angle.Location = new Point(56, 432);
        chk_Angle.Margin = new Padding(3, 2, 3, 2);
        chk_Angle.Name = "chk_Angle";
        chk_Angle.Size = new Size(94, 32);
        chk_Angle.TabIndex = 36;
        chk_Angle.Text = "조향각";
        chk_Angle.UseVisualStyleBackColor = true;
        // 
        // pic_Graph
        // 
        pic_Graph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pic_Graph.BackColor = Color.White;
        pic_Graph.Location = new Point(50, 461);
        pic_Graph.Margin = new Padding(3, 2, 3, 2);
        pic_Graph.Name = "pic_Graph";
        pic_Graph.Size = new Size(784, 159);
        pic_Graph.TabIndex = 20;
        pic_Graph.TabStop = false;
        // 
        // txtThrottleF
        // 
        txtThrottleF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtThrottleF.BackColor = Color.White;
        txtThrottleF.Location = new Point(781, 503);
        txtThrottleF.Margin = new Padding(3, 2, 3, 2);
        txtThrottleF.Name = "txtThrottleF";
        txtThrottleF.Size = new Size(98, 23);
        txtThrottleF.TabIndex = 35;
        // 
        // txtAngleF
        // 
        txtAngleF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtAngleF.BackColor = Color.White;
        txtAngleF.Location = new Point(781, 473);
        txtAngleF.Margin = new Padding(3, 2, 3, 2);
        txtAngleF.Name = "txtAngleF";
        txtAngleF.Size = new Size(98, 23);
        txtAngleF.TabIndex = 34;
        // 
        // myTrackbar1
        // 
        myTrackbar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        myTrackbar1.BackColor = Color.Transparent;
        myTrackbar1.Location = new Point(50, 395);
        myTrackbar1.Margin = new Padding(4);
        myTrackbar1.Maximum = 100;
        myTrackbar1.Minimum = 0;
        myTrackbar1.Name = "myTrackbar1";
        myTrackbar1.Size = new Size(784, 44);
        myTrackbar1.TabIndex = 33;
        myTrackbar1.Value = 30;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("한컴 말랑말랑 Bold", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(41, 27);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(261, 45);
        lblTitle.TabIndex = 32;
        lblTitle.Text = "DonkeyCarrot";
        lblTitle.Click += label3_Click;
        // 
        // cmbSpeed
        // 
        cmbSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbSpeed.BackColor = Color.White;
        cmbSpeed.FormattingEnabled = true;
        cmbSpeed.Location = new Point(426, 44);
        cmbSpeed.Margin = new Padding(3, 2, 3, 2);
        cmbSpeed.Name = "cmbSpeed";
        cmbSpeed.Size = new Size(148, 28);
        cmbSpeed.TabIndex = 23;
        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;
        // 
        // lbl_ThrottleV
        // 
        lbl_ThrottleV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_ThrottleV.AutoSize = true;
        lbl_ThrottleV.Font = new Font("맑은 고딕", 15F);
        lbl_ThrottleV.Location = new Point(614, 427);
        lbl_ThrottleV.Name = "lbl_ThrottleV";
        lbl_ThrottleV.Size = new Size(29, 35);
        lbl_ThrottleV.TabIndex = 19;
        lbl_ThrottleV.Text = "0";
        lbl_ThrottleV.Click += label5_Click;
        // 
        // lbl_Throttle
        // 
        lbl_Throttle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Throttle.AutoSize = true;
        lbl_Throttle.Font = new Font("맑은 고딕", 15F);
        lbl_Throttle.Location = new Point(556, 427);
        lbl_Throttle.Name = "lbl_Throttle";
        lbl_Throttle.Size = new Size(70, 35);
        lbl_Throttle.TabIndex = 18;
        lbl_Throttle.Text = "속도:";
        // 
        // lbl_AngleV
        // 
        lbl_AngleV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_AngleV.AutoSize = true;
        lbl_AngleV.Font = new Font("맑은 고딕", 15F);
        lbl_AngleV.Location = new Point(493, 427);
        lbl_AngleV.Name = "lbl_AngleV";
        lbl_AngleV.Size = new Size(29, 35);
        lbl_AngleV.TabIndex = 17;
        lbl_AngleV.Text = "0";
        // 
        // lbl_Angle
        // 
        lbl_Angle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Angle.AutoSize = true;
        lbl_Angle.Font = new Font("맑은 고딕", 15F);
        lbl_Angle.Location = new Point(422, 427);
        lbl_Angle.Name = "lbl_Angle";
        lbl_Angle.Size = new Size(95, 35);
        lbl_Angle.TabIndex = 16;
        lbl_Angle.Text = "조항각:";
        // 
        // lbl_FrameV
        // 
        lbl_FrameV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_FrameV.AutoSize = true;
        lbl_FrameV.Font = new Font("맑은 고딕", 15F);
        lbl_FrameV.Location = new Point(350, 427);
        lbl_FrameV.Name = "lbl_FrameV";
        lbl_FrameV.Size = new Size(29, 35);
        lbl_FrameV.TabIndex = 15;
        lbl_FrameV.Text = "0";
        // 
        // lbl_Frame
        // 
        lbl_Frame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Frame.AutoSize = true;
        lbl_Frame.Font = new Font("맑은 고딕", 15F);
        lbl_Frame.Location = new Point(276, 427);
        lbl_Frame.Name = "lbl_Frame";
        lbl_Frame.Size = new Size(95, 35);
        lbl_Frame.TabIndex = 14;
        lbl_Frame.Text = "프레임:";
        // 
        // btn_Retry
        // 
        btn_Retry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Retry.BackColor = Color.LimeGreen;
        btn_Retry.FlatStyle = FlatStyle.Flat;
        btn_Retry.Location = new Point(790, 541);
        btn_Retry.Margin = new Padding(3, 2, 3, 2);
        btn_Retry.Name = "btn_Retry";
        btn_Retry.Size = new Size(95, 43);
        btn_Retry.TabIndex = 11;
        btn_Retry.Text = "초기화";
        btn_Retry.UseVisualStyleBackColor = false;
        // 
        // btn_Del
        // 
        btn_Del.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Del.BackColor = Color.LimeGreen;
        btn_Del.FlatStyle = FlatStyle.Flat;
        btn_Del.Location = new Point(870, 541);
        btn_Del.Margin = new Padding(3, 2, 3, 2);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(95, 41);
        btn_Del.TabIndex = 9;
        btn_Del.Text = "삭제";
        btn_Del.UseVisualStyleBackColor = false;
        // 
        // btn_SmallR
        // 
        btn_SmallR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_SmallR.BackColor = Color.LimeGreen;
        btn_SmallR.FlatStyle = FlatStyle.Flat;
        btn_SmallR.Location = new Point(422, 355);
        btn_SmallR.Margin = new Padding(3, 2, 3, 2);
        btn_SmallR.Name = "btn_SmallR";
        btn_SmallR.Size = new Size(211, 45);
        btn_SmallR.TabIndex = 8;
        btn_SmallR.Text = ">>";
        btn_SmallR.UseVisualStyleBackColor = false;
        btn_SmallR.Click += btn_SmallR_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btn_Stop.BackColor = Color.LimeGreen;
        btn_Stop.FlatStyle = FlatStyle.Flat;
        btn_Stop.Location = new Point(276, 355);
        btn_Stop.Margin = new Padding(3, 2, 3, 2);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(180, 45);
        btn_Stop.TabIndex = 7;
        btn_Stop.Text = "stop";
        btn_Stop.UseVisualStyleBackColor = false;
        btn_Stop.Click += btn_Stop_Click;
        // 
        // btn_SmallL
        // 
        btn_SmallL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btn_SmallL.BackColor = Color.LimeGreen;
        btn_SmallL.FlatStyle = FlatStyle.Flat;
        btn_SmallL.Location = new Point(122, 355);
        btn_SmallL.Margin = new Padding(3, 2, 3, 2);
        btn_SmallL.Name = "btn_SmallL";
        btn_SmallL.Size = new Size(190, 45);
        btn_SmallL.TabIndex = 6;
        btn_SmallL.Text = "<<";
        btn_SmallL.UseVisualStyleBackColor = false;
        btn_SmallL.Click += btn_SmallL_Click;
        // 
        // btn_BigL
        // 
        btn_BigL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        btn_BigL.BackColor = Color.LimeGreen;
        btn_BigL.FlatStyle = FlatStyle.Flat;
        btn_BigL.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
        btn_BigL.Location = new Point(50, 81);
        btn_BigL.Margin = new Padding(3, 2, 3, 2);
        btn_BigL.Name = "btn_BigL";
        btn_BigL.Size = new Size(80, 411);
        btn_BigL.TabIndex = 5;
        btn_BigL.Text = "<";
        btn_BigL.UseVisualStyleBackColor = false;
        btn_BigL.Click += btn_BigL_Click_1;
        // 
        // btn_BigR
        // 
        btn_BigR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btn_BigR.BackColor = Color.LimeGreen;
        btn_BigR.FlatStyle = FlatStyle.Flat;
        btn_BigR.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
        btn_BigR.Location = new Point(592, 81);
        btn_BigR.Margin = new Padding(3, 2, 3, 2);
        btn_BigR.Name = "btn_BigR";
        btn_BigR.Size = new Size(80, 411);
        btn_BigR.TabIndex = 4;
        btn_BigR.Text = ">";
        btn_BigR.UseVisualStyleBackColor = false;
        // 
        // pic_DkScreen
        // 
        pic_DkScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pic_DkScreen.BackColor = SystemColors.InfoText;
        pic_DkScreen.Location = new Point(124, 81);
        pic_DkScreen.Margin = new Padding(3, 2, 3, 2);
        pic_DkScreen.Name = "pic_DkScreen";
        pic_DkScreen.Size = new Size(590, 360);
        pic_DkScreen.TabIndex = 2;
        pic_DkScreen.TabStop = false;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadImages.BackColor = Color.LimeGreen;
        btnLoadImages.FlatStyle = FlatStyle.Flat;
        btnLoadImages.Location = new Point(1323, 39);
        btnLoadImages.Margin = new Padding(4, 3, 4, 3);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(163, 64);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = false;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadCatalog.BackColor = Color.LimeGreen;
        btnLoadCatalog.FlatStyle = FlatStyle.Flat;
        btnLoadCatalog.Location = new Point(1146, 39);
        btnLoadCatalog.Margin = new Padding(4, 3, 4, 3);
        btnLoadCatalog.Name = "btnLoadCatalog";
        btnLoadCatalog.Size = new Size(156, 64);
        btnLoadCatalog.TabIndex = 0;
        btnLoadCatalog.Text = "카탈로그 파일 \r\n불러오기\r\n";
        btnLoadCatalog.UseVisualStyleBackColor = false;
        btnLoadCatalog.Click += btnLoadCatalog_Click_1;
        // 
        // tab_Trash
        // 
        tab_Trash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        tab_Trash.Controls.Add(tabPage2);
        tab_Trash.Controls.Add(tabPage3);
        tab_Trash.Location = new Point(909, 76);
        tab_Trash.Name = "tab_Trash";
        tab_Trash.SelectedIndex = 0;
        tab_Trash.Size = new Size(453, 396);
        tab_Trash.TabIndex = 46;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(list_FileCheck);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(2);
        tabPage2.Size = new Size(445, 368);
        tabPage2.TabIndex = 0;
        tabPage2.Text = "파일 목록";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // list_FileCheck
        // 
        list_FileCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        list_FileCheck.BackColor = Color.White;
        list_FileCheck.FormattingEnabled = true;
        list_FileCheck.Location = new Point(4, 4);
        list_FileCheck.Margin = new Padding(4, 3, 4, 3);
        list_FileCheck.Name = "list_FileCheck";
        list_FileCheck.Size = new Size(442, 364);
        list_FileCheck.TabIndex = 13;
        list_FileCheck.SelectedIndexChanged += list_FileCheck_SelectedIndexChanged;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(list_DeletedCheck);
        tabPage3.Location = new Point(4, 29);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(2);
        tabPage3.Size = new Size(445, 368);
        tabPage3.TabIndex = 1;
        tabPage3.Text = "복구";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // list_DeletedCheck
        // 
        list_DeletedCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        list_DeletedCheck.FormattingEnabled = true;
        list_DeletedCheck.Location = new Point(3, 5);
        list_DeletedCheck.Name = "list_DeletedCheck";
        list_DeletedCheck.Size = new Size(567, 444);
        list_DeletedCheck.TabIndex = 14;
        // 
        // tabp_Serve
        // 
        tabp_Serve.BackColor = Color.Orange;
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
        tabp_Serve.Location = new Point(4, 29);
        tabp_Serve.Margin = new Padding(4, 3, 4, 3);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(4, 3, 4, 3);
        tabp_Serve.Size = new Size(1555, 844);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "학습";
        tabp_Serve.Click += tabp_Serve_Click;
        // 
        // txtTrainLoss
        // 
        txtTrainLoss.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtTrainLoss.Location = new Point(1071, 580);
        txtTrainLoss.Multiline = true;
        txtTrainLoss.Name = "txtTrainLoss";
        txtTrainLoss.ScrollBars = ScrollBars.Vertical;
        txtTrainLoss.Size = new Size(295, 164);
        txtTrainLoss.TabIndex = 11;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label2.AutoSize = true;
        label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold);
        label2.Location = new Point(297, 761);
        label2.Name = "label2";
        label2.Size = new Size(162, 23);
        label2.TabIndex = 10;
        label2.Text = "파란선: 검증 오차값";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label1.AutoSize = true;
        label1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold);
        label1.Location = new Point(131, 761);
        label1.Name = "label1";
        label1.Size = new Size(162, 23);
        label1.TabIndex = 9;
        label1.Text = "빨간선: 학습 오차값";
        // 
        // picTrainGraph
        // 
        picTrainGraph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        picTrainGraph.BackColor = SystemColors.Window;
        picTrainGraph.Location = new Point(131, 580);
        picTrainGraph.Name = "picTrainGraph";
        picTrainGraph.Size = new Size(915, 165);
        picTrainGraph.TabIndex = 6;
        picTrainGraph.TabStop = false;
        // 
        // btnStopTrain
        // 
        btnStopTrain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnStopTrain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnStopTrain.BackColor = Color.OrangeRed;
        btnStopTrain.FlatStyle = FlatStyle.Flat;
        btnStopTrain.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnStopTrain.ForeColor = SystemColors.ControlLightLight;
        btnStopTrain.Location = new Point(815, 46);
        btnStopTrain.Margin = new Padding(3, 2, 3, 2);
        btnStopTrain.Name = "btnStopTrain";
        btnStopTrain.Size = new Size(140, 60);
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
        lblStatus.Location = new Point(508, 61);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(172, 32);
        lblStatus.TabIndex = 4;
        lblStatus.Text = "상태 : 대기 중 ";
        // 
        // lblConda
        // 
        lblConda.AutoSize = true;
        lblConda.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblConda.ForeColor = SystemColors.ActiveCaptionText;
        lblConda.Location = new Point(101, 54);
        lblConda.Name = "lblConda";
        lblConda.Size = new Size(205, 32);
        lblConda.TabIndex = 3;
        lblConda.Text = "Conda 환경 이름:";
        // 
        // txtCondaEnv
        // 
        txtCondaEnv.ForeColor = Color.Silver;
        txtCondaEnv.Location = new Point(309, 61);
        txtCondaEnv.Margin = new Padding(3, 2, 3, 2);
        txtCondaEnv.Multiline = true;
        txtCondaEnv.Name = "txtCondaEnv";
        txtCondaEnv.Size = new Size(234, 32);
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
        txtLog.Location = new Point(130, 132);
        txtLog.Margin = new Padding(4, 3, 4, 3);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(1236, 441);
        txtLog.TabIndex = 1;
        txtLog.TextChanged += txtLog_TextChanged;
        // 
        // btnTrain
        // 
        btnTrain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTrain.BackColor = Color.LimeGreen;
        btnTrain.FlatStyle = FlatStyle.Flat;
        btnTrain.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnTrain.ForeColor = SystemColors.ControlLightLight;
        btnTrain.Location = new Point(937, 46);
        btnTrain.Margin = new Padding(3, 2, 3, 2);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(140, 60);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = false;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1562, 844);
        Controls.Add(tabcMain);
        Margin = new Padding(5, 3, 5, 3);
        Name = "Form1";
        Text = "DonkeyCarrot 1.0 v";
        tabcMain.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)Carrotpic).EndInit();
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
    private TabPage tabPage2;
    private TabPage tabPage3;
    private Button btn_Restore;
    private Button btnLoadPilot;
    private TextBox txtCondaEnv2;
    private ToolTip toolTip1;
    private Label lbl_CatalogRoute;
    private Label lbl_ImageRoute;
    private ToolTip toolTipPath;
    private Label label4;
    private Label label3;
    private PictureBox Carrotpic;
    private ListBox list_DeletedCheck;
    public TabControl tab_Trash;
}

