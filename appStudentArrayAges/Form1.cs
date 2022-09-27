using Microsoft.VisualBasic;

namespace appStudentArrayAges
{
    public partial class frmMain : Form
    {
        //Set the number of students as a CONSTvalue
        const int NUMBERSTUDENTS = 2;
        //Size an array 
        string[] arrayStudents = new string[NUMBERSTUDENTS];
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGetStudentAge_Click(object sender, EventArgs e)
        {
            string studentDetails = "";
            
            for (int i = 0; i < NUMBERSTUDENTS; i++)
            {

                //using the VB InputBox to enter a string value
                string ageEntered = Interaction.InputBox("Enter the age for student:" + (i + 1), "Input");
                int studentAge = Convert.ToInt32(ageEntered);
                string studentType = getStudentType(studentAge);

                studentDetails = $"Student # {i + 1} is aged {studentAge} and therefore is a {studentType}";
                arrayStudents[i] = studentDetails;

                //arrayStudents = "Student #" + (i + 1).ToString() + " type = " + studentType;   
                
            }  
            
            

        }

        private void btnShowStudentAge_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NUMBERSTUDENTS; i++)
            {
                MessageBox.Show(arrayStudents[i]);
            }
            
           /*
            2). Second Way
            foreach(string ageEntered in arrayStudents)
            {
                MessageBox.Show(ageEntered);
            }

            3). Third Way
           MessageBox.Show(String.Join("\n\r", arrayStudents)); 
           */



        }
        private string getStudentType(int studentAge)
        {
            // Returns a student type based on the age of the student
            
            if (studentAge >= 65)
            {
                return "Senior Student";
               
            }
            else if (studentAge >= 23)
            {
                return "Mature Student";
                
            }
            else if (studentAge >= 18)
            {
                return "Adult";
                
            }
            else
            {
                return "Child";
                
            }
            

        }

        private void txtStudentDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach(string student in arrayStudents)
            {
                txtStudentDetails.Text += student + "\r\n";


            }
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentDetailsFile = @"C:\Users\RM281learner10\Desktop\StudentDetails.txt";
            StreamWriter sw = new StreamWriter(studentDetailsFile);

            foreach(string studentDetails in arrayStudents)
            {
                sw.WriteLine(studentDetails);
            }
            sw.Close();
        }
    }
    
}