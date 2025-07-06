namespace AplikasiPenjualanParfum.Model
{
    public class KeranjangItem
    {
        public int ParfumID { get; set; }
        public string NamaParfum { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
        public decimal Total => Harga * Jumlah;
    }
}