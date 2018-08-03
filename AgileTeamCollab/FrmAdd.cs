using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgileTeamCollabLibrary;

namespace AgileTeamCollab
{
    public partial class FrmAdd : Form
    {
        List<Barang> list = null;
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (var barangdao = new BarangDAO())
            {
                list = barangdao.GetAllDataBarang();
            }

            

            if (txtKode.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtHarga.Text.Trim() == "" || txtPajak.Text.Trim() == "")
            {
                MessageBox.Show("Tolong isi semua data yang diperlukan!", "Kosong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtKode.Text.Length > 4)
            {
                MessageBox.Show("Kode Barang tidak boleh melebihi 4 karakter!", "Kode Barang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNama.Text.Length > 50)
            {
                MessageBox.Show("Nama tidak boleh melebihi 50 karakter !", "Nama Terlalu Panjang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Decimal.Parse(txtPajak.Text) > 100)
            {
                MessageBox.Show("Pajak tidak boleh melebihi 100%", "Pajak Melebihi Batas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (list.Find(i => i.Kode.ToLower().ToString().Trim() == txtKode.Text.Trim().ToLower()) != null)
            {
                MessageBox.Show("Kode barang invalid ! Coba kode lain!", "Kode Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    using (var barangdao = new BarangDAO())
                    {
                        barangdao.Insert(new Barang
                        {
                            Kode = txtKode.Text,
                            Nama = txtNama.Text,
                            Harga = Double.Parse(txtHarga.Text),
                            Pajak = Decimal.Parse(txtPajak.Text)
                        });
                    }
                    MessageBox.Show("Penambahan Barang Berhasil", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert 1000 => 1.000
                if (this.txtHarga.Text.Trim() != "")
                {
                    if (double.TryParse(this.txtHarga.Text, out double result))
                    {
                        this.txtHarga.Text = result.ToString("n0");
                        this.txtHarga.SelectionStart = this.txtHarga.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPajak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
