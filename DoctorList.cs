using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Hospital_Management_System
{
    public partial class FormDoctorList : Form
    {
        public FormDoctorList()
        {
            InitializeComponent();
            panelUpdate.Hide();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");

        private void btnShow_Click(object sender, System.EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Doctors", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewDoctorList.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Doctors where ID='" + txtID.Text + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnShowUpdate_Click(object sender, System.EventArgs e)
        {
            panelUpdate.Show();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            string columnName = txtColumnName.Text;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Doctors set " + txtColumnName.Text + " ='" + txtColumnValue.Text + "' where ID='" + txtID.Text + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDoctorList_Load(object sender, System.EventArgs e)
        {

        }

        private void lblColumnName_Click(object sender, System.EventArgs e)
        {

        }
    }
}
