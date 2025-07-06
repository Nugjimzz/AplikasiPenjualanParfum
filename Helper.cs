using System;
using System.Windows.Forms;

namespace AplikasiPenjualanParfum
{
    public static class Helper
    {
        public static string ConnectionString = "Server=localhost;Database=parfumdb;Uid=root;Pwd=;";
        public static string CurrentUser = "";
        public static string UserRole = "";

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}