// MainForm.cs
using System;
using System.Windows.Forms;
using AplikasiPenjualanParfum.Controller;

namespace AplikasiPenjualanParfum.View
{
    public partial class MainForm : Form, IMainView
    {
        private readonly MainController _controller;

        public MainForm()
        {
            InitializeComponent();
            _controller = new MainController(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Aplikasi Penjualan Parfum - {Helper.CurrentUser} ({Helper.UserRole})";
            _controller.LoadAccess();
        }

        public void ShowMessage(string message)
        {
            Helper.ShowMessage(message);
        }

        public void OpenParfumForm()
        {
            var parfumForm = new ParfumForm();
            parfumForm.MdiParent = this;
            parfumForm.Show();
        }

        public void OpenBeliForm()
        {
            var beliForm = new BeliForm();
            beliForm.MdiParent = this;
            beliForm.Show();
        }

        public void SetAccessControls(bool isUserAdmin, bool isUserRegular)
        {
            masterParfumToolStripMenuItem.Enabled = isUserAdmin;
            beliParfumToolStripMenuItem.Enabled = isUserRegular;
        }

        private void masterParfumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.HandleMasterParfumClick();
        }

        private void beliParfumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.HandleBeliParfumClick();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Kosongkan atau tambahkan logika jika perlu
        }
    }
}