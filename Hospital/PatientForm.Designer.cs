namespace Hospital
{
    partial class PatientForm
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
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.txtPatientEmail = new System.Windows.Forms.TextBox();
            this.txtPatientContact = new System.Windows.Forms.TextBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(23, 21);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(100, 22);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.Text = "Patient Name:";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(23, 70);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(100, 22);
            this.txtPatientAge.TabIndex = 1;
            this.txtPatientAge.Text = "Patient Age:";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Location = new System.Drawing.Point(23, 165);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(100, 22);
            this.txtPatientAddress.TabIndex = 2;
            this.txtPatientAddress.Text = "Patient Address:";
            // 
            // txtPatientEmail
            // 
            this.txtPatientEmail.Location = new System.Drawing.Point(23, 209);
            this.txtPatientEmail.Name = "txtPatientEmail";
            this.txtPatientEmail.Size = new System.Drawing.Size(100, 22);
            this.txtPatientEmail.TabIndex = 3;
            this.txtPatientEmail.Text = "Patient Email:";
            // 
            // txtPatientContact
            // 
            this.txtPatientContact.Location = new System.Drawing.Point(23, 117);
            this.txtPatientContact.Name = "txtPatientContact";
            this.txtPatientContact.Size = new System.Drawing.Size(100, 22);
            this.txtPatientContact.TabIndex = 4;
            this.txtPatientContact.Text = "Patient Contact:";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(333, 20);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(75, 23);
            this.btnAddPatient.TabIndex = 5;
            this.btnAddPatient.Text = "Add";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Location = new System.Drawing.Point(333, 70);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePatient.TabIndex = 6;
            this.btnUpdatePatient.Text = "Update";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Location = new System.Drawing.Point(333, 128);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePatient.TabIndex = 7;
            this.btnDeletePatient.Text = "Delete";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(54, 268);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(240, 150);
            this.dgvPatients.TabIndex = 8;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(173, 21);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 9;
            this.cmbGender.Text = "Gender";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.txtPatientContact);
            this.Controls.Add(this.txtPatientEmail);
            this.Controls.Add(this.txtPatientAddress);
            this.Controls.Add(this.txtPatientAge);
            this.Controls.Add(this.txtPatientName);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.TextBox txtPatientEmail;
        private System.Windows.Forms.TextBox txtPatientContact;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}