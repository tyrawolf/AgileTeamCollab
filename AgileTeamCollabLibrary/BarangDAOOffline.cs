using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileTeamCollabLibrary
{
    public class BarangDAOOffline
    {
        List<Barang> Temporary = null;

        public BarangDAOOffline()
        {
            Temporary = new List<Barang>();
        }

        public int Update(string kode, string nama, double hrg, decimal pjk)
        {
            int success = 0;
            if (hrg < 0)
            {
                throw new ArgumentException("Harga tak boleh minus");
            }
            else if (pjk <= 0)
            {
                throw new ArgumentException("Pajak harus lebih dari 0");
            }
            else if (pjk > 100)
            {
                throw new ArgumentException("Pajak maksimal 100%");
            }
            else if (pjk <= 0)
            {
                throw new ArgumentException("Pajak harus lebih dari 0");
            }
            else if (kode.Trim() == "")
            {
                throw new ArgumentException("Kode tak boleh kosong");
            }
            else if (nama.Trim() == "")
            {
                throw new ArgumentException("Nama tak boleh kosong");
            }
            else if (kode.Length > 4)
            {
                throw new ArgumentException("Kode tidak boleh melebihi 4 karakter");
            }
            else if (nama.Length > 50)
            {
                throw new ArgumentException("Nama tidak boleh melebihi 50 karakter");
            }
            try
            {
                foreach (var item in Temporary)
                {
                    if (item.Kode == kode)
                    {
                        item.Nama = nama;
                        item.Harga = hrg;
                        item.Pajak = pjk;
                        
                        break;
                    }
                }
                success = 1;
            }
           
            catch (Exception ex)
            {
                throw ex;
            }
            return success;

        }

        public Barang GetDataBarangByKode(string kode)
        {
            if (kode.Length > 4)
            {
                throw new ArgumentException("Kode maksimal 4 karakter");
            }
            else if (kode.Trim() == "")
            {
                throw new ArgumentException("Kode tak boleh kosong");
            }
            Barang result = null;
            try
            {
                foreach (var item in Temporary)
                {
                    if (item.Kode == kode)
                    {
                        result = item;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Insert(string kode, string nama, double hrg, decimal pjk)
        {
            int success = 0;
            if (hrg < 0)
            {
                throw new ArgumentException("Harga tak boleh minus");
            }
            else if (pjk <= 0)
            {
                throw new ArgumentException("Pajak harus lebih dari 0");
            }
            else if (pjk > 100)
            {
                throw new ArgumentException("Pajak maksimal 100%");
            }
            else if (pjk <= 0)
            {
                throw new ArgumentException("Pajak harus lebih dari 0");
            }
            else if (kode.Trim() == "")
            {
                throw new ArgumentException("Kode tak boleh kosong");
            }
            else if (nama.Trim() == "")
            {
                throw new ArgumentException("Nama tak boleh kosong");
            }
            else if (kode.Length > 4)
            {
                throw new ArgumentException("Kode tidak boleh melebihi 4 karakter");
            }
            else if (nama.Length > 50)
            {
                throw new ArgumentException("Nama tidak boleh melebihi 50 karakter");
            }
            else if (Temporary.Find(i => i.Kode == kode) != null)
            {
                throw new ArgumentException("Kode sudah ada");
            }

            try
            {
                Temporary.Add(new Barang { Kode = kode, Nama = nama, Harga = hrg, Pajak = pjk });
                success = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return success;
        }

        public int Delete(string kode)
        {
            int success = 0;
            if (kode.Length > 4)
            {
                throw new ArgumentException("Kode maksimal 4 karakter");
            }
            else if (kode.Trim() == "")
            {
                throw new ArgumentException("Kode tak boleh kosong");
            }
            try
            {
                
                Temporary.Remove(Temporary.Find(i => i.Kode == kode));
                    
                success = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return success;
        }
    }
}
