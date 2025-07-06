// IMainView.cs
namespace AplikasiPenjualanParfum.Controller
{
    public interface IMainView
    {
        void ShowMessage(string message);
        void OpenParfumForm();
        void OpenBeliForm();
        void SetAccessControls(bool isUserAdmin, bool isUserRegular);
    }
}