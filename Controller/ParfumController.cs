// ParfumController.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AplikasiPenjualanParfum.Model;

namespace AplikasiPenjualanParfum.Controller
{
    public class ParfumController
    {
        private readonly IParfumView _view;
        private readonly ParfumDAO _parfumDAO;

        public ParfumController(IParfumView view)
        {
            _view = view;
            _parfumDAO = new ParfumDAO();
        }

        public void LoadData()
        {
            try
            {
                var parfums = _parfumDAO.GetAllParfums();
                _view.ShowParfums(parfums);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Gagal memuat data: " + ex.Message);
            }
        }

        public void AddParfum(Parfum parfum)
        {
            try
            {
                _parfumDAO.AddParfum(parfum);
                _view.ShowMessage("Parfum berhasil ditambahkan.");
                LoadData();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Gagal menambah parfum: " + ex.Message);
            }
        }

        public void UpdateParfum(Parfum parfum)
        {
            try
            {
                _parfumDAO.UpdateParfum(parfum);
                _view.ShowMessage("Parfum berhasil diperbarui.");
                LoadData();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Gagal memperbarui parfum: " + ex.Message);
            }
        }

        public void DeleteParfum(int id)
        {
            try
            {
                _parfumDAO.DeleteParfum(id);
                _view.ShowMessage("Parfum berhasil dihapus.");
                LoadData();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Gagal menghapus parfum: " + ex.Message);
            }
        }
    }
}