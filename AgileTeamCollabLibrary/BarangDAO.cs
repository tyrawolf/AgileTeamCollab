using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgileTeamCollabLibrary
{
    public class BarangDAO : IDisposable
    {
        SqlConnection conn = null;

        public BarangDAO()
        {
            try
            {
                conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Barang> GetAllDataBarang()
        {
            List<Barang> list = new List<Barang>();
            
            try
            {

                string sqlstring = @"select * from Barang";

                SqlCommand cmd = new SqlCommand(sqlstring, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string kode = reader["Kode"].ToString();
                        string nama = reader["Nama"].ToString();
                        double hrg = Double.Parse(reader["Harga"].ToString());
                        double pjk = Double.Parse(reader["Pajak"].ToString());

                        list.Add(new Barang {
                            Kode = kode,
                            Nama = nama,
                            Harga = hrg,
                            Pajak = pjk
                        });
                    }
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return list;
        }

        public void Dispose()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

    

