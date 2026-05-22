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
        tabp_Main = new TabPage();
        tabp_Serve = new TabPage();
        txtLog = new TextBox();
        btnTrain = new Button();
        btnLoadCatalog = new Button();
        btnLoadImages = new Button();
        tabcMain.SuspendLayout();
        tabp_Main.SuspendLayout();
        tabp_Serve.SuspendLayout();
        SuspendLayout();
        // 
        // tabcMain
        // 
        tabcMain.Controls.Add(tabp_Main);
        tabcMain.Controls.Add(tabp_Serve);
        tabcMain.Location = new Point(0, 0);
        tabcMain.Margin = new Padding(3, 2, 3, 2);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(1679, 855);
        tabcMain.TabIndex = 0;
        // 
        // tabp_Main
        // 
        tabp_Main.Controls.Add(btnLoadImages);
        tabp_Main.Controls.Add(btnLoadCatalog);
        tabp_Main.Location = new Point(4, 34);
        tabp_Main.Margin = new Padding(3, 2, 3, 2);
        tabp_Main.Name = "tabp_Main";
        tabp_Main.Padding = new Padding(3, 2, 3, 2);
        tabp_Main.Size = new Size(1671, 817);
        tabp_Main.TabIndex = 0;
        tabp_Main.Text = "tabPage1";
        tabp_Main.UseVisualStyleBackColor = true;
        // 
        // tabp_Serve
        // 
        tabp_Serve.Controls.Add(txtLog);
        tabp_Serve.Controls.Add(btnTrain);
        tabp_Serve.Location = new Point(4, 34);
        tabp_Serve.Margin = new Padding(3, 2, 3, 2);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(3, 2, 3, 2);
        tabp_Serve.Size = new Size(1671, 817);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "tabPage2";
        tabp_Serve.UseVisualStyleBackColor = true;
        // 
        // txtLog
        // 
        txtLog.Location = new Point(9, 126);
        txtLog.Margin = new Padding(3, 4, 3, 4);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(1321, 645);
        txtLog.TabIndex = 1;
        // 
        // btnTrain
        // 
        btnTrain.Location = new Point(9, 6);
        btnTrain.Margin = new Padding(3, 4, 3, 4);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(409, 112);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = true;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // btnLoadCatalog
        // 
        btnLoadCatalog.Location = new Point(8, 8);
        btnLoadCatalog.Name = "btnLoadCatalog";
        btnLoadCatalog.Size = new Size(175, 65);
        btnLoadCatalog.TabIndex = 0;
        btnLoadCatalog.Text = "카탈로그 파일 \r\n불러오기\r\n";
        btnLoadCatalog.UseVisualStyleBackColor = true;
        // 
        // btnLoadImages
        // 
        btnLoadImages.Location = new Point(189, 8);
        btnLoadImages.Name = "btnLoadImages";
        btnLoadImages.Size = new Size(175, 65);
        btnLoadImages.TabIndex = 1;
        btnLoadImages.Text = "이미지 파일 \r\n불러오기\r\n";
        btnLoadImages.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1678, 844);
        Controls.Add(tabcMain);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Form1";
        Text = ".";
        tabcMain.ResumeLayout(false);
        tabp_Main.ResumeLayout(false);
        tabp_Serve.ResumeLayout(false);
        tabp_Serve.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabcMain;
    private TabPage tabp_Main;
    private TabPage tabp_Serve;
    private TextBox txtLog;
    private Button btnTrain;
    private Button btnLoadCatalog;
    private Button btnLoadImages;
}
