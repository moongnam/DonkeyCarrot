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
        list_FileCheck = new ListBox();
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
        tab_Trash = new TabControl();
        tabPage2 = new TabPage();
        tabPage3 = new TabPage();
        list_DeletedCheck = new ListBox();
        btn_Restore = new Button();
        tabcMain.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pic_Graph).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pic_DkScreen).BeginInit();
        tabp_Serve.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picTrainGraph).BeginInit();
        tab_Trash.SuspendLayout();
        tabPage2.SuspendLayout();
        tabPage3.SuspendLayout();
        SuspendLayout();
        // 
        // tabcMain
        // 
        tabcMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabcMain.Controls.Add(tabPage1);
        tabcMain.Controls.Add(tabp_Serve);
        tabcMain.Location = new Point(-6, 0);
        tabcMain.Margin = new Padding(4, 2, 4, 2);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(1737, 1098);
        tabcMain.TabIndex = 0;
        // 
        // tabPage1
        // 
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
        tabPage1.Location = new Point(4, 34);
        tabPage1.Margin = new Padding(4, 2, 4, 2);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(4, 2, 4, 2);
        tabPage1.Size = new Size(1729, 1060);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "메인";
        tabPage1.UseVisualStyleBackColor = true;
        tabPage1.Click += tabPage1_Click;
        // 
        // lbl_To2
        // 
        lbl_To2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lbl_To2.AutoSize = true;
        lbl_To2.Location = new Point(1179, 755);
        lbl_To2.Margin = new Padding(4, 0, 4, 0);
        lbl_To2.Name = "lbl_To2";
        lbl_To2.Size = new Size(25, 25);
        lbl_To2.TabIndex = 45;
        lbl_To2.Text = "~";
        // 
        // lbl_To
        // 
        lbl_To.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lbl_To.AutoSize = true;
        lbl_To.Location = new Point(1179, 721);
        lbl_To.Margin = new Padding(4, 0, 4, 0);
        lbl_To.Name = "lbl_To";
        lbl_To.Size = new Size(25, 25);
        lbl_To.TabIndex = 44;
        lbl_To.Text = "~";
        // 
        // lblThrottle
        // 
        lblThrottle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblThrottle.AutoSize = true;
        lblThrottle.Location = new Point(966, 758);
        lblThrottle.Margin = new Padding(4, 0, 4, 0);
        lblThrottle.Name = "lblThrottle";
        lblThrottle.Size = new Size(48, 25);
        lblThrottle.TabIndex = 43;
        lblThrottle.Text = "속도";
        // 
        // lblAngle
        // 
        lblAngle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblAngle.AutoSize = true;
        lblAngle.Location = new Point(966, 721);
        lblAngle.Margin = new Padding(4, 0, 4, 0);
        lblAngle.Name = "lblAngle";
        lblAngle.Size = new Size(66, 25);
        lblAngle.TabIndex = 42;
        lblAngle.Text = "조항각";
        // 
        // txtThrottleF2
        // 
        txtThrottleF2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtThrottleF2.Location = new Point(1209, 752);
        txtThrottleF2.Margin = new Padding(4, 2, 4, 2);
        txtThrottleF2.Name = "txtThrottleF2";
        txtThrottleF2.Size = new Size(105, 31);
        txtThrottleF2.TabIndex = 41;
        // 
        // txtAngleF2
        // 
        txtAngleF2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtAngleF2.Location = new Point(1209, 715);
        txtAngleF2.Margin = new Padding(4, 2, 4, 2);
        txtAngleF2.Name = "txtAngleF2";
        txtAngleF2.Size = new Size(105, 31);
        txtAngleF2.TabIndex = 39;
        // 
        // btn_Find
        // 
        btn_Find.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Find.Location = new Point(1384, 804);
        btn_Find.Margin = new Padding(4, 2, 4, 2);
        btn_Find.Name = "btn_Find";
        btn_Find.Size = new Size(106, 65);
        btn_Find.TabIndex = 38;
        btn_Find.Text = "찾기";
        btn_Find.UseVisualStyleBackColor = true;
        // 
        // chk_Throttle
        // 
        chk_Throttle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chk_Throttle.AutoSize = true;
        chk_Throttle.Location = new Point(184, 717);
        chk_Throttle.Margin = new Padding(4, 2, 4, 2);
        chk_Throttle.Name = "chk_Throttle";
        chk_Throttle.Size = new Size(74, 29);
        chk_Throttle.TabIndex = 37;
        chk_Throttle.Text = "속도";
        chk_Throttle.UseVisualStyleBackColor = true;
        // 
        // chk_Angle
        // 
        chk_Angle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chk_Angle.AutoSize = true;
        chk_Angle.Location = new Point(54, 717);
        chk_Angle.Margin = new Padding(4, 2, 4, 2);
        chk_Angle.Name = "chk_Angle";
        chk_Angle.Size = new Size(92, 29);
        chk_Angle.TabIndex = 36;
        chk_Angle.Text = "조향각";
        chk_Angle.UseVisualStyleBackColor = true;
        // 
        // pic_Graph
        // 
        pic_Graph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pic_Graph.Location = new Point(54, 752);
        pic_Graph.Margin = new Padding(4, 2, 4, 2);
        pic_Graph.Name = "pic_Graph";
        pic_Graph.Size = new Size(871, 161);
        pic_Graph.TabIndex = 20;
        pic_Graph.TabStop = false;
        // 
        // txtThrottleF
        // 
        txtThrottleF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtThrottleF.Location = new Point(1064, 752);
        txtThrottleF.Margin = new Padding(4, 2, 4, 2);
        txtThrottleF.Name = "txtThrottleF";
        txtThrottleF.Size = new Size(105, 31);
        txtThrottleF.TabIndex = 35;
        // 
        // txtAngleF
        // 
        txtAngleF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtAngleF.Location = new Point(1064, 715);
        txtAngleF.Margin = new Padding(4, 2, 4, 2);
        txtAngleF.Name = "txtAngleF";
        txtAngleF.Size = new Size(105, 31);
        txtAngleF.TabIndex = 34;
        // 
        // myTrackbar1
        // 
        myTrackbar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        myTrackbar1.BackColor = Color.Transparent;
        myTrackbar1.Location = new Point(46, 626);
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
        lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblTitle.Location = new Point(54, 30);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(304, 52);
        lblTitle.TabIndex = 32;
        lblTitle.Text = "DonkeyCarrot";
        lblTitle.Click += label3_Click;
        // 
        // lblFilter
        // 
        lblFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblFilter.AutoSize = true;
        lblFilter.Location = new Point(990, 689);
        lblFilter.Margin = new Padding(4, 0, 4, 0);
        lblFilter.Name = "lblFilter";
        lblFilter.Size = new Size(84, 25);
        lblFilter.TabIndex = 27;
        lblFilter.Text = "조건입력";
        // 
        // cmbSpeed
        // 
        cmbSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbSpeed.FormattingEnabled = true;
        cmbSpeed.Location = new Point(644, 52);
        cmbSpeed.Margin = new Padding(4, 2, 4, 2);
        cmbSpeed.Name = "cmbSpeed";
        cmbSpeed.Size = new Size(164, 33);
        cmbSpeed.TabIndex = 23;
        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;
        // 
        // lbl_ThrottleV
        // 
        lbl_ThrottleV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_ThrottleV.AutoSize = true;
        lbl_ThrottleV.Font = new Font("맑은 고딕", 15F);
        lbl_ThrottleV.Location = new Point(568, 918);
        lbl_ThrottleV.Margin = new Padding(4, 0, 4, 0);
        lbl_ThrottleV.Name = "lbl_ThrottleV";
        lbl_ThrottleV.Size = new Size(35, 41);
        lbl_ThrottleV.TabIndex = 19;
        lbl_ThrottleV.Text = "0";
        lbl_ThrottleV.Click += label5_Click;
        // 
        // lbl_Throttle
        // 
        lbl_Throttle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Throttle.AutoSize = true;
        lbl_Throttle.Font = new Font("맑은 고딕", 15F);
        lbl_Throttle.Location = new Point(484, 918);
        lbl_Throttle.Margin = new Padding(4, 0, 4, 0);
        lbl_Throttle.Name = "lbl_Throttle";
        lbl_Throttle.Size = new Size(85, 41);
        lbl_Throttle.TabIndex = 18;
        lbl_Throttle.Text = "속도:";
        // 
        // lbl_AngleV
        // 
        lbl_AngleV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_AngleV.AutoSize = true;
        lbl_AngleV.Font = new Font("맑은 고딕", 15F);
        lbl_AngleV.Location = new Point(396, 918);
        lbl_AngleV.Margin = new Padding(4, 0, 4, 0);
        lbl_AngleV.Name = "lbl_AngleV";
        lbl_AngleV.Size = new Size(35, 41);
        lbl_AngleV.TabIndex = 17;
        lbl_AngleV.Text = "0";
        // 
        // lbl_Angle
        // 
        lbl_Angle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Angle.AutoSize = true;
        lbl_Angle.Font = new Font("맑은 고딕", 15F);
        lbl_Angle.Location = new Point(294, 918);
        lbl_Angle.Margin = new Padding(4, 0, 4, 0);
        lbl_Angle.Name = "lbl_Angle";
        lbl_Angle.Size = new Size(115, 41);
        lbl_Angle.TabIndex = 16;
        lbl_Angle.Text = "조항각:";
        // 
        // lbl_FrameV
        // 
        lbl_FrameV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_FrameV.AutoSize = true;
        lbl_FrameV.Font = new Font("맑은 고딕", 15F);
        lbl_FrameV.Location = new Point(190, 918);
        lbl_FrameV.Margin = new Padding(4, 0, 4, 0);
        lbl_FrameV.Name = "lbl_FrameV";
        lbl_FrameV.Size = new Size(35, 41);
        lbl_FrameV.TabIndex = 15;
        lbl_FrameV.Text = "0";
        // 
        // lbl_Frame
        // 
        lbl_Frame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbl_Frame.AutoSize = true;
        lbl_Frame.Font = new Font("맑은 고딕", 15F);
        lbl_Frame.Location = new Point(84, 918);
        lbl_Frame.Margin = new Padding(4, 0, 4, 0);
        lbl_Frame.Name = "lbl_Frame";
        lbl_Frame.Size = new Size(115, 41);
        lbl_Frame.TabIndex = 14;
        lbl_Frame.Text = "프레임:";
        // 
        // list_FileCheck
        // 
        list_FileCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        list_FileCheck.FormattingEnabled = true;
        list_FileCheck.Location = new Point(4, 5);
        list_FileCheck.Margin = new Padding(4, 2, 4, 2);
        list_FileCheck.Name = "list_FileCheck";
        list_FileCheck.Size = new Size(630, 529);
        list_FileCheck.TabIndex = 13;
        list_FileCheck.SelectedIndexChanged += list_FileCheck_SelectedIndexChanged;
        // 
        // btn_Retry
        // 
        btn_Retry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Retry.Location = new Point(1514, 710);
        btn_Retry.Margin = new Padding(4, 2, 4, 2);
        btn_Retry.Name = "btn_Retry";
        btn_Retry.Size = new Size(106, 65);
        btn_Retry.TabIndex = 11;
        btn_Retry.Text = "초기화";
        btn_Retry.UseVisualStyleBackColor = true;
        // 
        // btn_Del
        // 
        btn_Del.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_Del.Location = new Point(1384, 710);
        btn_Del.Margin = new Padding(4, 2, 4, 2);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(106, 65);
        btn_Del.TabIndex = 9;
        btn_Del.Text = "삭제";
        btn_Del.UseVisualStyleBackColor = true;
        // 
        // btn_SmallR
        // 
        btn_SmallR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btn_SmallR.Location = new Point(574, 560);
        btn_SmallR.Margin = new Padding(4, 2, 4, 2);
        btn_SmallR.Name = "btn_SmallR";
        btn_SmallR.Size = new Size(234, 58);
        btn_SmallR.TabIndex = 8;
        btn_SmallR.Text = ">>";
        btn_SmallR.UseVisualStyleBackColor = true;
        btn_SmallR.Click += btn_SmallR_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btn_Stop.Location = new Point(369, 560);
        btn_Stop.Margin = new Padding(4, 2, 4, 2);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(200, 58);
        btn_Stop.TabIndex = 7;
        btn_Stop.Text = "stop";
        btn_Stop.UseVisualStyleBackColor = true;
        btn_Stop.Click += btn_Stop_Click;
        // 
        // btn_SmallL
        // 
        btn_SmallL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btn_SmallL.Location = new Point(151, 558);
        btn_SmallL.Margin = new Padding(4, 2, 4, 2);
        btn_SmallL.Name = "btn_SmallL";
        btn_SmallL.Size = new Size(211, 58);
        btn_SmallL.TabIndex = 6;
        btn_SmallL.Text = "<<";
        btn_SmallL.UseVisualStyleBackColor = true;
        btn_SmallL.Click += btn_SmallL_Click;
        // 
        // btn_BigL
        // 
        btn_BigL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        btn_BigL.Location = new Point(46, 120);
        btn_BigL.Margin = new Padding(4, 2, 4, 2);
        btn_BigL.Name = "btn_BigL";
        btn_BigL.Size = new Size(89, 492);
        btn_BigL.TabIndex = 5;
        btn_BigL.Text = "<";
        btn_BigL.UseVisualStyleBackColor = true;
        // 
        // btn_BigR
        // 
        btn_BigR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btn_BigR.Location = new Point(829, 120);
        btn_BigR.Margin = new Padding(4, 2, 4, 2);
        btn_BigR.Name = "btn_BigR";
        btn_BigR.Size = new Size(89, 492);
        btn_BigR.TabIndex = 4;
        btn_BigR.Text = ">";
        btn_BigR.UseVisualStyleBackColor = true;
        // 
        // pic_DkScreen
        // 
        pic_DkScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pic_DkScreen.BackColor = SystemColors.ActiveCaptionText;
        pic_DkScreen.Location = new Point(151, 120);
        pic_DkScreen.Margin = new Padding(4, 2, 4, 2);
        pic_DkScreen.Name = "pic_DkScreen";
        pic_DkScreen.Size = new Size(656, 430);
        pic_DkScreen.TabIndex = 2;
        pic_DkScreen.TabStop = false;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadImages.Location = new Point(1446, 42);
        btnLoadImages.Margin = new Padding(4, 2, 4, 2);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(176, 65);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = true;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoadCatalog.Location = new Point(1236, 42);
        btnLoadCatalog.Margin = new Padding(4, 2, 4, 2);
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
        tabp_Serve.Location = new Point(4, 34);
        tabp_Serve.Margin = new Padding(4, 2, 4, 2);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(4, 2, 4, 2);
        tabp_Serve.Size = new Size(1729, 1060);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "학습";
        tabp_Serve.Click += tabp_Serve_Click;
        // 
        // txtTrainLoss
        // 
        txtTrainLoss.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtTrainLoss.Location = new Point(1363, 701);
        txtTrainLoss.Margin = new Padding(3, 2, 3, 2);
        txtTrainLoss.Multiline = true;
        txtTrainLoss.Name = "txtTrainLoss";
        txtTrainLoss.ScrollBars = ScrollBars.Vertical;
        txtTrainLoss.Size = new Size(301, 186);
        txtTrainLoss.TabIndex = 11;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(1199, 748);
        label2.Name = "label2";
        label2.Size = new Size(172, 25);
        label2.TabIndex = 10;
        label2.Text = "파란선: 검증 오차값";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(1199, 705);
        label1.Name = "label1";
        label1.Size = new Size(172, 25);
        label1.TabIndex = 9;
        label1.Text = "빨간선: 학습 오차값";
        // 
        // picTrainGraph
        // 
        picTrainGraph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        picTrainGraph.BackColor = SystemColors.WindowText;
        picTrainGraph.Location = new Point(146, 701);
        picTrainGraph.Margin = new Padding(3, 2, 3, 2);
        picTrainGraph.Name = "picTrainGraph";
        picTrainGraph.Size = new Size(1047, 230);
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
        btnStopTrain.Location = new Point(1130, 28);
        btnStopTrain.Margin = new Padding(4, 2, 4, 2);
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
        lblConda.Location = new Point(146, 60);
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
        txtCondaEnv.Margin = new Padding(4, 2, 4, 2);
        txtCondaEnv.Multiline = true;
        txtCondaEnv.Name = "txtCondaEnv";
        txtCondaEnv.Size = new Size(260, 39);
        txtCondaEnv.TabIndex = 2;
        txtCondaEnv.Enter += txtCondaEnv_Enter;
        txtCondaEnv.Leave += txtCondaEnv_Leave;
        // 
        // txtLog
        // 
        txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtLog.BackColor = SystemColors.InfoText;
        txtLog.ForeColor = Color.Lime;
        txtLog.Location = new Point(144, 118);
        txtLog.Margin = new Padding(4, 2, 4, 2);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(1355, 552);
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
        btnTrain.Location = new Point(1304, 28);
        btnTrain.Margin = new Padding(4, 2, 4, 2);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(156, 75);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = false;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // tab_Trash
        // 
        tab_Trash.Controls.Add(tabPage2);
        tab_Trash.Controls.Add(tabPage3);
        tab_Trash.Location = new Point(972, 112);
        tab_Trash.Name = "tab_Trash";
        tab_Trash.SelectedIndex = 0;
        tab_Trash.Size = new Size(648, 579);
        tab_Trash.TabIndex = 46;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(list_FileCheck);
        tabPage2.Location = new Point(4, 34);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(640, 541);
        tabPage2.TabIndex = 0;
        tabPage2.Text = "파일 목록";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(list_DeletedCheck);
        tabPage3.Location = new Point(4, 34);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(640, 541);
        tabPage3.TabIndex = 1;
        tabPage3.Text = "복구";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // list_DeletedCheck
        // 
        list_DeletedCheck.FormattingEnabled = true;
        list_DeletedCheck.Location = new Point(0, 6);
        list_DeletedCheck.Name = "list_DeletedCheck";
        list_DeletedCheck.Size = new Size(631, 529);
        list_DeletedCheck.TabIndex = 14;
        // 
        // btn_Restore
        // 
        btn_Restore.Location = new Point(1514, 804);
        btn_Restore.Name = "btn_Restore";
        btn_Restore.Size = new Size(102, 65);
        btn_Restore.TabIndex = 15;
        btn_Restore.Text = "복구";
        btn_Restore.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1736, 1055);
        Controls.Add(tabcMain);
        Margin = new Padding(4, 2, 4, 2);
        Name = "Form1";
        Text = "DonkeyCarrot 1.0 v";
        tabcMain.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pic_Graph).EndInit();
        ((System.ComponentModel.ISupportInitialize)pic_DkScreen).EndInit();
        tabp_Serve.ResumeLayout(false);
        tabp_Serve.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picTrainGraph).EndInit();
        tab_Trash.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        tabPage3.ResumeLayout(false);
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
}

