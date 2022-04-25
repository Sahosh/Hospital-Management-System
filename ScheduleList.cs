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
    public partial class FormScheduleList : Form
    {
        public FormScheduleList()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
        private void btnShowUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string columnName = txtColumnName.Text;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Schedules set " + txtColumnName.Text + " ='" + txtColumnValue.Text + "' where SerialNo='" + txtSerialNo.Text + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Schedules where SerialNo='" + txtSerialNo.Text + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Schedules", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewDoctorList.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void FormScheduleList_Load(object sender, EventArgs e)
        {

        }
    }
}
