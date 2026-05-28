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
        tabcMain.Margin = new Padding(2);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(1175, 513);
        tabcMain.TabIndex = 0;
        // 
        // tabPage1
        // 
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
        tabPage1.Location = new Point(4, 24);
        tabPage1.Margin = new Padding(2);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(2);
        tabPage1.Size = new Size(1167, 485);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // txtAngleF
        // 
        txtAngleF.Location = new Point(481, 350);
        txtAngleF.Margin = new Padding(2);
        txtAngleF.Name = "txtAngleF";
        txtAngleF.Size = new Size(111, 23);
        txtAngleF.TabIndex = 29;
        // 
        // txtThrottleF
        // 
        txtThrottleF.Location = new Point(481, 318);
        txtThrottleF.Margin = new Padding(2);
        txtThrottleF.Name = "txtThrottleF";
        txtThrottleF.Size = new Size(107, 23);
        txtThrottleF.TabIndex = 28;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(404, 320);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(55, 15);
        label2.TabIndex = 27;
        label2.Text = "조건입력";
        // 
        // txtAngleFilter
        // 
        txtAngleFilter.Location = new Point(716, 578);
        txtAngleFilter.Margin = new Padding(2);
        txtAngleFilter.Name = "txtAngleFilter";
        txtAngleFilter.Size = new Size(156, 23);
        txtAngleFilter.TabIndex = 26;
        txtAngleFilter.Text = "angle>0";
        // 
        // txtThrottleFilter
        // 
        txtThrottleFilter.Location = new Point(716, 527);
        txtThrottleFilter.Margin = new Padding(2);
        txtThrottleFilter.Name = "txtThrottleFilter";
        txtThrottleFilter.Size = new Size(156, 23);
        txtThrottleFilter.TabIndex = 25;
        txtThrottleFilter.Text = "throttle>0";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("맑은 고딕", 15F);
        label1.Location = new Point(569, 527);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(96, 28);
        label1.TabIndex = 24;
        label1.Text = "조건입력:";
        // 
        // cmbSpeed
        // 
        cmbSpeed.FormattingEnabled = true;
        cmbSpeed.Location = new Point(342, 14);
        cmbSpeed.Margin = new Padding(2);
        cmbSpeed.Name = "cmbSpeed";
        cmbSpeed.Size = new Size(116, 23);
        cmbSpeed.TabIndex = 23;
        cmbSpeed.SelectedIndexChanged += cmbSpeed_SelectedIndexChanged;
        // 
        // btnThrottleGraph
        // 
        btnThrottleGraph.Location = new Point(757, 208);
        btnThrottleGraph.Margin = new Padding(2);
        btnThrottleGraph.Name = "btnThrottleGraph";
        btnThrottleGraph.Size = new Size(108, 20);
        btnThrottleGraph.TabIndex = 22;
        btnThrottleGraph.Text = "throttle 그래프";
        btnThrottleGraph.UseVisualStyleBackColor = true;
        // 
        // btnAngleGraph
        // 
        btnAngleGraph.Location = new Point(645, 208);
        btnAngleGraph.Margin = new Padding(2);
        btnAngleGraph.Name = "btnAngleGraph";
        btnAngleGraph.Size = new Size(108, 20);
        btnAngleGraph.TabIndex = 21;
        btnAngleGraph.Text = "angle 그래프";
        btnAngleGraph.UseVisualStyleBackColor = true;
        // 
        // pic_Graph
        // 
        pic_Graph.Location = new Point(645, 88);
        pic_Graph.Margin = new Padding(2);
        pic_Graph.Name = "pic_Graph";
        pic_Graph.Size = new Size(491, 111);
        pic_Graph.TabIndex = 20;
        pic_Graph.TabStop = false;
        // 
        // lbl_ThrottleV
        // 
        lbl_ThrottleV.AutoSize = true;
        lbl_ThrottleV.Font = new Font("맑은 고딕", 15F);
        lbl_ThrottleV.Location = new Point(1000, 54);
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
        lbl_Throttle.Location = new Point(941, 54);
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
        lbl_AngleV.Location = new Point(879, 54);
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
        lbl_Angle.Location = new Point(808, 54);
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
        lbl_FrameV.Location = new Point(719, 54);
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
        lbl_Frame.Location = new Point(645, 54);
        lbl_Frame.Margin = new Padding(2, 0, 2, 0);
        lbl_Frame.Name = "lbl_Frame";
        lbl_Frame.Size = new Size(76, 28);
        lbl_Frame.TabIndex = 14;
        lbl_Frame.Text = "프레임:";
        // 
        // list_FileCheck
        // 
        list_FileCheck.FormattingEnabled = true;
        list_FileCheck.Location = new Point(31, 308);
        list_FileCheck.Margin = new Padding(2);
        list_FileCheck.Name = "list_FileCheck";
        list_FileCheck.Size = new Size(320, 79);
        list_FileCheck.TabIndex = 13;
        // 
        // tbar_Dk
        // 
        tbar_Dk.Location = new Point(19, 261);
        tbar_Dk.Margin = new Padding(2);
        tbar_Dk.Name = "tbar_Dk";
        tbar_Dk.Size = new Size(498, 45);
        tbar_Dk.TabIndex = 12;
        // 
        // btn_Retry
        // 
        btn_Retry.Location = new Point(425, 405);
        btn_Retry.Margin = new Padding(2);
        btn_Retry.Name = "btn_Retry";
        btn_Retry.Size = new Size(75, 34);
        btn_Retry.TabIndex = 11;
        btn_Retry.Text = "초기화";
        btn_Retry.UseVisualStyleBackColor = true;
        // 
        // btn_Find
        // 
        btn_Find.Location = new Point(324, 403);
        btn_Find.Margin = new Padding(2);
        btn_Find.Name = "btn_Find";
        btn_Find.Size = new Size(75, 37);
        btn_Find.TabIndex = 10;
        btn_Find.Text = "찾기";
        btn_Find.UseVisualStyleBackColor = true;
        // 
        // btn_Del
        // 
        btn_Del.Location = new Point(31, 407);
        btn_Del.Margin = new Padding(2);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(75, 34);
        btn_Del.TabIndex = 9;
        btn_Del.Text = "삭제";
        btn_Del.UseVisualStyleBackColor = true;
        // 
        // btn_SmallR
        // 
        btn_SmallR.Location = new Point(338, 216);
        btn_SmallR.Margin = new Padding(2);
        btn_SmallR.Name = "btn_SmallR";
        btn_SmallR.Size = new Size(119, 34);
        btn_SmallR.TabIndex = 8;
        btn_SmallR.Text = ">>";
        btn_SmallR.UseVisualStyleBackColor = true;
        btn_SmallR.Click += btn_SmallR_Click;
        // 
        // btn_Stop
        // 
        btn_Stop.Location = new Point(209, 218);
        btn_Stop.Margin = new Padding(2);
        btn_Stop.Name = "btn_Stop";
        btn_Stop.Size = new Size(118, 34);
        btn_Stop.TabIndex = 7;
        btn_Stop.Text = "stop";
        btn_Stop.UseVisualStyleBackColor = true;
        btn_Stop.Click += btn_Stop_Click;
        // 
        // btn_SmallL
        // 
        btn_SmallL.Location = new Point(83, 218);
        btn_SmallL.Margin = new Padding(2);
        btn_SmallL.Name = "btn_SmallL";
        btn_SmallL.Size = new Size(118, 34);
        btn_SmallL.TabIndex = 6;
        btn_SmallL.Text = "<<";
        btn_SmallL.UseVisualStyleBackColor = true;
        btn_SmallL.Click += btn_SmallL_Click;
        // 
        // btn_BigL
        // 
        btn_BigL.Location = new Point(19, 54);
        btn_BigL.Margin = new Padding(2);
        btn_BigL.Name = "btn_BigL";
        btn_BigL.Size = new Size(62, 199);
        btn_BigL.TabIndex = 5;
        btn_BigL.Text = "<";
        btn_BigL.UseVisualStyleBackColor = true;
        // 
        // btn_BigR
        // 
        btn_BigR.Location = new Point(460, 54);
        btn_BigR.Margin = new Padding(2);
        btn_BigR.Name = "btn_BigR";
        btn_BigR.Size = new Size(62, 199);
        btn_BigR.TabIndex = 4;
        btn_BigR.Text = ">";
        btn_BigR.UseVisualStyleBackColor = true;
        // 
        // pic_DkScreen
        // 
        pic_DkScreen.Location = new Point(83, 54);
        pic_DkScreen.Margin = new Padding(2);
        pic_DkScreen.Name = "pic_DkScreen";
        pic_DkScreen.Size = new Size(373, 159);
        pic_DkScreen.TabIndex = 2;
        pic_DkScreen.TabStop = false;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Location = new Point(132, 4);
        btnLoadImages.Margin = new Padding(2);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(123, 39);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = true;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Location = new Point(5, 4);
        btnLoadCatalog.Margin = new Padding(2);
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
        tabp_Serve.Margin = new Padding(2);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(2);
        tabp_Serve.Size = new Size(1167, 485);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "tabPage2";
        // 
        // btnStopTrain
        // 
        btnStopTrain.Location = new Point(663, 22);
        btnStopTrain.Margin = new Padding(2);
        btnStopTrain.Name = "btnStopTrain";
        btnStopTrain.Size = new Size(158, 41);
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
        lblStatus.Location = new Point(485, 36);
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
        txtCondaEnv.Margin = new Padding(2);
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
        txtLog.Margin = new Padding(2);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(950, 388);
        txtLog.TabIndex = 1;
        txtLog.TextChanged += txtLog_TextChanged;
        // 
        // btnTrain
        // 
        btnTrain.BackColor = SystemColors.ButtonFace;
        btnTrain.FlatStyle = FlatStyle.Flat;
        btnTrain.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnTrain.ForeColor = SystemColors.InactiveCaptionText;
        btnTrain.Location = new Point(825, 19);
        btnTrain.Margin = new Padding(2);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(204, 45);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = false;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1174, 494);
        Controls.Add(tabcMain);
        Margin = new Padding(2);
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
}
