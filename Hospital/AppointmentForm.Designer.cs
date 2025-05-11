namespace Hospital
{
    partial class AppointmentForm
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
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbPatients = new System.Windows.Forms.ComboBox();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.dataGridAppointments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(21, 57);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(188, 24);
            this.cmbDoctor.TabIndex = 0;
            this.cmbDoctor.Text = "Selection of doctor";
            // 
            // cmbPatients
            // 
            this.cmbPatients.FormattingEnabled = true;
            this.cmbPatients.Location = new System.Drawing.Point(21, 116);
            this.cmbPatients.Name = "cmbPatients";
            this.cmbPatients.Size = new System.Drawing.Size(188, 24);
            this.cmbPatients.TabIndex = 1;
            this.cmbPatients.Text = "Seleciton of patient";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(21, 12);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointment.TabIndex = 2;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(229, 374);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(188, 23);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Make a appointment";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dataGridAppointments
            // 
            this.dataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppointments.Location = new System.Drawing.Point(36, 179);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.RowHeadersWidth = 51;
            this.dataGridAppointments.RowTemplate.Height = 24;
            this.dataGridAppointments.Size = new System.Drawing.Size(240, 150);
            this.dataGridAppointments.TabIndex = 4;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridAppointments);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.cmbPatients);
            this.Controls.Add(this.cmbDoctor);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbPatients;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DataGridView dataGridAppointments;
    }
}