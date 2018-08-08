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
                        decimal pjk = Decimal.Parse(reader["Pajak"].ToString());

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

        public int Update(Barang barang)
        {
            int result = 0;
            SqlTransaction trans = null;
            try
            {
                trans = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"update barang set kode = @kode, nama = @nama,
                        harga = @harga, pajak = @pajak
                        where kode = @kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", barang.Kode);
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
                    cmd.Parameters.AddWithValue("@pajak", barang.Pajak);
                    result = cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans != null) trans.Dispose();
            }
            return result;
        }

        public Barang GetDataBarangByKode(string kode)
        {
            Barang result = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select * from barang Where kode = @Kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Kode", kode);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = new Barang
                                {
                                    Kode = reader["Kode"].ToString(),
                                    Nama = reader["Nama"].ToString(),
                                    Harga = Double.Parse(reader["Harga"].ToString()),
                                    Pajak = Decimal.Parse(reader["Pajak"].ToString())
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Insert(Barang brg)
        {
            int result = 0;
            try
            {

                string sqlString = @"insert into Barang values (@kode, @nama, @harga, @pajak)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", brg.Kode);
                    cmd.Parameters.AddWithValue("@nama", brg.Nama);
                    cmd.Parameters.AddWithValue("@harga", brg.Harga);
                    cmd.Parameters.AddWithValue("@pajak", brg.Pajak);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Delete(string kode)
        {
            int result = 0;
            try
            {
               
                string sqlString = @"delete barang where Kode = @kode";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", kode);

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
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

    

