using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.Add("Admin");
            cmbUserRole.Items.Add("Doctor");
            cmbUserRole.Items.Add("Accountant");
            cmbUserRole.Items.Add("Nurse");
            cmbUserRole.Items.Add("Receptionist");
            cmbUserRole.Items.Add("Patient");
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool validEmail = false;
            string emailAddress = txtEmailAddress.Text;
            foreach (var character in emailAddress)
            {
                if (character == '@')
                {
                    validEmail = true;
                    break;
                }
                else
                    validEmail = false;
            }
            if (!validEmail)
                MessageBox.Show("Invalid E-mail Address");
            else
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
