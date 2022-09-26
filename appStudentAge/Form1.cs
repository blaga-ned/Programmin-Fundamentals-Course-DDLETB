using Microsoft.VisualBasic;

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
        private string getStudentType(int studentAge)
        {
            string studentType = "";
            string singularFormat = "";
            

            if (studentAge >= 65)
            {
                studentType = "Senior Student";
                singularFormat = "a";
                //or we can do it shorter way without declaring the virables studentText and singularFormat just to write:
                //return ("a Senior Student");
            }
            else if (studentAge >= 23)
            {
                studentType = "Mature Student";
                singularFormat = "a";
            }
            else if (studentAge >= 18)
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

        private void btnInputAge_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < 3; i++)
            {
                string ageEntered = Interaction.InputBox("Enter the student`s age", "Input Age Box");
                int studentAge = Convert.ToInt32(ageEntered);
                string studentType = getStudentType(studentAge);


                // MessageBox.Show("This student is of type: " + studentType,
                //     "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResults.Text = txtResults.Text + "Student type = " + studentType + "\r\n";
            }
            
            
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }
    }
}