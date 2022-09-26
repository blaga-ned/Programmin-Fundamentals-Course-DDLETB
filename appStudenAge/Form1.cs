namespace appStudenAge
{
    public partial class Form1 : Form
    {
        public Form1()
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
            string studentType = "an Adult";
       

            if (studentAge < 18)
            {
                studentType = "a Child";
            }
            
            string output = "This student is " 
                + studentAge 
                +  " years of age and therefore is " 
                + studentType;
            lblStudentType.Text = output;
             
       
        }
    }
}