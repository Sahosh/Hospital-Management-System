using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class FormAddDoctor : Form
    {
        Doctor doctor = new Doctor();
        public FormAddDoctor()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            doctor.FirstName = txtFirstName.Text;
            doctor.LastName = txtLastName.Text;
            doctor.ID = txtID.Text;
            doctor.EmailAddress = txtEmailAddress.Text;
            doctor.Password = txtPassword.Text;
            doctor.Designation = txtDesignation.Text;
            doctor.Department = txtDepartment.Text;
            doctor.Address = txtAddress.Text;
            doctor.MobileNo = txtMobileNo.Text;
            doctor.Specialist = txtSpecialist.Text;
            doctor.DateOfBirth = Convert.ToDateTime(dateTimePickerDateOfBirth.Text);
            if (rbtnMale.Checked)
                doctor.Sex = "Male";
            else
                doctor.Sex = "Female";
            doctor.BloodGroup = txtBloodGroup.Text;
            doctor.Degree = txtDegree.Text;
            if (rbtnActive.Checked)
                doctor.Status = "Active";
            else
                doctor.Status = "Inactive";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Doctors (FirstName, LastName, ID, EmailAddress, Password, Designation, Department, Address, MobileNo, Specialist, DateOfBirth, BloodGroup, Degree, Status) values ('" + doctor.FirstName + "','" + doctor.LastName + "','" + doctor.ID + "','" + doctor.EmailAddress + "','" + doctor.Password + "','" + doctor.Designation + "','" + doctor.Department + "','" + doctor.Address + "','" + doctor.MobileNo + "','" + doctor.Specialist + "','" + doctor.DateOfBirth + "','" + doctor.BloodGroup + "','" + doctor.Degree + "','" + doctor.Status + "')", sqlConnection);
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
            txtDesignation.Text = "";
            txtDepartment.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtSpecialist.Text = "";
            txtBloodGroup.Text = "";
            txtDegree.Text = "";
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormAddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
