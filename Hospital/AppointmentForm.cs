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
    public partial class AppointmentForm : Form
    {
        string connectionString = "Server=DESKTOP-V90KD6F; Database=HospitalDB; Integrated Security=True;";
        public AppointmentForm()
        {
            InitializeComponent();
        }
     
        private void btnBook_Click(object sender, EventArgs e)
        {

            // Bu fonksiyonun içine randevu ekleme kodlarını yazacaksın.

            int doctorId = (int)cmbDoctor.SelectedValue;
            int patientId = (int)cmbPatients.SelectedValue;
            DateTime appointmentDate = dtpAppointment.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate) VALUES (@patientId, @doctorId, @date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@patientId", patientId);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@date", appointmentDate);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla oluşturuldu.");
                LoadAppointments(sender, e);
            }


        }
        private void LoadAppointments(object sender, EventArgs e)
        {
           
        }
        private void LoadDoctors(object sender, EventArgs e)
        {
            
        }
        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors(sender,e);
        }
        private void LoadPatients()
        {
            cmbPatients.Items.Clear(); // Var olanları temizle

            try {
                using (SqlConnection con = new SqlConnection(connectionString))
            {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT PatientID, Name FROM Patients", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["PatientID"]);
                        string name = reader["Name"].ToString();
                        cmbPatients.Items.Add(new KeyValuePair<int, string>(id, name));
                    }

                    reader.Close();
                    con.Close();

                    cmbPatients.DisplayMember = "Value";
                    cmbPatients.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta listesi yüklenemedi: " + ex.Message);
            }
        }

    }
}
