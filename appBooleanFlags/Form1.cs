using System.Windows.Forms.VisualStyles;

namespace appBooleanFlags
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void lblEqualsFlag_Click(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            //Get number1 and number2 from the textBoxes
           
           int numberOne = Convert.ToInt32(txtNumber1.Text);
           int numberTwo = Convert.ToInt32(txtNumber2.Text);

            bool equalsFlag = (numberOne == numberTwo);
            //display the flag value in the lable
            lblEqualsFlag.Text = equalsFlag.ToString();
            
            /*Set Flags for the following comparison:
            greaterThanFlag
            lessThanFlag
            greaterOrEqualsFlag
            lessOrEqualsFlag
            */

            bool greaterThanFlag = (numberOne > numberTwo);
            lblGreaterThanFlag.Text = greaterThanFlag.ToString();

            bool lessThanFlag = (numberOne < numberTwo);
            lblLessThanFlag.Text = lessThanFlag.ToString();

            bool greaterOrEqualsFlag = (numberOne >= numberTwo);
            lblGreaterOrEqualsFlag.Text = greaterOrEqualsFlag.ToString();
            
            bool lessOrEqualsFlag = numberOne <= numberTwo;
            lblLessOrEqualsFlag.Text = lessOrEqualsFlag.ToString();

        }

    }
}