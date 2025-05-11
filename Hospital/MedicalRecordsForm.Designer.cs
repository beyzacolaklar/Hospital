namespace Hospital
{
    partial class MedicalRecordsForm
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
            this.SuspendLayout();
            // 
            // MedicalRecordsForm
            // 
            this.ClientSize = new System.Drawing.Size(866, 528);
            this.Name = "MedicalRecordsForm";
            this.Text = "MedicalRecordsForm";
            this.Load += new System.EventHandler(this.MedicalRecordsForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPatients;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.DateTimePicker dtpRecordDate;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.TextBox txtPrescriptions;
    }
}