// MainController.cs
using System;
using System.Windows.Forms;

namespace AplikasiPenjualanParfum.Controller
{
    public class MainController
    {
        private readonly IMainView _view;

        public MainController(IMainView view)
        {
            _view = view;
        }

        public void LoadAccess()
        {
            bool isAdmin = Helper.UserRole == "Admin";
            bool isUser = Helper.UserRole == "User";

            _view.SetAccessControls(isAdmin, isUser);
        }

        public void HandleMasterParfumClick()
        {
            if (Helper.UserRole == "Admin")
            {
                _view.OpenParfumForm();
            }
            else
            {
                _view.ShowMessage("Hanya Admin yang dapat mengakses menu ini.");
            }
        }

        public void HandleBeliParfumClick()
        {
            if (Helper.UserRole == "User")
            {
                _view.OpenBeliForm();
            }
            else
            {
                _view.ShowMessage("Hanya User yang dapat melakukan transaksi pembelian.");
            }
        }
    }
}