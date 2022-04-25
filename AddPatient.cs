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
    public partial class AddPatient : Form
    {
        Patient patient = new Patient();
        public AddPatient()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.ID = txtID.Text;
            patient.EmailAddress = txtEmailAddress.Text;
            patient.Password = txtPassword.Text;

            patient.MobileNo = txtMobileNo.Text;
            patient.BloodGroup = txtBloodGroup.Text;
            if (rbtnMale.Checked)
                patient.Sex = "Male";
            else
                patient.Sex = "Female";
            patient.DateOfBirth = Convert.ToDateTime(dateTimePickerDateOfBirth.Text);
            patient.Address = txtAddress.Text;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Patients (FirstName, LastName, ID, EmailAddress, Password, MobileNo, BloodGroup, Sex, DateOfBirth, Address) values ('" + patient.FirstName + "','" + patient.LastName + "','" + patient.ID + "','" + patient.EmailAddress + "','" + patient.Password+ "','" + patient.MobileNo + "','" + patient.BloodGroup + "','" + patient.Sex + "','" + patient.DateOfBirth + "','" + patient.Address + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtID.Text = "";
            txtEmailAddress.Text = "";
            txtPassword.Text = "";
            txtMobileNo.Text = "";
            txtBloodGroup.Text = "";
            txtAddress.Text = "";
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
