using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void btnShowUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Show();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string columnName = txtColumnName.Text;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Employees set " + txtColumnName.Text + " ='" + txtColumnValue.Text + "' where ID='" + txtID.Text + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Employees where ID='" + txtID.Text + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Employees", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewDoctorList.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void dataGridViewDoctorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {

        }
    }
}
