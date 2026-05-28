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
        txtAngleFilter = new TextBox();
        txtThrottleFilter = new TextBox();
        label1 = new Label();
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
        btn_Find = new Button();
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
        textBox1 = new TextBox();
        label3 = new Label();
        label4 = new Label();
        textBox2 = new TextBox();
        label5 = new Label();
        label6 = new Label();
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
        tabcMain.Location = new Point(0, 0);
        tabcMain.Margin = new Padding(5, 5, 5, 5);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(2350, 1094);
        tabcMain.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(label6);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(textBox2);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(textBox1);
        tabPage1.Controls.Add(txtAngleF);
        tabPage1.Controls.Add(txtThrottleF);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(txtAngleFilter);
        tabPage1.Controls.Add(txtThrottleFilter);
        tabPage1.Controls.Add(label1);
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
        tabPage1.Controls.Add(btn_Find);
        tabPage1.Controls.Add(btn_Del);
        tabPage1.Controls.Add(btn_SmallR);
        tabPage1.Controls.Add(btn_Stop);
        tabPage1.Controls.Add(btn_SmallL);
        tabPage1.Controls.Add(btn_BigL);
        tabPage1.Controls.Add(btn_BigR);
        tabPage1.Controls.Add(pic_DkScreen);
        tabPage1.Controls.Add(btnLoadImages);
        tabPage1.Controls.Add(btnLoadCatalog);
        tabPage1.Location = new Point(8, 46);
        tabPage1.Margin = new Padding(5, 5, 5, 5);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(5, 5, 5, 5);
        tabPage1.Size = new Size(2334, 1040);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // txtAngleF
        // 
        txtAngleF.Location = new Point(1085, 750);
        txtAngleF.Margin = new Padding(5, 5, 5, 5);
        txtAngleF.Name = "txtAngleF";
        txtAngleF.Size = new Size(101, 39);
        txtAngleF.TabIndex = 29;
        // 
        // txtThrottleF
        // 
        txtThrottleF.Location = new Point(1085, 680);
        txtThrottleF.Margin = new Padding(5, 5, 5, 5);
        txtThrottleF.Name = "txtThrottleF";
        txtThrottleF.Size = new Size(95, 39);
        txtThrottleF.TabIndex = 28;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(809, 683);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(110, 32);
        label2.TabIndex = 27;
        label2.Text = "조건입력";
        // 
        // txtAngleFilter
        // 
        txtAngleFilter.Location = new Point(1431, 1232);
        txtAngleFilter.Margin = new Padding(5, 5, 5, 5);
        txtAngleFilter.Name = "txtAngleFilter";
        txtAngleFilter.Size = new Size(309, 39);
        txtAngleFilter.TabIndex = 26;
        txtAngleFilter.Text = "angle>0";
        // 
        // txtThrottleFilter
        // 
        txtThrottleFilter.Location = new Point(1431, 1125);
        txtThrottleFilter.Margin = new Padding(5, 5, 5, 5);
        txtThrottleFilter.Name = "txtThrottleFilter";
        txtThrottleFilter.Size = new Size(309, 39);
        txtThrottleFilter.TabIndex = 25;
        txtThrottleFilter.Text = "throttle>0";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("맑은 고딕", 15F);
        label1.Location = new Point(1137, 1125);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(192, 54);
        label1.TabIndex = 24;
        label1.Text = "조건입력:";
        // 
        // cmbSpeed
        // 
        cmbSpeed.FormattingEnabled = true;
        cmbSpeed.Location = new Point(684, 30);
        cmbSpeed.Margin = new Padding(5, 5, 5, 5);
        cmbSpeed.Name = "cmbSpeed";
        cmbSpeed.Size = new Size(228, 40);
        cmbSpeed.TabIndex = 23;
        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;
        // 
        // btnThrottleGraph
        // 
        btnThrottleGraph.Location = new Point(1514, 443);
        btnThrottleGraph.Margin = new Padding(5, 5, 5, 5);
        btnThrottleGraph.Name = "btnThrottleGraph";
        btnThrottleGraph.Size = new Size(216, 43);
        btnThrottleGraph.TabIndex = 22;
        btnThrottleGraph.Text = "throttle 그래프";
        btnThrottleGraph.UseVisualStyleBackColor = true;
        // 
        // btnAngleGraph
        // 
        btnAngleGraph.Location = new Point(1290, 443);
        btnAngleGraph.Margin = new Padding(5, 5, 5, 5);
        btnAngleGraph.Name = "btnAngleGraph";
        btnAngleGraph.Size = new Size(216, 43);
        btnAngleGraph.TabIndex = 21;
        btnAngleGraph.Text = "angle 그래프";
        btnAngleGraph.UseVisualStyleBackColor = true;
        // 
        // pic_Graph
        // 
        pic_Graph.Location = new Point(1290, 187);
        pic_Graph.Margin = new Padding(5, 5, 5, 5);
        pic_Graph.Name = "pic_Graph";
        pic_Graph.Size = new Size(982, 237);
        pic_Graph.TabIndex = 20;
        pic_Graph.TabStop = false;
        // 
        // lbl_ThrottleV
        // 
        lbl_ThrottleV.AutoSize = true;
        lbl_ThrottleV.Font = new Font("맑은 고딕", 15F);
        lbl_ThrottleV.Location = new Point(2000, 115);
        lbl_ThrottleV.Margin = new Padding(5, 0, 5, 0);
        lbl_ThrottleV.Name = "lbl_ThrottleV";
        lbl_ThrottleV.Size = new Size(45, 54);
        lbl_ThrottleV.TabIndex = 19;
        lbl_ThrottleV.Text = "0";
        lbl_ThrottleV.Click += label5_Click;
        // 
        // lbl_Throttle
        // 
        lbl_Throttle.AutoSize = true;
        lbl_Throttle.Font = new Font("맑은 고딕", 15F);
        lbl_Throttle.Location = new Point(1882, 115);
        lbl_Throttle.Margin = new Padding(5, 0, 5, 0);
        lbl_Throttle.Name = "lbl_Throttle";
        lbl_Throttle.Size = new Size(112, 54);
        lbl_Throttle.TabIndex = 18;
        lbl_Throttle.Text = "속도:";
        // 
        // lbl_AngleV
        // 
        lbl_AngleV.AutoSize = true;
        lbl_AngleV.Font = new Font("맑은 고딕", 15F);
        lbl_AngleV.Location = new Point(1758, 115);
        lbl_AngleV.Margin = new Padding(5, 0, 5, 0);
        lbl_AngleV.Name = "lbl_AngleV";
        lbl_AngleV.Size = new Size(45, 54);
        lbl_AngleV.TabIndex = 17;
        lbl_AngleV.Text = "0";
        // 
        // lbl_Angle
        // 
        lbl_Angle.AutoSize = true;
        lbl_Angle.Font = new Font("맑은 고딕", 15F);
        lbl_Angle.Location = new Point(1616, 115);
        lbl_Angle.Margin = new Padding(5, 0, 5, 0);
        lbl_Angle.Name = "lbl_Angle";
        lbl_Angle.Size = new Size(152, 54);
        lbl_Angle.TabIndex = 16;
        lbl_Angle.Text = "조항각:";
        // 
        // lbl_FrameV
        // 
        lbl_FrameV.AutoSize = true;
        lbl_FrameV.Font = new Font("맑은 고딕", 15F);
        lbl_FrameV.Location = new Point(1437, 115);
        lbl_FrameV.Margin = new Padding(5, 0, 5, 0);
        lbl_FrameV.Name = "lbl_FrameV";
        lbl_FrameV.Size = new Size(45, 54);
        lbl_FrameV.TabIndex = 15;
        lbl_FrameV.Text = "0";
        // 
        // lbl_Frame
        // 
        lbl_Frame.AutoSize = true;
        lbl_Frame.Font = new Font("맑은 고딕", 15F);
        lbl_Frame.Location = new Point(1290, 115);
        lbl_Frame.Margin = new Padding(5, 0, 5, 0);
        lbl_Frame.Name = "lbl_Frame";
        lbl_Frame.Size = new Size(152, 54);
        lbl_Frame.TabIndex = 14;
        lbl_Frame.Text = "프레임:";
        // 
        // list_FileCheck
        // 
        list_FileCheck.FormattingEnabled = true;
        list_FileCheck.Location = new Point(62, 656);
        list_FileCheck.Margin = new Padding(5, 5, 5, 5);
        list_FileCheck.Name = "list_FileCheck";
        list_FileCheck.Size = new Size(636, 164);
        list_FileCheck.TabIndex = 13;
        // 
        // tbar_Dk
        // 
        tbar_Dk.Location = new Point(37, 557);
        tbar_Dk.Margin = new Padding(5, 5, 5, 5);
        tbar_Dk.Name = "tbar_Dk";
        tbar_Dk.Size = new Size(996, 90);
        tbar_Dk.TabIndex = 12;
        // 
        // btn_Retry
        // 
        btn_Retry.Location = new Point(849, 864);
        btn_Retry.Margin = new Padding(5, 5, 5, 5);
        btn_Retry.Name = "btn_Retry";
        btn_Retry.Size = new Size(149, 72);
        btn_Retry.TabIndex = 11;
        btn_Retry.Text = "초기화";
        btn_Retry.UseVisualStyleBackColor = true;
        // 
        // btn_Find
        // 
        btn_Find.Location = new Point(649, 859);
        btn_Find.Margin = new Padding(5, 5, 5, 5);
        btn_Find.Name = "btn_Find";
        btn_Find.Size = new Size(149, 78);
        btn_Find.TabIndex = 10;
        btn_Find.Text = "찾기";
        btn_Find.UseVisualStyleBackColor = true;
        // 
        // btn_Del
        // 
        btn_Del.Location = new Point(62, 869);
        btn_Del.Margin = new Padding(5, 5, 5, 5);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(149, 72);
        btn_Del.TabIndex = 9;
        btn_Del.Text = "삭제";
        btn_Del.UseVisualStyleBackColor = true;
        // 
        // btn_SmallR
        // 
        btn_SmallR.Location = new Point(677, 461);
        btn_SmallR.Margin = new Padding(5, 5, 5, 5);
        btn_SmallR.Name = "btn_SmallR";
        btn_SmallR.Size = new Size(238, 72);
        btn_SmallR.TabIndex = 8;
        btn_SmallR.Text = ">>";
        btn_SmallR.UseVisualStyleBackColor = true;
        btn_SmallR.Click += btn_SmallR_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Location = new Point(418, 466);
        btn_Stop.Margin = new Padding(5, 5, 5, 5);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(236, 72);
        btn_Stop.TabIndex = 7;
        btn_Stop.Text = "stop";
        btn_Stop.UseVisualStyleBackColor = true;
        btn_Stop.Click += btn_Stop_Click;
        // 
        // btn_SmallL
        // 
        btn_SmallL.Location = new Point(166, 466);
        btn_SmallL.Margin = new Padding(5, 5, 5, 5);
        btn_SmallL.Name = "btn_SmallL";
        btn_SmallL.Size = new Size(236, 72);
        btn_SmallL.TabIndex = 6;
        btn_SmallL.Text = "<<";
        btn_SmallL.UseVisualStyleBackColor = true;
        btn_SmallL.Click += btn_SmallL_Click;
        // 
        // btn_BigL
        // 
        btn_BigL.Location = new Point(37, 115);
        btn_BigL.Margin = new Padding(5, 5, 5, 5);
        btn_BigL.Name = "btn_BigL";
        btn_BigL.Size = new Size(124, 424);
        btn_BigL.TabIndex = 5;
        btn_BigL.Text = "<";
        btn_BigL.UseVisualStyleBackColor = true;
        // 
        // btn_BigR
        // 
        btn_BigR.Location = new Point(919, 115);
        btn_BigR.Margin = new Padding(5, 5, 5, 5);
        btn_BigR.Name = "btn_BigR";
        btn_BigR.Size = new Size(124, 424);
        btn_BigR.TabIndex = 4;
        btn_BigR.Text = ">";
        btn_BigR.UseVisualStyleBackColor = true;
        // 
        // pic_DkScreen
        // 
        pic_DkScreen.Location = new Point(166, 115);
        pic_DkScreen.Margin = new Padding(5, 5, 5, 5);
        pic_DkScreen.Name = "pic_DkScreen";
        pic_DkScreen.Size = new Size(747, 339);
        pic_DkScreen.TabIndex = 2;
        pic_DkScreen.TabStop = false;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Location = new Point(264, 8);
        btnLoadImages.Margin = new Padding(5, 5, 5, 5);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(246, 83);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = true;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Location = new Point(9, 8);
        btnLoadCatalog.Margin = new Padding(5, 5, 5, 5);
        btnLoadCatalog.Name = "btnLoadCatalog";
        btnLoadCatalog.Size = new Size(246, 83);
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
        tabp_Serve.Location = new Point(8, 46);
        tabp_Serve.Margin = new Padding(5, 5, 5, 5);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(5, 5, 5, 5);
        tabp_Serve.Size = new Size(2334, 1040);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "tabPage2";
        // 
        // btnStopTrain
        // 
        btnStopTrain.Location = new Point(1325, 48);
        btnStopTrain.Margin = new Padding(5, 5, 5, 5);
        btnStopTrain.Name = "btnStopTrain";
        btnStopTrain.Size = new Size(316, 88);
        btnStopTrain.TabIndex = 5;
        btnStopTrain.Text = "학습 멈춤";
        btnStopTrain.UseVisualStyleBackColor = true;
        btnStopTrain.Click += btnStopTrain_Click;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblStatus.ForeColor = Color.White;
        lblStatus.Location = new Point(971, 77);
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
        lblConda.Location = new Point(205, 77);
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
        txtCondaEnv.Margin = new Padding(5, 5, 5, 5);
        txtCondaEnv.Multiline = true;
        txtCondaEnv.Name = "txtCondaEnv";
        txtCondaEnv.Size = new Size(362, 49);
        txtCondaEnv.TabIndex = 2;
        txtCondaEnv.Enter += txtCondaEnv_Enter;
        txtCondaEnv.Leave += txtCondaEnv_Leave;
        // 
        // txtLog
        // 
        txtLog.BackColor = SystemColors.InfoText;
        txtLog.ForeColor = Color.Lime;
        txtLog.Location = new Point(201, 149);
        txtLog.Margin = new Padding(5, 5, 5, 5);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(1896, 823);
        txtLog.TabIndex = 1;
        txtLog.TextChanged += txtLog_TextChanged;
        // 
        // btnTrain
        // 
        btnTrain.BackColor = SystemColors.ButtonFace;
        btnTrain.FlatStyle = FlatStyle.Flat;
        btnTrain.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnTrain.ForeColor = SystemColors.InactiveCaptionText;
        btnTrain.Location = new Point(1650, 40);
        btnTrain.Margin = new Padding(5, 5, 5, 5);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(408, 96);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = false;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(1258, 676);
        textBox1.Margin = new Padding(5);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(95, 39);
        textBox1.TabIndex = 30;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(1198, 683);
        label3.Margin = new Padding(5, 0, 5, 0);
        label3.Name = "label3";
        label3.Size = new Size(31, 32);
        label3.TabIndex = 31;
        label3.Text = "~";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(951, 683);
        label4.Margin = new Padding(5, 0, 5, 0);
        label4.Name = "label4";
        label4.Size = new Size(93, 32);
        label4.TabIndex = 32;
        label4.Text = "throttle";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(1258, 750);
        textBox2.Margin = new Padding(5);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(101, 39);
        textBox2.TabIndex = 33;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(1198, 753);
        label5.Margin = new Padding(5, 0, 5, 0);
        label5.Name = "label5";
        label5.Size = new Size(31, 32);
        label5.TabIndex = 34;
        label5.Text = "~";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(951, 757);
        label6.Margin = new Padding(5, 0, 5, 0);
        label6.Name = "label6";
        label6.Size = new Size(73, 32);
        label6.TabIndex = 35;
        label6.Text = "angle";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(14F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2347, 1054);
        Controls.Add(tabcMain);
        Margin = new Padding(5, 5, 5, 5);
        Name = "Form1";
        Text = ".";
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
    private Button btn_Find;
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
    private Label label1;
    private TextBox txtThrottleFilter;
    private TextBox txtAngleFilter;
    private Label label2;
    private TextBox txtAngleF;
    private TextBox txtThrottleF;
    private Label label3;
    private TextBox textBox1;
    private Label label6;
    private Label label5;
    private TextBox textBox2;
    private Label label4;
}
