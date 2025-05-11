using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Registration_Form : Form
    {
       string connectionString = "Server=DESKTOP-V90KD6F; Database=HospitalDB; Integrated Security=True;";
        public Registration_Form()
        {
            InitializeComponent();
            cmbRole.Items.AddRange(new string[] { "Admin", "Staff" });
            cmbRole.SelectedIndex = 0;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;
                string confirm = txtConfirmPassword.Text;
                string role = cmbRole.SelectedItem.ToString();

                // Gerekli alanların boş olup olmadığını kontrol et
                if (username == "" || password == "" || confirm == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                // Şifrelerin uyuşup uyuşmadığını kontrol et
                if (password != confirm)
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                    return;
                }

                // Veritabanına kullanıcı eklemek için SQL sorgusu
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open(); // Veritabanına bağlan
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Parametreleri ekle
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password); // Burada şifreyi düz şekilde ekliyoruz, şifreyi güvenli hale getirmek için hash kullanılmalı
                            cmd.Parameters.AddWithValue("@role", role);

                            cmd.ExecuteNonQuery(); // Sorguyu çalıştır

                            MessageBox.Show("Kayıt başarılı!");

                            // Giriş formuna yönlendir
                            Loginform loginForm = new Loginform();
                            this.Hide(); // Kayıt formunu gizle
                            loginForm.Show(); // Giriş formunu göster
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }


            private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                Loginform loginForm = new Loginform();
                this.Hide();  // Kayıt formunu gizle
                loginForm.Show();  // Giriş formunu göster
            }

        }
    }
    