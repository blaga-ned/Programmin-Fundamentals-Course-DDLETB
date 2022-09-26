namespace appStudenAge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtStudentAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentType_Click(object sender, EventArgs e)
        {

        }

        private void btnIsChild_Click(object sender, EventArgs e)
        {
            //string studentAgeText = txtStudentAge.Text;
            int studentAge = Convert.ToInt32(txtStudentAge.Text);
            
            string studentType = getStudentType(studentAge);
            
             lblStudentType.Text = $"This student is " + studentType;        
                        
       
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private string getStudentType(int age)
        {
            string studentType = "";
            string singularFormat = "";
            

            if (age >= 65)
            {
                studentType = "Senior Student";
                singularFormat = "a";
            }
            else if (age >= 23)
            {
                studentType = "Mature Student";
                singularFormat = "a";
            }
            else if (age >= 18)
            {
                studentType = "Adult";
                singularFormat = "an";
            }
            else
            {
                studentType = "Child";
                singularFormat = "a";
            }
            return studentType;

        }
    }
}