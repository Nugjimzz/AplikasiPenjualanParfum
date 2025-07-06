// IPembelianView.cs
using System.Collections.Generic;
using AplikasiPenjualanParfum; // Sesuaikan jika namespace berbeda

namespace AplikasiPenjualanParfum.Controller
{
    public interface IPembelianView
    {
        // Menampilkan daftar item di keranjang
        void ShowItems(List<KeranjangItem> items);

        // Mengosongkan keranjang setelah pembelian
        void ClearCart();

        // Menampilkan pesan ke pengguna (MessageBox)
        void ShowMessage(string message);
    }
}