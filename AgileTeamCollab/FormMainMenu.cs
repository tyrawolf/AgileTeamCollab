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
    public partial class FormMainMenu : Form
    {
        List<Barang> listBrg = null;
        List<Belanja> listBelanja = null;
        public FormMainMenu()
        {
            InitializeComponent();
            dgv1.AutoGenerateColumns = false;
            dgv2.AutoGenerateColumns = false;
            dgv1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgv2.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgv1.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv1.Columns["Pajak"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv2.Columns["HargaBarang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv2.Columns["HargaBarang"].DefaultCellStyle.Format = "n0";
            dgv1.Columns["Harga"].DefaultCellStyle.Format = "n0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSearch.Clear();
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
            this.dgv1.Columns[2].Width = 24 * this.dgv1.Width / 100;
            this.dgv1.Columns[3].Width = 20 * this.dgv1.Width / 100;

            this.dgv2.Columns[0].Width = 30 * this.dgv1.Width / 100;
            this.dgv2.Columns[1].Width = 24 * this.dgv1.Width / 100;
            this.dgv2.Columns[2].Width = 10 * this.dgv1.Width / 100;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAdd().ShowDialog();
            this.Form1_Load(null, null);
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

                            var c = listBelanja.Find(i => i.KodeBarang == dgv1.CurrentRow.Cells[0].Value.ToString());
                            if (c != null)
                            {
                                c.Quantity += qty;
                                dgv2.DataSource = listBelanja;
                            }
                            else
                            {
                                listBelanja.Add(new Belanja { KodeBarang = item.Kode, Nama = item.Nama, Harga = item.Harga + (item.Harga * (double)item.Pajak / 100), Quantity = qty });
                                dgv2.DataSource = listBelanja;
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtPajakAkhir.Text.Trim() != "")
                {
                    double TotalHarga = 0;
                    foreach (DataGridViewRow item in dgv2.Rows)
                    {
                        TotalHarga += (Double.Parse(item.Cells[1].Value.ToString()) * Double.Parse(item.Cells[2].Value.ToString()));
                    }

                    //tTotalHarga = TotalHarga + (TotalHarga * Double.Parse(txtPajakAkhir.Text) / 100);

                    txtTotal.Text = TotalHarga.ToString("n0");
                }
                //else
                //{
                //    MessageBox.Show("Tolong input pajak akhir !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

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
                Form1_Load(null,null);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgv1.DataSource = null;
                if (txtSearch.Text.ToLower().Trim() != "")
                {
                    List<Barang> listFilter = new List<Barang>();
                    foreach (var item in listBrg)
                    {
                        if (txtSearch.Text.ToLower().Trim() == item.Nama.ToLower() || item.Nama.ToLower().Contains(txtSearch.Text.ToLower().Trim()))
                        {
                            listFilter.Add(item);
                        }
                    }
                    dgv1.DataSource = listFilter;
                }
                else
                {
                    dgv1.DataSource = listBrg;
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnDelListBelanja_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBelanja.Count != 0)
                {

                    string n = dgv2.CurrentRow.Cells[0].Value.ToString();
                    double hrg = Double.Parse(dgv2.CurrentRow.Cells[1].Value.ToString());
                    int qty = Int32.Parse(dgv2.CurrentRow.Cells[2].Value.ToString());

                    
                    var c = listBelanja.Find(i => i.Nama == n && i.Harga == hrg && i.Quantity == qty);
                    if (c != null)
                    {
                        listBelanja.Remove(c);
                    }
                }
                dgv2.DataSource = null;
                dgv2.DataSource = listBelanja;
                int total = 0;
                foreach (DataGridViewRow item in dgv2.Rows)
                {
                    total += Int32.Parse(item.Cells[2].Value.ToString());
                }
                lblJlhBrg.Text = "Jumlah Barang : " + total.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FrmAkhirBelanjaan(listBelanja).ShowDialog();
                this.Form1_Load(null,null);
                this.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
