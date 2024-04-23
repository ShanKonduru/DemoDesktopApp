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
        AddControls();
    }

    private void AddControls()
        {
            // Add a TextBox
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(20, 20);
            textBox.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(textBox);

            // Add a RadioButton
            RadioButton radioButton = new RadioButton();
            radioButton.Text = "RadioButton";
            radioButton.Location = new System.Drawing.Point(20, 50);
            this.Controls.Add(radioButton);

            // Add a CheckBox
            CheckBox checkBox = new CheckBox();
            checkBox.Text = "CheckBox";
            checkBox.Location = new System.Drawing.Point(20, 80);
            this.Controls.Add(checkBox);

            // Add a ListBox
            ListBox listBox = new ListBox();
            listBox.Items.Add("Item 1");
            listBox.Items.Add("Item 2");
            listBox.Location = new System.Drawing.Point(20, 110);
            listBox.Size = new System.Drawing.Size(120, 80);
            this.Controls.Add(listBox);

            // Add a ComboBox
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Item 1");
            comboBox.Items.Add("Item 2");
            comboBox.Location = new System.Drawing.Point(150, 110);
            comboBox.Size = new System.Drawing.Size(120, 20);
            this.Controls.Add(comboBox);

            // Add a DateTimePicker
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Location = new System.Drawing.Point(20, 200);
            this.Controls.Add(dateTimePicker);

            // Add a FolderBrowserDialog button
            Button folderButton = new Button();
            folderButton.Text = "Select Folder";
            folderButton.Location = new System.Drawing.Point(20, 230);
            folderButton.Click += (sender, e) =>
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                folderDialog.ShowDialog();
            };
            this.Controls.Add(folderButton);

            // Add a FileDialog button
            Button fileButton = new Button();
            fileButton.Text = "Select File";
            fileButton.Location = new System.Drawing.Point(150, 230);
            fileButton.Click += (sender, e) =>
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.ShowDialog();
            };

            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();

            // Configure Button
            this.button1.Location = new System.Drawing.Point(30, 300);
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.Text = "Click Me";
            this.button1.Name = "btnClickMe"; // Set button name
            this.button1.Click += new System.EventHandler(this.button1_Click); // Add click event handler

            // Configure Label
            this.label1.Location = new System.Drawing.Point(30, 350);
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.Text = "";
            this.label1.Name = "lblGreeting"; // Set label name

            // Add controls to the form
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);



            this.Controls.Add(fileButton);
        }

    #endregion
}
