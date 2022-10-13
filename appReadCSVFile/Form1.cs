namespace appReadCSVFile
{
    public partial class frmMain : Form
    {
                
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Read the Student Data
            //and
            //Display it in text box
            
            ReadAndDisplayStudentData();
            
        }

        void ReadAndDisplayStudentData()
        {
           
            //Specify the file that has the student Data
            string studentDataFile = @"C:\Users\RM281learner10\Desktop\SDStudents.csv";
            //Read this File and get the Student Data
            string studentCSVData = readCSVFile(studentDataFile);
            
            if(studentCSVData != null)
            {
                //txtStudentData.Text = studentCSVData;
                ExtractStudentRecords(studentCSVData);

            }
            else
            {
                //txtStudentData.Text = "The file read was unsuccessfully";
                Microsoft.VisualBasic.Interaction.MsgBox("The file read was unsuccessfully");
            }

        }
        string readCSVFile(string csvFileName)
        {
            try
            {
                StreamReader sr = new StreamReader(csvFileName);
                string csvData = sr.ReadToEnd();

                sr.Close();
                return csvData;
            }
            catch
            {
                return null;
            }
            
        }

            void ExtractStudentRecords(string csvStudentData)
        {
            //string csvStudentData = txtStudentData.Text;
            lstStudents.Items.Clear();
            bool skipHeaders = true;
            foreach(string studentRecord in csvStudentData.Split("\r\n"))
            {

                //we can do it with ternary operator instead with boolean and if - else;
                if (!skipHeaders)
                {
                    lstStudents.Items.Add(studentRecord);                    
                }
                else
                {
                    skipHeaders = false;
                }
                lblNumberOfStudentsDisplay.Text = $"There are {lstStudents.Items.Count} students";             
                
            }
            
        }
        private void lblStudentFullDetailsDisplayed_Click(object sender, EventArgs e)
        {           
            

        }
        
        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            int studentIndex = Convert.ToInt32(txtStudentPosition.Text);
            displayStudent(studentIndex);
        }

        void displayStudent(int studentIndex)
        {
            string studentRecord = lstStudents.Items[studentIndex].ToString();
            lblStudentFullDetailsDisplayed.Text = studentRecord;
            string[] studentFields = studentRecord.Split(",");

            if(studentFields.Length == 3)
            {
                lblFirstNameDisplay.Text = studentFields[0];
                lblLastNameDisplay.Text = studentFields[1];
                lblAgeDisplay.Text = studentFields[2];
            }
        }

        private void txtStudentPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstNameDisplay_Click(object sender, EventArgs e)
        {

        }

        private void lblLastNameDisplay_Click(object sender, EventArgs e)
        {

        }

        private void lblAgeDisplay_Click(object sender, EventArgs e)
        {

        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstStudents.SelectedIndex >= 0)
            {
                displayStudent(lstStudents.SelectedIndex);
            }

        }

        private void lblNumberOfStudentsDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstStudents.Sorted = !lstStudents.Sorted;
        }
    }
    }
