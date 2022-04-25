namespace Hospital_Management_System
{
    partial class FormAddBill
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
            this.txtAID = new System.Windows.Forms.TextBox();
            this.txtpatientID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardOrChequeNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerBillDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDischargeDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnPaid = new System.Windows.Forms.RadioButton();
            this.rbtnUnpaid = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPayable = new System.Windows.Forms.TextBox();
            this.txtPayAdvance = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAID
            // 
            this.txtAID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAID.BackColor = System.Drawing.SystemColors.Window;
            this.txtAID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAID.Location = new System.Drawing.Point(4, 17);
            this.txtAID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAID.Multiline = true;
            this.txtAID.Name = "txtAID";
            this.txtAID.Size = new System.Drawing.Size(184, 23);
            this.txtAID.TabIndex = 139;
            this.txtAID.Text = "AID";
            // 
            // txtpatientID
            // 
            this.txtpatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpatientID.BackColor = System.Drawing.SystemColors.Window;
            this.txtpatientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpatientID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatientID.Location = new System.Drawing.Point(196, 17);
            this.txtpatientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtpatientID.Multiline = true;
            this.txtpatientID.Name = "txtpatientID";
            this.txtpatientID.Size = new System.Drawing.Size(184, 23);
            this.txtpatientID.TabIndex = 140;
            this.txtpatientID.Text = "Patient ID";
            this.txtpatientID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(4, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 23);
            this.textBox2.TabIndex = 141;
            this.textBox2.Text = "Patient Name";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(4, 95);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(375, 46);
            this.textBox3.TabIndex = 142;
            this.textBox3.Text = "Address";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(527, 62);
            this.dateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(243, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 152;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 153;
            this.label9.Text = "Sex:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(448, 93);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(72, 27);
            this.rbtnMale.TabIndex = 154;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(518, 95);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(96, 27);
            this.rbtnFemale.TabIndex = 155;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 23);
            this.label12.TabIndex = 160;
            this.label12.Text = "Admission Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 161;
            this.label1.Text = "Discharge Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 163;
            this.label2.Text = "Payment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 164;
            this.label3.Text = "Card / Cheque No:";
            // 
            // txtCardOrChequeNo
            // 
            this.txtCardOrChequeNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardOrChequeNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardOrChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardOrChequeNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardOrChequeNo.Location = new System.Drawing.Point(179, 274);
            this.txtCardOrChequeNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardOrChequeNo.Multiline = true;
            this.txtCardOrChequeNo.Name = "txtCardOrChequeNo";
            this.txtCardOrChequeNo.Size = new System.Drawing.Size(590, 23);
            this.txtCardOrChequeNo.TabIndex = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 166;
            this.label4.Text = "Receipt No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dateTimePickerBillDate);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateTimePickerPaymentDate);
            this.groupBox1.Controls.Add(this.dateTimePickerAdmissionDate);
            this.groupBox1.Controls.Add(this.dateTimePickerDischargeDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbtnPaid);
            this.groupBox1.Controls.Add(this.rbtnUnpaid);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtReceiptNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCardOrChequeNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtpatientID);
            this.groupBox1.Controls.Add(this.txtAID);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1156, 610);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(920, 217);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 172;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePickerBillDate
            // 
            this.dateTimePickerBillDate.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBillDate.Location = new System.Drawing.Point(527, 21);
            this.dateTimePickerBillDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBillDate.Name = "dateTimePickerBillDate";
            this.dateTimePickerBillDate.Size = new System.Drawing.Size(243, 20);
            this.dateTimePickerBillDate.TabIndex = 176;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(822, 217);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 41);
            this.btnReset.TabIndex = 171;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(394, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 175;
            this.label13.Text = "Bill Date:";
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(177, 235);
            this.dateTimePickerPaymentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(591, 20);
            this.dateTimePickerPaymentDate.TabIndex = 174;
            // 
            // dateTimePickerAdmissionDate
            // 
            this.dateTimePickerAdmissionDate.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdmissionDate.Location = new System.Drawing.Point(179, 157);
            this.dateTimePickerAdmissionDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAdmissionDate.Name = "dateTimePickerAdmissionDate";
            this.dateTimePickerAdmissionDate.Size = new System.Drawing.Size(591, 20);
            this.dateTimePickerAdmissionDate.TabIndex = 173;
            // 
            // dateTimePickerDischargeDate
            // 
            this.dateTimePickerDischargeDate.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDischargeDate.Location = new System.Drawing.Point(179, 196);
            this.dateTimePickerDischargeDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDischargeDate.Name = "dateTimePickerDischargeDate";
            this.dateTimePickerDischargeDate.Size = new System.Drawing.Size(591, 20);
            this.dateTimePickerDischargeDate.TabIndex = 172;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 171;
            this.label11.Text = "Date of Birth:";
            // 
            // rbtnPaid
            // 
            this.rbtnPaid.AutoSize = true;
            this.rbtnPaid.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaid.Location = new System.Drawing.Point(141, 568);
            this.rbtnPaid.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnPaid.Name = "rbtnPaid";
            this.rbtnPaid.Size = new System.Drawing.Size(68, 27);
            this.rbtnPaid.TabIndex = 170;
            this.rbtnPaid.TabStop = true;
            this.rbtnPaid.Text = "Paid";
            this.rbtnPaid.UseVisualStyleBackColor = true;
            // 
            // rbtnUnpaid
            // 
            this.rbtnUnpaid.AutoSize = true;
            this.rbtnUnpaid.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUnpaid.Location = new System.Drawing.Point(52, 568);
            this.rbtnUnpaid.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnUnpaid.Name = "rbtnUnpaid";
            this.rbtnUnpaid.Size = new System.Drawing.Size(95, 27);
            this.rbtnUnpaid.TabIndex = 169;
            this.rbtnUnpaid.TabStop = true;
            this.rbtnUnpaid.Text = "Unpaid";
            this.rbtnUnpaid.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPayable);
            this.panel1.Controls.Add(this.txtPayAdvance);
            this.panel1.Controls.Add(this.txtTax);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(4, 352);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 200);
            this.panel1.TabIndex = 168;
            // 
            // txtPayable
            // 
            this.txtPayable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayable.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayable.Location = new System.Drawing.Point(172, 161);
            this.txtPayable.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayable.Multiline = true;
            this.txtPayable.Name = "txtPayable";
            this.txtPayable.Size = new System.Drawing.Size(592, 23);
            this.txtPayable.TabIndex = 176;
            // 
            // txtPayAdvance
            // 
            this.txtPayAdvance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayAdvance.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayAdvance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayAdvance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayAdvance.Location = new System.Drawing.Point(172, 124);
            this.txtPayAdvance.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayAdvance.Multiline = true;
            this.txtPayAdvance.Name = "txtPayAdvance";
            this.txtPayAdvance.Size = new System.Drawing.Size(592, 23);
            this.txtPayAdvance.TabIndex = 175;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTax.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(172, 83);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(592, 23);
            this.txtTax.TabIndex = 174;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(172, 44);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(592, 23);
            this.txtDiscount.TabIndex = 173;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 23);
            this.label10.TabIndex = 172;
            this.label10.Text = "Payable:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 171;
            this.label8.Text = "Pay Advance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 170;
            this.label7.Text = "Tax %:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 169;
            this.label6.Text = "Discount %:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(172, 5);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(592, 23);
            this.txtTotal.TabIndex = 168;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 167;
            this.label5.Text = "Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReceiptNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiptNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptNo.Location = new System.Drawing.Point(179, 313);
            this.txtReceiptNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiptNo.Multiline = true;
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(590, 23);
            this.txtReceiptNo.TabIndex = 167;
            // 
            // FormAddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 716);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddBill";
            this.Text = "AddBill";
            this.Load += new System.EventHandler(this.FormAddBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.TextBox txtpatientID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardOrChequeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPayable;
        private System.Windows.Forms.TextBox txtPayAdvance;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.RadioButton rbtnPaid;
        private System.Windows.Forms.RadioButton rbtnUnpaid;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdmissionDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDischargeDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillDate;
        private System.Windows.Forms.Label label13;
    }
}