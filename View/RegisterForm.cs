// RegisterForm.cs
using System;
using System.Windows.Forms;
using AplikasiPenjualanParfum.Controller;

namespace AplikasiPenjualanParfum.View
{
    public partial class RegisterForm : Form, IRegisterView
    {
        private readonly RegisterController _controller;

        public RegisterForm()
        {
            InitializeComponent();
            _controller = new RegisterController(this);
        }

        // Implementasi dari IRegisterView
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToLogin()
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _controller.HandleRegistration();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigateToLogin();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Bisa kosong dulu atau tambahkan logika jika dibutuhkan
        }
    }
}