namespace appArrayStudent
{
    public partial class frmMain : Form
    {
        string[] arrayStudents = new string[20];
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string index = txtStudentIndex.Text;
            int studentIndex = Convert.ToInt32(index);

            arrayStudents[studentIndex] = studentName;

            //Clear the text Box
            txtStudentName.Text = "";
            txtStudentIndex.Text = "";

          

        }         



        private void btnShow_Click(object sender, EventArgs e)
        {
            string index = txtStudentIndex.Text;
            int studentIndex = Convert.ToInt32(index);

            string studentName = arrayStudents[studentIndex];
            lblStudentName.Text = studentName;

        }

      
        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }
    }
}