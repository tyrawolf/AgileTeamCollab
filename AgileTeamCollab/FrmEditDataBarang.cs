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
    public partial class FrmEditDataBarang : Form
    {
        bool _result = false;
        string _kode = string.Empty;
        public bool Run(FrmEditDataBarang form)
        {

            form.ShowDialog();
            return _result;
        }
        public FrmEditDataBarang(string Kode)
        {
            InitializeComponent();
            _kode = Kode;

        }

        private void FrmEditDataBarang_Load(object sender, EventArgs e)
        {
            Barang barang = new BarangDAO().GetDataBarangByKode(_kode);
            if (barang != null)
            {
                this.txtKode.Text = barang.Kode;
                this.txtNama.Text = barang.Nama;
                this.txtHarga.Text = barang.Harga.ToString();
                this.txtPajak.Text = barang.Pajak.ToString();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (this.txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Nama tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNama.Focus();
            }
            else if (this.txtHarga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Harga kuliah tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHarga.Focus();
            }
            else if (this.txtPajak.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Satuan tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPajak.Focus();
            }
            else if (Int32.Parse(this.txtPajak.Text.Trim()) < 0)
            {
                MessageBox.Show("Sorry, data Stok tidak boleh Minus ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPajak.Focus();
            }
            else if (Double.Parse(this.txtHarga.Text.Trim()) < 0)
            {
                MessageBox.Show("Sorry, data Harga tidak boleh Minus ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHarga.Focus();
            }
            else
            {
                try
                {
                    Barang barang = new Barang
                    {
                        Kode = this.txtKode.Text.Trim(),
                        Nama = this.txtNama.Text.Trim(),
                        Harga = Double.Parse(this.txtHarga.Text.Trim()),
                        Pajak = Double.Parse(this.txtPajak.Text.Trim())
                    };
                    _result = new BarangDAO().Update(barang) > 0;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
