namespace Hospital_Management_System
{
    partial class FormAddAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.dateTimePickerAppointmrntDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepartmentName);
            this.groupBox1.Controls.Add(this.dateTimePickerAppointmrntDate);
            this.groupBox1.Controls.Add(this.rbtnInactive);
            this.groupBox1.Controls.Add(this.rbtnActive);
            this.groupBox1.Controls.Add(this.txtProblem);
            this.groupBox1.Controls.Add(this.txtPatientID);
            this.groupBox1.Controls.Add(this.txtSerialNo);
            this.groupBox1.Controls.Add(this.txtDoctorName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPatientID);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1124, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartmentName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentName.Location = new System.Drawing.Point(186, 54);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepartmentName.Multiline = true;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(376, 23);
            this.txtDepartmentName.TabIndex = 155;
            // 
            // dateTimePickerAppointmrntDate
            // 
            this.dateTimePickerAppointmrntDate.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAppointmrntDate.Location = new System.Drawing.Point(186, 132);
            this.dateTimePickerAppointmrntDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerAppointmrntDate.Name = "dateTimePickerAppointmrntDate";
            this.dateTimePickerAppointmrntDate.Size = new System.Drawing.Size(376, 20);
            this.dateTimePickerAppointmrntDate.TabIndex = 154;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactive.Location = new System.Drawing.Point(268, 249);
            this.rbtnInactive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(104, 27);
            this.rbtnInactive.TabIndex = 153;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.Location = new System.Drawing.Point(186, 249);
            this.rbtnActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(86, 27);
            this.rbtnActive.TabIndex = 152;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // txtProblem
            // 
            this.txtProblem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProblem.BackColor = System.Drawing.SystemColors.Window;
            this.txtProblem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProblem.Location = new System.Drawing.Point(186, 210);
            this.txtProblem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(376, 23);
            this.txtProblem.TabIndex = 143;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientID.Location = new System.Drawing.Point(186, 15);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientID.Multiline = true;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(376, 23);
            this.txtPatientID.TabIndex = 141;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerialNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNo.Location = new System.Drawing.Point(186, 171);
            this.txtSerialNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSerialNo.Multiline = true;
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(376, 23);
            this.txtSerialNo.TabIndex = 140;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDoctorName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorName.Location = new System.Drawing.Point(186, 93);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDoctorName.Multiline = true;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(376, 23);
            this.txtDoctorName.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 92;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 91;
            this.label5.Text = "Problem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 90;
            this.label4.Text = "Serial No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 89;
            this.label3.Text = "Appointment Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 88;
            this.label2.Text = "Doctor Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 87;
            this.label1.Text = "Department Name:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(4, 15);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(114, 23);
            this.lblPatientID.TabIndex = 86;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(196, 327);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(116, 327);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 41);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 648);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddAppointment";
            this.Text = "AddAppointment";
            this.Load += new System.EventHandler(this.FormAddAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmrntDate;
        private System.Windows.Forms.TextBox txtDepartmentName;
    }
}