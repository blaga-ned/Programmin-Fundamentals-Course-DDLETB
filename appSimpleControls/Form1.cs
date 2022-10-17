namespace appSimpleControls
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void chkExample_CheckedChanged(object sender, EventArgs e)
        {
            //display the new value of the check box
            DisplayCheckBoxValue();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            //1ST. WAY
            /*if (chkExample.Checked)
            {
                chkExample.Checked = false;
               
            }
            else
            {
                chkExample.Checked = true;
            }*/

            //2ND WAY

         chkExample.Checked = !chkExample.Checked;
            
        }

        public void DisplayCheckBoxValue()
        {
            if (chkExample.Checked)
            {
                lblResult.Text = "Example is checked";
                lblResult.BackColor = Color.Green;
                lblResult.ForeColor = Color.Yellow;
            }
            else
            {
                lblResult.Text = "Example is not checked";
                lblResult.BackColor = Color.Red;
                lblResult.ForeColor = Color.White;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DisplayCheckBoxValue();
        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            
            DisplayShoppingList();
            
            
        }
        public void DisplayShoppingList()
        {
            txtShoppingList.Clear();

            if (chkBread.Checked)
            {
                txtShoppingList.Text += "Bread" + "\r\n";

            }
            if (chkFruits.Checked)
            {
                txtShoppingList.Text += "Fruits" + "\r\n";
            }
            if (chkSalad.Checked)
            {
                txtShoppingList.Text += "Salad" + "\r\n";
            }
            if (chkVeg.Checked)
            {
                txtShoppingList.Text += "Veg" + "\r\n";
            }
        }

        private void chkBread_CheckedChanged(object sender, EventArgs e)
        {
            DisplayShoppingList();
        }

        private void chkFruits_CheckedChanged(object sender, EventArgs e)
        {
            DisplayShoppingList();
        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            DisplayShoppingList();
        }

        private void chkVeg_CheckedChanged(object sender, EventArgs e)
        {
            DisplayShoppingList();
        }

        private void txtShoppingList_TextChanged(object sender, EventArgs e)
        {

        }

        private void card_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySelectedPayment();
        }

        private void lblPaymentType_Click(object sender, EventArgs e)
        {
            
        }

        private void grbPayment_Enter(object sender, EventArgs e)
        {
            
            
        }
        void DisplaySelectedPayment()
        {
            string display = " ";
            if (radCard.Checked)
            {
                display = "You have selected Card";
            }else if (radCash.Checked)
            {
                display = "You have selected Cash";
            }else if (radVoucher.Checked)
            {
                display = "You have selected Voucher";
            }
            else
            {
                display = "Invalid or not Selected";
            }
            lblPaymentType.Text = display;
            DisplayPicturePayment();
        }

        private void radCash_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySelectedPayment();
        }

        private void radVoucher_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySelectedPayment();
        }

        private void lblShoppingMethods_Click(object sender, EventArgs e)
        {

        }

        private void grbShoppingMethods_Enter(object sender, EventArgs e)
        {

        }

        private void radHomeDelivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShowPic_Click(object sender, EventArgs e)
        {
            //Old method
            //Bitmap image = new Bitmap(@"C:\Users\Admin\Desktop\Visa.jpg");
            //picPaymentType.Image = (Image)image;
            DisplayPicturePayment();
            
            
            
        }
        void DisplayPicturePayment()
        {
            if (radCard.Checked)
            {
                picPaymentType.ImageLocation = @"C:\Users\Admin\Desktop\masterCard.png";

            }else if (radCash.Checked)
            {
                picPaymentType.ImageLocation = @"C:\Users\Admin\Desktop\cash.png";
            }else if (radVoucher.Checked)
            {
                picPaymentType.ImageLocation = @"C:\Users\Admin\Desktop\vouchers.png";
            }
            else
            {
                picPaymentType.ImageLocation = " ";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}