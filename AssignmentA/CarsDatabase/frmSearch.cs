using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        OleDbConnection connectionToDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\RM281learner10\source\repos\AssignmentA\Hire.accdb'");
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            if (IsFilledIn())
            {
                string sqlQuery = CreateSQLSearchQuery();
                SelectAndDisplayRecords(sqlQuery);

            }

        }
        void SelectAndDisplayRecords(string searchSQLText)
        {
            try
            {
                connectionToDB.Open();
                OleDbCommand selectCmd = connectionToDB.CreateCommand();
                selectCmd.CommandText = searchSQLText;

                OleDbDataAdapter carsDataAdaptor = new OleDbDataAdapter(selectCmd);

                DataTable carsDetailsDataTable = new DataTable();
                carsDataAdaptor.Fill(carsDetailsDataTable);
                dgvCarsDataView.DataSource = carsDetailsDataTable;
                dgvCarsDataView.Columns[4].DefaultCellStyle.Format = "€#.00";

                connectionToDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        string CreateSQLSearchQuery()
        {
            //build the SQL query based on the cboBoxes and the text boxs;
            string textSQL = "SELECT * FROM tblCar WHERE ";
            textSQL += cboField.Text + " ";
            textSQL += cboOperator.Text + " ";


            if (cboField.Text == "RentalPerDay" || cboField.Text == "Available")
            {

                textSQL += txtValue.Text;
            }
            else
            {

                textSQL += "'" + txtValue.Text + "'";
            }

            return textSQL;
        }
        bool IsFilledIn()
        {
            //has the user entered all parts
            if (cboField.Text != "" && cboOperator.Text != "" && txtValue.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to Exit form Search of the program?",
              "Confirmation Required",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Hand) == DialogResult.Yes)
            {

                this.Hide();
            }
            
            
        }
    }
}
