namespace gui;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        
        // Set the title of the form
        this.Text = "My Demo App";

        // Set the fixed size for the form
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;

        // Set the size of the form (optional)
        this.Size = new System.Drawing.Size(1200, 800);
    }
    private void button1_Click(object sender, EventArgs e)
    {
        label1.Text = "Hello, World!";
    }
}
