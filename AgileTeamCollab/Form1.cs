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
    public partial class Form1 : Form
    {
        List<Barang> listBrg = null;
        List<Belanja> listBelanja = null;
        public Form1()
        {
            InitializeComponent();
            dgv1.AutoGenerateColumns = false;
            dgv2.AutoGenerateColumns = false;
            dgv1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgv2.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBelanja = new List<Belanja>();
            Form1_Resize(null, null);
            try
            {
                using (var barangdao = new BarangDAO())
                {
                    listBrg = barangdao.GetAllDataBarang();
                }

                dgv1.DataSource = listBrg;
                dgv1.Columns[0].DataPropertyName = "Kode";
                dgv1.Columns[1].DataPropertyName = "Nama";
                dgv1.Columns[2].DataPropertyName = "Harga";
                dgv1.Columns[3].DataPropertyName = "Pajak";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            this.dgv1.Columns[0].Width = 20 * this.dgv1.Width / 100;
            this.dgv1.Columns[1].Width = 30 * this.dgv1.Width / 100;
            this.dgv1.Columns[2].Width = 25 * this.dgv1.Width / 100;
            this.dgv1.Columns[3].Width = 25 * this.dgv1.Width / 100;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAdd().ShowDialog();
            this.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void txtPajakAkhir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPajakAkhir.Text.Trim() != "")
                {
                    double TotalHarga = 0;
                    foreach (DataGridViewRow item in dgv2.Rows)
                    {
                        TotalHarga += (Double.Parse(item.Cells[1].Value.ToString()) * Double.Parse(item.Cells[2].Value.ToString()));
                    }

                    TotalHarga = TotalHarga + (TotalHarga * Double.Parse(txtPajakAkhir.Text) / 100);

                    txtTotal.Text = TotalHarga.ToString("n0");
                }
                else
                {
                    MessageBox.Show("Tolong input pajak akhir !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                dgv2.DataSource = null;
                lblJlhBrg.Text = "Jumlah Barang : 0";
                txtPajakAkhir.Clear();
                txtTotal.Clear();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var barangdao = new BarangDAO())
                {
                    barangdao.Delete(dgv1.CurrentCell.Value.ToString());
                }
                MessageBox.Show("Barang berhasil dihapus!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                btnRefresh_Click(null, null);
            }
        }

        private void dgv1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            dgv2.Columns[0].DataPropertyName = "Nama";
            dgv2.Columns[1].DataPropertyName = "Harga";
            dgv2.Columns[2].DataPropertyName = "Quantity";


            foreach (var item in listBrg)
            {
                if (item.Kode == dgv1.CurrentCell.Value.ToString())
                {
                    int qty = new FrmQuantity().Run();
                    if (qty != 0)
                    {
                        dgv2.DataSource = null;
                        if (listBelanja.Count != 0)
                        {
                            foreach (var blnja in listBelanja)
                            {
                                if (blnja.KodeBarang == dgv1.CurrentRow.Cells[0].Value.ToString())
                                {
                                    blnja.Quantity += qty;
                                    dgv2.DataSource = listBelanja;
                                    break;
                                }
                                else
                                {
                                    listBelanja.Add(new Belanja { KodeBarang = item.Kode, Nama = item.Nama, Harga = item.Harga + (item.Harga * (double)item.Pajak / 100), Quantity = qty });
                                    dgv2.DataSource = listBelanja;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            listBelanja.Add(new Belanja { KodeBarang = item.Kode, Nama = item.Nama, Harga = item.Harga + (item.Harga * (double)item.Pajak / 100), Quantity = qty });
                            dgv2.DataSource = listBelanja;
                        }
                    }
                }
            }


            foreach (DataGridViewRow item in dgv2.Rows)
            {
                total += Int32.Parse(item.Cells[2].Value.ToString());
            }
            lblJlhBrg.Text = "Jumlah Barang : " + total.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dgv1.SelectedRows.Count > 0)
                {
                    FrmEditDataBarang form = new FrmEditDataBarang(this.dgv1.CurrentRow.Cells[0].Value.ToString().Trim());
                    if (form.Run(form))
                    {
                        Form1_Load(null,null);
                    }
                }
                
            }
            catch (Exception ex)
            {
                
                throw ex;   
            }
                
            
        }
    }
}
