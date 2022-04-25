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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.Add("Admin");
            cmbUserRole.Items.Add("Doctor");
            cmbUserRole.Items.Add("Accountant");
            cmbUserRole.Items.Add("Nurse");
            cmbUserRole.Items.Add("Receptionist");
            cmbUserRole.Items.Add("Patient");
        }
        Employee employee = new Employee();
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbUserRole.Items.Contains("Admin"))
                employee.UserRole = "Admin";
            else if (cmbUserRole.Items.Contains("Doctor"))
                employee.UserRole = "Doctor";
            else if (cmbUserRole.Items.Contains("Accountant"))
                employee.UserRole = "Accountant";
            else if (cmbUserRole.Items.Contains("Nurse"))
                employee.UserRole = "Nurse";
            else if (cmbUserRole.Items.Contains("Receptionist"))
                employee.UserRole = "Receptionist";
            else if (cmbUserRole.Items.Contains("Patient"))
                employee.UserRole = "Patient";

            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.ID = txtID.Text;
            employee.EmailAddress = txtEmailAddress.Text;
            employee.Password = txtPassword.Text;
            employee.MobileNo = txtMobileNo.Text;
            if (rbtnMale.Checked)
                employee.Sex = "Male";
            else
                employee.Sex = "Female";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Doctors (UserRole, FirstName, LastName, ID, EmailAddress, Password, MobileNo, Sex, Address, Status) values ('" + employee.UserRole + "','" + employee.FirstName + "','" + employee.LastName + "','" + employee.ID + "','" + employee.EmailAddress + "','" + employee.Password + "','" + employee.MobileNo + "','" + employee.Sex + "','" + employee.Address + "','" + employee.Address + "','" + employee.Status + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
