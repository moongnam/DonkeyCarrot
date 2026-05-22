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
        tabcMain.SuspendLayout();
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
        tabcMain.Size = new Size(1511, 684);
        tabcMain.TabIndex = 0;
        // 
        // tabp_Main
        // 
        tabp_Main.Location = new Point(4, 29);
        tabp_Main.Margin = new Padding(3, 2, 3, 2);
        tabp_Main.Name = "tabp_Main";
        tabp_Main.Padding = new Padding(3, 2, 3, 2);
        tabp_Main.Size = new Size(1503, 651);
        tabp_Main.TabIndex = 0;
        tabp_Main.Text = "tabPage1";
        tabp_Main.UseVisualStyleBackColor = true;
        // 
        // tabp_Serve
        // 
        tabp_Serve.Controls.Add(txtLog);
        tabp_Serve.Controls.Add(btnTrain);
        tabp_Serve.Location = new Point(4, 29);
        tabp_Serve.Margin = new Padding(3, 2, 3, 2);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(3, 2, 3, 2);
        tabp_Serve.Size = new Size(1503, 651);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "tabPage2";
        tabp_Serve.UseVisualStyleBackColor = true;
        // 
        // txtLog
        // 
        txtLog.Location = new Point(8, 101);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(1189, 517);
        txtLog.TabIndex = 1;
        // 
        // btnTrain
        // 
        btnTrain.Location = new Point(8, 5);
        btnTrain.Name = "btnTrain";
        btnTrain.Size = new Size(368, 90);
        btnTrain.TabIndex = 0;
        btnTrain.Text = "학습 시작";
        btnTrain.UseVisualStyleBackColor = true;
        btnTrain.Click += btnTrain_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1510, 675);
        Controls.Add(tabcMain);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Form1";
        Text = ".";
        tabcMain.ResumeLayout(false);
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
}
