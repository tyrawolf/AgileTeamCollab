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
    public partial class FrmQuantity : Form
    {
        int qty = 0;

        public FrmQuantity()
        {
            InitializeComponent();
        }

        public int Run() {
            this.ShowDialog();
            return qty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Tolong isi kuantitasnya", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if  (Int32.Parse(txtQty.Text) < 0)
            {
                MessageBox.Show("Tidak boleh minus", this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                qty = Int32.Parse(txtQty.Text);
                this.Close();
            }
            
            
        }
    }
}
