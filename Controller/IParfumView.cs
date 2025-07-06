// IParfumView.cs
using System.Collections.Generic;
using AplikasiPenjualanParfum;
using AplikasiPenjualanParfum.Model;

namespace AplikasiPenjualanParfum.Controller
{
    public interface IParfumView
    {
        void ShowParfums(List<Parfum> list);
        void ClearInput();
        void ShowMessage(string message);
    }
}