// Controller/LoginController.cs
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplikasiPenjualanParfum.Controller
{
    public class LoginController
    {
        private readonly ILoginView _view;

        public LoginController(ILoginView view)
        {
            _view = view;
        }

        public void HandleLogin()
        {
            string username = _view.Username;
            string password = _view.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _view.ShowMessage("Username dan password harus diisi.");
                return;
            }

            bool isValid = ValidateUser(username, password);

            if (isValid)
            {
                _view.ShowMessage("Login berhasil!");
                _view.NavigateToMainForm();
            }
            else
            {
                _view.ShowMessage("Username atau password salah.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            using (var conn = new MySqlConnection(Helper.ConnectionString))
            {
                var cmd = new MySqlCommand("SELECT * FROM users WHERE username=@user AND password=MD5(@pass)", conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                var reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }
    }
}