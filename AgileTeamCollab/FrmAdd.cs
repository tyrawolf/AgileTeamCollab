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
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using (var barangdao = new BarangDAO())
                {
                    barangdao.Insert(new Barang {
                        Kode = txtKode.Text,
                        Nama = txtNama.Text,
                        Harga = Double.Parse(txtHarga.Text),
                        Pajak = Int32.Parse(txtPajak.Text)
                    });
                }
                MessageBox.Show("Penambahan Barang Berhasil", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
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
    }
}
