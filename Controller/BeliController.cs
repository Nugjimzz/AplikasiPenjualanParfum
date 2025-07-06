// BeliController.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AplikasiPenjualanParfum.Model;
using MySql.Data.MySqlClient;

namespace AplikasiPenjualanParfum.Controller
{
    public class BeliController
    {
        private readonly IPembelianView _view;

        public BeliController(IPembelianView view)
        {
            _view = view;
        }

        public List<KeyValuePair<int, string>> GetParfums()
        {
            var list = new List<KeyValuePair<int, string>>();
            using (var conn = new MySqlConnection(Helper.ConnectionString))
            {
                var cmd = new MySqlCommand("SELECT parfum_id, nama_parfum FROM parfums", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(reader["parfum_id"]),
                        reader["nama_parfum"].ToString()));
                }
            }
            return list;
        }

        public decimal GetHarga(int id)
        {
            using (var conn = new MySqlConnection(Helper.ConnectionString))
            {
                var cmd = new MySqlCommand("SELECT harga FROM parfums WHERE parfum_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public int GetStok(int id)
        {
            using (var conn = new MySqlConnection(Helper.ConnectionString))
            {
                var cmd = new MySqlCommand("SELECT stok FROM parfums WHERE parfum_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void ProsesPembelian(List<KeranjangItem> keranjang)
        {
            if (keranjang.Count == 0)
            {
                _view.ShowMessage("Keranjang kosong!");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(Helper.ConnectionString))
                {
                    conn.Open();
                    foreach (var item in keranjang)
                    {
                        using (var cmd = new MySqlCommand(
                            "INSERT INTO transaksi (user_id, parfum_id, jumlah, total_harga, tanggal_transaksi) VALUES (1, @pid, @jml, @total, NOW())",
                            conn))
                        {
                            cmd.Parameters.AddWithValue("@pid", item.ParfumID);
                            cmd.Parameters.AddWithValue("@jml", item.Jumlah);
                            cmd.Parameters.AddWithValue("@total", item.Total);
                            cmd.ExecuteNonQuery();
                        }

                        using (var updateCmd = new MySqlCommand(
                            "UPDATE parfums SET stok = stok - @jml WHERE parfum_id = @pid",
                            conn))
                        {
                            updateCmd.Parameters.AddWithValue("@jml", item.Jumlah);
                            updateCmd.Parameters.AddWithValue("@pid", item.ParfumID);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }

                _view.ShowMessage("Pembelian berhasil!");
                _view.ClearCart();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Gagal melakukan pembelian: " + ex.Message);
            }
        }
    }
}