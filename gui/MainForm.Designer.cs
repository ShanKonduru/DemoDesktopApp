namespace gui;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;

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
        this.button1 = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();

        // Configure Button
        this.button1.Location = new System.Drawing.Point(100, 100);
        this.button1.Size = new System.Drawing.Size(100, 30);
        this.button1.Text = "Click Me";
        this.button1.Name = "btnClickMe"; // Set button name
        this.button1.Click += new System.EventHandler(this.button1_Click); // Add click event handler

        // Configure Label
        this.label1.Location = new System.Drawing.Point(100, 150);
        this.label1.Size = new System.Drawing.Size(200, 30);
        this.label1.Text = "";
        this.label1.Name = "lblGreeting"; // Set label name

        // Add controls to the form
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label1);
    }

    #endregion
}
