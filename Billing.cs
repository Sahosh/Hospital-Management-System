using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Billing
    {
        private string admissionID;
        private string patientID;
        private DateTime billDate;
        private string patientName;
        private DateTime dateOfBirth;
        private string address;
        private string sex;
        private DateTime admissionDate;
        private DateTime dischrageDate;
        private DateTime paymentDate;
        private string cardOrCheckNo;
        private string receiptNo;
        private double total;
        private double discount;
        private double tax;
        private double payAdvance;
        private double payable;
        private string status;

        public string AdmissionID { get => admissionID; set => admissionID = value; }
        public string PatientID { get => patientID; set => patientID = value; }
        public DateTime BillDate { get => billDate; set => billDate = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime AdmissionDate { get => admissionDate; set => admissionDate = value; }
        public DateTime DischrageDate { get => dischrageDate; set => dischrageDate = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        public string CardOrCheckNo { get => cardOrCheckNo; set => cardOrCheckNo = value; }
        public string ReceiptNo { get => receiptNo; set => receiptNo = value; }
        public double Total { get => total; set => total = value; }
        public double Discount { get => discount; set => discount = value; }
        public double Tax { get => tax; set => tax = value; }
        public double PayAdvance { get => payAdvance; set => payAdvance = value; }
        public double Payable { get => payable; set => payable = value; }
        public string Status { get => status; set => status = value; }
    }
}
