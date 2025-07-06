// IRegisterView.cs
namespace AplikasiPenjualanParfum.Controller
{
    public interface IRegisterView
    {
        string Username { get; }
        string Password { get; }

        void ShowMessage(string message);
        void NavigateToLogin();
    }
}