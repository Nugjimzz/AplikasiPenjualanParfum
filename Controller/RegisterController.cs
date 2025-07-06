// RegisterController.cs
using System;
using MySql.Data.MySqlClient;

namespace AplikasiPenjualanParfum.Controller
{
    public class RegisterController
    {
        private readonly IRegisterView _view;

        public RegisterController(IRegisterView view)
        {
            _view = view;
        }

        public void HandleRegistration()
        {
            string username = _view.Username;
            string password = _view.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _view.ShowMessage("Isi semua kolom!");
                return;
            }

            bool success = InsertUser(username, password);

            if (success)
            {
                _view.ShowMessage("Registrasi berhasil!");
                _view.NavigateToLogin();
            }
            else
            {
                _view.ShowMessage("Gagal melakukan registrasi.");
            }
        }

        private bool InsertUser(string username, string password)
        {
            try
            {
                using (var conn = new MySqlConnection(Helper.ConnectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "INSERT INTO users (username, password, role) VALUES (@user, MD5(@pass), 'User')",
                        conn);

                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error: " + ex.Message);
                return false;
            }
        }
    }
}