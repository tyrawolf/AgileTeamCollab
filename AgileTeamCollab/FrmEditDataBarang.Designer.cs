namespace AgileTeamCollab
{
    partial class FrmEditDataBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblKd_Brg = new System.Windows.Forms.Label();
            this.txtPajak = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblPajak = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(200, 203);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 28);
            this.btnBatal.TabIndex = 20;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(92, 203);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 28);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(161, 21);
            this.txtKode.Margin = new System.Windows.Forms.Padding(4);
            this.txtKode.Name = "txtKode";
            this.txtKode.ReadOnly = true;
            this.txtKode.Size = new System.Drawing.Size(132, 22);
            this.txtKode.TabIndex = 15;
            // 
            // lblKd_Brg
            // 
            this.lblKd_Brg.AutoSize = true;
            this.lblKd_Brg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKd_Brg.Location = new System.Drawing.Point(24, 21);
            this.lblKd_Brg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKd_Brg.Name = "lblKd_Brg";
            this.lblKd_Brg.Size = new System.Drawing.Size(106, 20);
            this.lblKd_Brg.TabIndex = 24;
            this.lblKd_Brg.Text = "Kode Barang";
            // 
            // txtPajak
            // 
            this.txtPajak.Location = new System.Drawing.Point(161, 139);
            this.txtPajak.Margin = new System.Windows.Forms.Padding(4);
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.Size = new System.Drawing.Size(132, 22);
            this.txtPajak.TabIndex = 18;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(161, 97);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(132, 22);
            this.txtHarga.TabIndex = 17;
            this.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPajak
            // 
            this.lblPajak.AutoSize = true;
            this.lblPajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPajak.Location = new System.Drawing.Point(24, 141);
            this.lblPajak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPajak.Name = "lblPajak";
            this.lblPajak.Size = new System.Drawing.Size(50, 20);
            this.lblPajak.TabIndex = 23;
            this.lblPajak.Text = "Pajak";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(24, 97);
            this.lblHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(55, 20);
            this.lblHarga.TabIndex = 22;
            this.lblHarga.Text = "Harga";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(161, 57);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(132, 22);
            this.txtNama.TabIndex = 16;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(24, 57);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(58, 20);
            this.lblNama.TabIndex = 21;
            this.lblNama.Text = "Nama ";
            // 
            // FrmEditDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 264);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblKd_Brg);
            this.Controls.Add(this.txtPajak);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblPajak);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Name = "FrmEditDataBarang";
            this.Text = "FrmEditDataBarang";
            this.Load += new System.EventHandler(this.FrmEditDataBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblKd_Brg;
        private System.Windows.Forms.TextBox txtPajak;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblPajak;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
    }
}