namespace appReadTextFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnReadTextFile_Click(object sender, EventArgs e)
        {
            string textFileName = @"C:\Users\RM281learner10\Desktop\example.txt";
            StreamReader sr = new StreamReader(textFileName);
            txtTextBoxDisplay.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void txtTextBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWriteTextFile_Click(object sender, EventArgs e)
        {
            string textFileName = @"C:\Users\RM281learner10\Desktop\WriteExample.txt";

            StreamWriter sw = new StreamWriter(textFileName, true);
            sw.Write(txtTextBoxDisplay.Text);
            sw.Close();
        }
    }
}