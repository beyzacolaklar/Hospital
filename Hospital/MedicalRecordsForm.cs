using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MedicalRecordsForm : Form
    {
        string connectionString = "Server=DESKTOP-V90KD6F; Database=HospitalDB; Integrated Security=True;";
        public MedicalRecordsForm()
        {
            InitializeComponent();
        }

        // Form yüklenirken hastaları ComboBox'a yükle
        private void MedicalRecordsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();  // Hastaları ComboBox'a yükle
        }

        // Hastaları ComboBox'a yüklemek
        private void LoadPatients()
        {
            string query = "SELECT PatientID, Name FROM Patients";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbPatients.Items.Add(new { Text = reader["Name"].ToString(), Value = reader["PatientID"] });
                    }
                    cmbPatients.DisplayMember = "Text";
                    cmbPatients.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Hasta seçildiğinde, seçilen hastanın medikal kayıtlarını yükle
        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatients.SelectedItem != null)
            {
                int patientID = ((dynamic)cmbPatients.SelectedItem).Value; // Seçilen hastanın ID'si
                LoadMedicalRecords(patientID); // Seçilen hastanın kayıtlarını yükle
            }
        }

        // Seçilen hastanın medikal kayıtlarını DataGridView'e yüklemek
        private void LoadMedicalRecords(int patientID)
        {
            string query = "SELECT RecordID, Diagnosis, Treatment, Prescriptions, Date FROM MedicalRecords WHERE PatientID = @patientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@patientID", patientID);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable); // Medikal kayıtları al ve DataTable'a yükle

                    // DataGridView'i güncelle
                    dgvMedicalRecords.DataSource = dataTable;  // Verileri DataGridView'e yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Medikal kaydı kaydetme
        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            int patientID = ((dynamic)cmbPatients.SelectedItem).Value;
            string diagnosis = txtDiagnosis.Text;
            string treatment = txtTreatment.Text;
            string prescriptions = txtPrescriptions.Text;
            DateTime recordDate = dtpRecordDate.Value;

            string query = "INSERT INTO MedicalRecords (PatientID, Diagnosis, Treatment, Prescriptions, Date) " +
                           "VALUES (@patientID, @diagnosis, @treatment, @prescriptions, @date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@patientID", patientID);
                command.Parameters.AddWithValue("@diagnosis", diagnosis);
                command.Parameters.AddWithValue("@treatment", treatment);
                command.Parameters.AddWithValue("@prescriptions", prescriptions);
                command.Parameters.AddWithValue("@date", recordDate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery(); // Veritabanına kaydet
                    MessageBox.Show("Medikal kayıt başarıyla kaydedildi.");
                    LoadMedicalRecords(patientID); // Kaydettikten sonra kayıtları tekrar yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void MedicalRecordsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

