using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AplikasiPenjualanParfum.Model
{
    public class ParfumDAO
    {
        private DBConnect dbConn;

        public ParfumDAO()
        {
            dbConn = new DBConnect();
        }

        public List<Parfum> GetAllParfums()
        {
            List<Parfum> list = new List<Parfum>();
            string query = "SELECT * FROM parfums";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConn.GetConnection()))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Parfum
                        {
                            ParfumID = Convert.ToInt32(reader["parfum_id"]),
                            NamaParfum = reader["nama_parfum"].ToString(),
                            Harga = Convert.ToDecimal(reader["harga"]),
                            Stok = Convert.ToInt32(reader["stok"])
                        });
                    }
                }
            }

            dbConn.CloseConnection();
            return list;
        }

        public void AddParfum(Parfum parfum)
        {
            string query = "INSERT INTO parfums (nama_parfum, harga, stok) VALUES (@nama, @harga, @stok)";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConn.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@nama", parfum.NamaParfum);
                cmd.Parameters.AddWithValue("@harga", parfum.Harga);
                cmd.Parameters.AddWithValue("@stok", parfum.Stok);
                cmd.ExecuteNonQuery();
            }

            dbConn.CloseConnection();
        }

        public void UpdateParfum(Parfum parfum)
        {
            string query = "UPDATE parfums SET nama_parfum=@nama, harga=@harga, stok=@stok WHERE parfum_id=@id";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConn.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@nama", parfum.NamaParfum);
                cmd.Parameters.AddWithValue("@harga", parfum.Harga);
                cmd.Parameters.AddWithValue("@stok", parfum.Stok);
                cmd.Parameters.AddWithValue("@id", parfum.ParfumID);
                cmd.ExecuteNonQuery();
            }

            dbConn.CloseConnection();
        }

        public void DeleteParfum(int id)
        {
            string query = "DELETE FROM parfums WHERE parfum_id=@id";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConn.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            dbConn.CloseConnection();
        }
    }
}