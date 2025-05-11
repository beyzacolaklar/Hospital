using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Hospital
{
    public partial class Loginform : Form
    {
        string connectionString = "Server=DESKTOP-V90KD6F; Database=HospitalDB; Integrated Security=True;";

        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Şifreyi göster
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;  // Şifreyi gizle
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Server=DESKTOP-V90KD6F; Database=HospitalDB; Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Giriş başarılı!");

                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}