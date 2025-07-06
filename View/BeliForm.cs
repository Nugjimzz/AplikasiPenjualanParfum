// BeliForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AplikasiPenjualanParfum.Model;

namespace AplikasiPenjualanParfum.View
{
    public partial class BeliForm : Form, IPembelianView
    {
        private List<KeranjangItem> keranjang = new List<KeranjangItem>();
        private readonly BeliController _controller;

        public BeliForm()
        {
            InitializeComponent();
            _controller = new BeliController(this);
        }

        private void BeliForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            dgvKeranjang.AutoGenerateColumns = true;
            dgvKeranjang.DataSource = keranjang;
        }

        private void LoadComboBox()
        {
            cmbParfum.Items.Clear();
            var parfums = _controller.GetParfums();
            foreach (var p in parfums)
            {
                cmbParfum.Items.Add(p);
            }

            if (cmbParfum.Items.Count > 0)
                cmbParfum.SelectedIndex = 0;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var selectedItem = cmbParfum.SelectedItem as KeyValuePair<int, string>?;
            if (!selectedItem.HasValue)
            {
                _view.ShowMessage("Pilih parfum terlebih dahulu.");
                return;
            }

            int parfumId = selectedItem.Value.Key;
            string nama = selectedItem.Value.Value;
            decimal harga = _controller.GetHarga(parfumId);
            int jumlah = (int)numJumlah.Value;

            int stok = _controller.GetStok(parfumId);
            if (jumlah > stok)
            {
                _view.ShowMessage($"Stok tidak mencukupi. Stok tersisa: {stok}");
                return;
            }

            keranjang.Add(new KeranjangItem
            {
                ParfumID = parfumId,
                NamaParfum = nama,
                Harga = harga,
                Jumlah = jumlah
            });

            RefreshKeranjang();
        }

        private void RefreshKeranjang()
        {
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = keranjang;
            HitungTotal();
        }

        private void HitungTotal()
        {
            decimal total = 0;
            foreach (var item in keranjang)
            {
                total += item.Total;
            }
            lblTotal.Text = $"Total: Rp. {total:N2}";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKeranjang.SelectedRows.Count > 0)
            {
                var item = dgvKeranjang.SelectedRows[0].DataBoundItem as KeranjangItem;
                keranjang.Remove(item);
                RefreshKeranjang();
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            _controller.ProsesPembelian(keranjang);
        }

        // Implementasi dari IPembelianView
        public void ShowItems(List<KeranjangItem> items)
        {
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = items;
        }

        public void ClearCart()
        {
            keranjang.Clear();
            RefreshKeranjang();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}