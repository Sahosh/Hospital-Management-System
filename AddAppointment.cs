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
    public partial class FormAddAppointment : Form
    {
        public FormAddAppointment()
        {
            InitializeComponent();
        }
        Appointment appointment = new Appointment();
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            appointment.PatientID = txtPatientID.Text;
            appointment.DepartmentName = txtDepartmentName.Text;
            appointment.DoctorName = txtDoctorName.Text;
            appointment.AppointmentDate = Convert.ToDateTime(dateTimePickerAppointmrntDate.Text);
            appointment.SerialNo = Convert.ToInt32(txtSerialNo.Text);
            appointment.Problem = txtProblem.Text;
            if (rbtnActive.Checked)
                appointment.Status = "Active";
            else
                appointment.Status = "Inactive";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Appointments (PatientID, DepartmentName, DoctorName, AppointmentDate, SerialNo, Problem, Status) values ('" + appointment.PatientID + "','" + appointment.DepartmentName + "','" + appointment.DoctorName + "','" + appointment.AppointmentDate + "','" + appointment.SerialNo + "','" + appointment.Problem + "','" + appointment.Status + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void FormAddAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
