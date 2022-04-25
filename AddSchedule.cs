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
    public partial class FormAddSchedule : Form
    {
        public FormAddSchedule()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
        Schedule schedule = new Schedule();
        private void btnSave_Click(object sender, EventArgs e)
        {
            schedule.SerialNo = Convert.ToInt32(txtSerialNo.Text);
            schedule.DoctorName = txtDoctorName.Text;
            schedule.AvailableDays = txtAvailableDays.Text;
            schedule.AvaibleStartTime = txtAvailableStartTime.Text;
            schedule.AvaiableEndTime = txtAvailableEndTime.Text;
            schedule.PerPatientTime = txtPerPatientTIme.Text;
            if (rbtnActive.Checked)
                schedule.Status = "Active";
            else
                schedule.Status = "Inactive";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Schedules (SerialNo, DoctorName, AvailableDays, AvailableStartTime, AvailableEndTime, PerPatientTime, Status) values ('" + schedule.SerialNo + "','" + schedule.DoctorName + "','" + schedule.AvailableDays + "','" + schedule.AvaibleStartTime + "','" + schedule.AvaiableEndTime + "','" + schedule.PerPatientTime + "','" + schedule.Status + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void FormAddSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
