using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Home : Form
    {
        //Fields
        private int borderSize = 2;

        //Constructor
        public Home()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //Border size
            this.BackColor = Color.FromArgb(71, 0, 216); //Border color
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelDoctor.Visible = false;
            panelPatient.Visible = false;
            panelSchedule.Visible = false;
            panelAppointment.Visible = false;
            panelBilling.Visible = false;
            panelHumanResources.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDoctor.Visible == true)
                panelDoctor.Visible = false;
            if (panelPatient.Visible == true)
                panelPatient.Visible = false;
            if (panelSchedule.Visible == true)
                panelSchedule.Visible = false;
            if (panelAppointment.Visible == true)
                panelAppointment.Visible = false;
            if (panelBilling.Visible == true)
                panelBilling.Visible = false;
            if (panelHumanResources.Visible == true)
                panelHumanResources.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                hideSubMenu();
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 300;
                pictureBoxLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        #region Doctor
        private void btnDoctor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDoctor);
        }
        public void btnAddDoctor_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnAddDoctor.Tag.ToString();
            openChildForm(new FormAddDoctor());
        }
        private void btnDoctorList_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnDoctorList.Tag.ToString();
            openChildForm(new FormDoctorList());
        }
        #endregion

        #region Patient
        private void btnPatient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPatient);
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            openChildForm(new AddPatient());
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPatientList());
        }

        #endregion

        #region Schedule
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSchedule);
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddSchedule());
        }

        private void btnScheduleList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormScheduleList());
        }
        #endregion

        #region Appointment
        private void btnAppointment_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAppointment);
        }

        private void button1btnAddAppointmnet_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddAppointment());
        }

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAppointmentList());
        }
        #endregion


        #region Billing
        private void btnBilling_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBilling);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddBill());
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBillList());

        }
        #endregion
        #region Human Resources
        private void btnHumanResources_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHumanResources);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddEmployee());
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployeeList());
        }
        #endregion


        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
