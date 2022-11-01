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
        string result = "";
        public frmCars()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);

        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
           
                this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            result = "$" + this.hireDataSet.tblCar.Columns[3].ColumnName;
            
                    DisplayRecordPosition();            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tblCarBindingNavigatorSaveItem.PerformClick();            
            ClearRecordDisplay();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.CancelEdit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {         
          
            
        }        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.PerformClick();
            DisplayRecordPosition();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
            DisplayRecordPosition();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
            DisplayRecordPosition();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveLastItem.PerformClick();  
            DisplayRecordPosition();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
          
        }
        private void lblCurrentRecord_Click(object sender, EventArgs e)
        {
            
        }
        void DisplayRecordPosition()
        {
            lblCurrentRecord.Text = bindingNavigatorPositionItem + " " + bindingNavigatorCountItem;            
        }       

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
        void ClearRecordDisplay()
        {
            vehicleRegNoTextBox.Text = "";
            makeTextBox.Text = "";
            engineSizeTextBox.Text = "";
            dateRegisteredDateTimePicker.Text = "";
            rentalPerDayTextBox.Text = "";
            availableCheckBox.Checked = false;
        }
    }
}
