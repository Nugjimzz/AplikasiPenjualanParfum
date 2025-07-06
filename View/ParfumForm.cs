// ParfumForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AplikasiPenjualanParfum.Controller;
using AplikasiPenjualanParfum.Model;

namespace AplikasiPenjualanParfum.View
{
    public partial class ParfumForm : Form, IParfumView
    {
        private readonly ParfumController _controller;

        public ParfumForm()
        {
            InitializeComponent();
            _controller = new ParfumController(this);
        }

        private void ParfumForm_Load(object sender, EventArgs e)
        {
            _controller.LoadData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var parfum = new Parfum
            {
                NamaParfum = txtNama.Text,
                Harga = decimal.Parse(txtHarga.Text),
                Stok = int.Parse(txtStok.Text)
            };

            _controller.AddParfum(parfum);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvParfum.SelectedRows.Count == 0) return;

            var selected = dgvParfum.SelectedRows[0].DataBoundItem as Parfum;

            selected.NamaParfum = txtNama.Text;
            selected.Harga = decimal.Parse(txtHarga.Text);
            selected.Stok = int.Parse(txtStok.Text);

            _controller.UpdateParfum(selected);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvParfum.SelectedRows.Count == 0) return;

            var selected = dgvParfum.SelectedRows[0].DataBoundItem as Parfum;
            _controller.DeleteParfum(selected.ParfumID);
        }

        private void dgvParfum_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParfum.SelectedRows.Count > 0)
            {
                var p = dgvParfum.SelectedRows[0].DataBoundItem as Parfum;
                txtNama.Text = p.NamaParfum;
                txtHarga.Text = p.Harga.ToString();
                txtStok.Text = p.Stok.ToString();
            }
        }

        public void ShowParfums(List<Parfum> list)
        {
            dgvParfum.DataSource = null;
            dgvParfum.DataSource = list;
        }

        public void ClearInput()
        {
            txtNama.Clear();
            txtHarga.Clear();
            txtStok.Clear();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtHarga.Text) ||
                string.IsNullOrWhiteSpace(txtStok.Text))
            {
                ShowMessage("Semua field harus diisi.");
                return false;
            }

            if (!decimal.TryParse(txtHarga.Text, out _) || !int.TryParse(txtStok.Text, out _))
            {
                ShowMessage("Harga dan stok harus berupa angka.");
                return false;
            }

            return true;
        }
    }
}