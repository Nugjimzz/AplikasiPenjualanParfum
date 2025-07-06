// Controller/ILoginView.cs
namespace AplikasiPenjualanParfum.Controller
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }

        void ShowMessage(string message);
        void NavigateToMainForm();
    }
}