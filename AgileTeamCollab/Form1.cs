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
        public Form1()
        {
            InitializeComponent();
            dgv1.AutoGenerateColumns = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(null,null);
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
    }
}
