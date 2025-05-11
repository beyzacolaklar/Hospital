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
    public partial class PatientForm : Form
    {
        string connectionString = "Server=DESKTOP-V90KD6F; Database=HospitalDB; Integrated Security=True;";

        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            LoadPatients(); // Form yüklendiğinde hastaları yükle
        }

        // DataGridView tıklama olayı (şimdilik boş bırakılmış)
        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Hastaları veritabanından çekip DataGridView'e yükleme
        private void LoadPatients()
        {
            string query = "SELECT PatientID, Name, Age, Gender, Phone, Address FROM Patients";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dgvPatients.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
