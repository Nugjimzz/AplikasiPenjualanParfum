using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AplikasiPenjualanParfum
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Helper.ShowMessage("Isi semua kolom!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(Helper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT role FROM users WHERE username=@user AND password=@pass", conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    var role = cmd.ExecuteScalar();

                    if (role != null)
                    {
                        Helper.CurrentUser = username;
                        Helper.UserRole = role.ToString();

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        Helper.ShowMessage("Login gagal! Periksa username/password.");
                    }
                }
                catch (Exception ex)
                {
                    Helper.ShowMessage("Koneksi database gagal: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}