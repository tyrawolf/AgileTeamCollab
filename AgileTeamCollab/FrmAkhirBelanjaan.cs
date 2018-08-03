using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileTeamCollab
{
    public partial class FrmAkhirBelanjaan : Form
    {
        List<Belanja> listBelanja = null;

        public FrmAkhirBelanjaan(List<Belanja> listImport)
        {
            InitializeComponent();
            listBelanja = listImport;
        }

        private void FrmAkhirBelanjaan_Load(object sender, EventArgs e)
        {
            double total = 0;
            try
            {
                
                foreach (var item in listBelanja)
                {
                    ListViewItem lv = new ListViewItem(item.Quantity.ToString());
                    lv.SubItems.Add(item.Nama);
                    lv.SubItems.Add(((double)item.Harga * item.Quantity).ToString());
                    listView1.Items.Add(lv);
                    total += item.Quantity * item.Harga;
                }
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            lblTotal.Text = "Total Harga Belanja = Rp. " + total.ToString("n0") + ",-";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
