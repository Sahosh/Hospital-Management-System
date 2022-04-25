namespace Hospital_Management_System
{
    partial class FormEmployeeList
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
            this.dataGridViewDoctorList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtColumnValue = new System.Windows.Forms.TextBox();
            this.lblColumnValue = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.lblColumnName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctorList
            // 
            this.dataGridViewDoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorList.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewDoctorList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDoctorList.Name = "dataGridViewDoctorList";
            this.dataGridViewDoctorList.RowHeadersWidth = 51;
            this.dataGridViewDoctorList.RowTemplate.Height = 24;
            this.dataGridViewDoctorList.Size = new System.Drawing.Size(805, 756);
            this.dataGridViewDoctorList.TabIndex = 1;
            this.dataGridViewDoctorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctorList_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelUpdate);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnShowUpdate);
            this.panel1.Location = new System.Drawing.Point(625, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 756);
            this.panel1.TabIndex = 3;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.txtColumnValue);
            this.panelUpdate.Controls.Add(this.lblColumnValue);
            this.panelUpdate.Controls.Add(this.txtColumnName);
            this.panelUpdate.Controls.Add(this.lblColumnName);
            this.panelUpdate.Location = new System.Drawing.Point(4, 301);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(370, 214);
            this.panelUpdate.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(2, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(313, 41);
            this.btnUpdate.TabIndex = 162;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtColumnValue
            // 
            this.txtColumnValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtColumnValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColumnValue.Location = new System.Drawing.Point(6, 126);
            this.txtColumnValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumnValue.Multiline = true;
            this.txtColumnValue.Name = "txtColumnValue";
            this.txtColumnValue.Size = new System.Drawing.Size(256, 23);
            this.txtColumnValue.TabIndex = 161;
            // 
            // lblColumnValue
            // 
            this.lblColumnValue.AutoSize = true;
            this.lblColumnValue.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnValue.Location = new System.Drawing.Point(2, 87);
            this.lblColumnValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumnValue.Name = "lblColumnValue";
            this.lblColumnValue.Size = new System.Drawing.Size(164, 23);
            this.lblColumnValue.TabIndex = 160;
            this.lblColumnValue.Text = "Enter the value:";
            // 
            // txtColumnName
            // 
            this.txtColumnName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtColumnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColumnName.Location = new System.Drawing.Point(2, 48);
            this.txtColumnName.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumnName.Multiline = true;
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(256, 23);
            this.txtColumnName.TabIndex = 159;
            // 
            // lblColumnName
            // 
            this.lblColumnName.AutoSize = true;
            this.lblColumnName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnName.Location = new System.Drawing.Point(2, 9);
            this.lblColumnName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumnName.Name = "lblColumnName";
            this.lblColumnName.Size = new System.Drawing.Size(349, 23);
            this.lblColumnName.TabIndex = 158;
            this.lblColumnName.Text = "Which column you want to update?";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(2, 60);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(317, 41);
            this.txtID.TabIndex = 12;
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(0, 247);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(319, 41);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(0, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(319, 41);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowUpdate
            // 
            this.btnShowUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.btnShowUpdate.FlatAppearance.BorderSize = 0;
            this.btnShowUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUpdate.Location = new System.Drawing.Point(2, 124);
            this.btnShowUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowUpdate.Name = "btnShowUpdate";
            this.btnShowUpdate.Size = new System.Drawing.Size(317, 41);
            this.btnShowUpdate.TabIndex = 8;
            this.btnShowUpdate.Text = "Update";
            this.btnShowUpdate.UseVisualStyleBackColor = false;
            this.btnShowUpdate.Click += new System.EventHandler(this.btnShowUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 756);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewDoctorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctorList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtColumnValue;
        private System.Windows.Forms.Label lblColumnValue;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.Label lblColumnName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}