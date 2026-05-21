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
        tabcMain.SuspendLayout();
        SuspendLayout();
        // 
        // tabcMain
        // 
        tabcMain.Controls.Add(tabp_Main);
        tabcMain.Controls.Add(tabp_Serve);
        tabcMain.Location = new Point(0, 0);
        tabcMain.Name = "tabcMain";
        tabcMain.SelectedIndex = 0;
        tabcMain.Size = new Size(1679, 855);
        tabcMain.TabIndex = 0;
        // 
        // tabp_Main
        // 
        tabp_Main.Location = new Point(4, 34);
        tabp_Main.Name = "tabp_Main";
        tabp_Main.Padding = new Padding(3);
        tabp_Main.Size = new Size(1671, 817);
        tabp_Main.TabIndex = 0;
        tabp_Main.Text = "tabPage1";
        tabp_Main.UseVisualStyleBackColor = true;
        // 
        // tabp_Serve
        // 
        tabp_Serve.Location = new Point(4, 34);
        tabp_Serve.Name = "tabp_Serve";
        tabp_Serve.Padding = new Padding(3);
        tabp_Serve.Size = new Size(1671, 817);
        tabp_Serve.TabIndex = 1;
        tabp_Serve.Text = "tabPage2";
        tabp_Serve.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1678, 844);
        Controls.Add(tabcMain);
        Name = "Form1";
        Text = ".";
        tabcMain.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabcMain;
    private TabPage tabp_Main;
    private TabPage tabp_Serve;
}
