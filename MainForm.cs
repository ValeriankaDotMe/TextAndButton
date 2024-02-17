namespace TextAndButton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(messageField.Text);
        }
    }
}