namespace appReadCSVFile
{
    public partial class frmMain : Form
    {
        const int NUMBEROFSTUDENTS = 12;
        Student[] arrStudents = new Student[NUMBEROFSTUDENTS];
                
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
            //int studentIndex = Convert.ToInt32(txtStudentPosition.Text);
           //displayStudent(studentIndex);

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
            bool skipHeader = true;
            int recordIndex = 0;
            foreach(string studentRecord in csvStudentData.Split("\r\n"))
            {

                //we can do it with ternary operator instead with boolean and if - else;
                if (!skipHeader)
                {
                    //lstStudents.Items.Add(studentRecord); 
                    AddNewStudent(studentRecord, recordIndex);
                    lstStudents.Items.Add(arrStudents[recordIndex].FirstName);                
                               
                   
                    recordIndex++;
                }
                else
                {
                    skipHeader = false;
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
           
        }

        void displayStudent(int studentIndex)
        {
            //string studentRecord = lstStudents.Items[studentIndex].ToString();
           // lblStudentFullDetailsDisplayed.Text = studentRecord;
            //string[] studentFields = studentRecord.Split(",");

            //if(studentFields.Length == 3)
            //{
           
            //1-st way
                /*lblFirstNameDisplay.Text = arrStudents[studentIndex].FirstName;
                lblLastNameDisplay.Text = arrStudents[studentIndex].LastName;
                lblAgeDisplay.Text = arrStudents[studentIndex].Age.ToString();
            lblStudentFullDetailsDisplayed.Text = lblFirstNameDisplay.Text +" "+ lblLastNameDisplay.Text + " "+ lblAgeDisplay.Text;*/

            //2nd way
            Student student = new Student();
            student = arrStudents[studentIndex];

            lblFirstNameDisplay.Text = student.FirstName;
            lblLastNameDisplay.Text = student.LastName;
            lblAgeDisplay.Text = student.Age.ToString();          
            
            
            //}
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

       void AddNewStudent(string studentRecord, int savePostion)
        {
            //Get the Student details from the CSV line
            string[] studentData = studentRecord.Split(",");
            arrStudents[savePostion] = new Student();
            arrStudents[savePostion].FirstName = studentData[0];
            arrStudents[savePostion].LastName = studentData[1];
            arrStudents[savePostion].Age = Convert.ToInt32(studentData[2]);

        }

        private void txtIntroduction_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplayIntroduction_Click(object sender, EventArgs e)
        {
            //Get introduction from each student              
            
           for(int i = 0; i < arrStudents.Length; i++)
            {

                txtIntroduction.Text += i+1 +". " + arrStudents[i].MakeIntroduction() + "\r\n";
            }
           /*foreach(Student student in arrStudents)
            {
                txtIntroduction.Text +=  student.MakeIntroduction() + "\r\n";
            }*/
            
        }

        private void lblIntroduction_Click(object sender, EventArgs e)
        {

        }
    }

    }
