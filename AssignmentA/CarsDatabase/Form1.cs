using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.tblCarBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hireDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            ShowRecords();
        }


        private void rentalPerDayLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tblCarBindingNavigatorSaveItem.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {           
            this.tblCarBindingSource.CancelEdit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to Exit the program?",
               "Confirmation Required",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Deleting not completed", "Not deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to Delete this record?",
               "Confirmation Required",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                bindingNavigatorDeleteItem.PerformClick();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Deleting not completed", "Not deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ShowRecords()
        {
            lblCurrentRecord.Text = bindingNavigatorPositionItem + " " + bindingNavigatorCountItem;
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.PerformClick();
            ShowRecords();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
            ShowRecords();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
            ShowRecords();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveLastItem.PerformClick();
            ShowRecords();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch formSearch = new frmSearch();
            formSearch.Show();
        }
    }
    }

