using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Schedule
    {
        private int serialNo;
        private string doctorName;
        private string availableDays;
        private string avaibleStartTime;
        private string avaiableEndTime;
        private string perPatientTime;
        private string status;

        public int SerialNo { get => serialNo; set => serialNo = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string AvailableDays { get => availableDays; set => availableDays = value; }
        public string AvaibleStartTime { get => avaibleStartTime; set => avaibleStartTime = value; }
        public string AvaiableEndTime { get => avaiableEndTime; set => avaiableEndTime = value; }
        public string PerPatientTime { get => perPatientTime; set => perPatientTime = value; }
        public string Status { get => status; set => status = value; }
    }
}
