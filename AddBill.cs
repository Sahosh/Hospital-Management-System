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
    public partial class FormAddBill : Form
    {
        public FormAddBill()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Billing billing = new Billing();
        private void btnSave_Click(object sender, EventArgs e)
        {
            billing.AdmissionID = txtAID.Text;
            billing.PatientID = txtAID.Text;
            billing.BillDate = Convert.ToDateTime(txtAID.Text);
            billing.PatientName = txtAID.Text;
            billing.DateOfBirth = Convert.ToDateTime(txtAID.Text);
            billing.Address = txtAID.Text;
            billing.Sex = txtAID.Text;
            billing.AdmissionDate = Convert.ToDateTime(txtAID.Text);
            billing.DischrageDate = Convert.ToDateTime(txtAID.Text);
            billing.PaymentDate = Convert.ToDateTime(txtAID.Text);
            billing.CardOrCheckNo = txtAID.Text;
            billing.ReceiptNo = txtAID.Text;
            billing.Total = Convert.ToDouble(txtAID.Text);
            billing.Discount = Convert.ToDouble(txtAID.Text);
            billing.Tax = Convert.ToDouble(txtAID.Text);
            billing.PayAdvance = Convert.ToDouble(txtAID.Text);
            billing.Payable = Convert.ToDouble(txtAID.Text);
            billing.Status = txtAID.Text;

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FVT9HSQ;Initial Catalog=Hospital Management System;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Doctors (AdmissionID, PatientID, BillDate, PatientName, DateOfBirth, Address, Sex, AdmissionDate, DischrageDate, PaymentDate, CardOrCheckNo, ReceiptNo, Total, Discount, Tax, PayAdvance, Payable, Status) values ('" + billing.AdmissionID + "','" + billing.PatientID + "','" + billing.BillDate + "','" + billing.PatientName + "','" + billing.DateOfBirth + "','" + billing.Address + "','" + billing.Sex + "','" + billing.AdmissionDate + "','" + billing.DischrageDate + "','" + billing.DischrageDate + "','" + billing.PaymentDate + "','" + billing.CardOrCheckNo + "','" + billing.ReceiptNo + "','" + billing.Total + "','" + billing.Discount + "','" + billing.Tax + "','" + billing.PayAdvance + "','" + billing.Payable + "','" + billing.Status + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormAddBill_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
