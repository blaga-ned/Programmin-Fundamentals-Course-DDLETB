using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        OleDbConnection connectionToDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Admin\source\repos\preparationExam\Hire.accdb'");
        public frmSearch()
        {
            InitializeComponent();
        }

        private void lblField_Click(object sender, EventArgs e)
        {

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            DisplayAllRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void DisplayAllRecords()
        {
            try
            {
                connectionToDB.Open();
                OleDbCommand selectCmd = connectionToDB.CreateCommand();
                //selectCmd.CommandType = CommandType.Text;
                string selectCmdText = "SELECT * FROM tblCar";
                selectCmd.CommandText = selectCmdText;

                OleDbDataAdapter carsDataAdaptor = new OleDbDataAdapter(selectCmd);

                DataTable carsDetailsDataTable = new DataTable();
                carsDataAdaptor.Fill(carsDetailsDataTable);
                dgvCarsDataView.DataSource = carsDetailsDataTable;

                connectionToDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            string sqlSearch = "";


            if (cboField.Text == "Age" || cboField.Text == "Capacity" || cboField.Text == "Enrolled")
            {
                sqlSearch += cboField.Text + " ";
                sqlSearch += cboOperator.Text + " ";
                sqlSearch += txtValue.Text;
            }
            else if (cboField.Text == "StartDate")
            {
                sqlSearch += "#" + txtValue.Text + "#";
            }
            else
            {
                sqlSearch += cboField.Text + " ";
                sqlSearch += cboOperator.Text + " ";
                sqlSearch += "'" + txtValue.Text + "'";
            }
            string textSQL = "SELECT * FROM tblCar WHERE " + sqlSearch;


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

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (IsFilledIn())
            {
                string sqlQuery = CreateSQLSearchQuery();
                SelectAndDisplayRecords(sqlQuery);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            TestConnection();
        }
        bool TestConnection()
        {

            try
            {
                connectionToDB.Open();
                MessageBox.Show("Connected successufully");

                connectionToDB.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
