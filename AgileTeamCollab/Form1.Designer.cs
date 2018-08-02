namespace AgileTeamCollab
{
    partial class Form1
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPajak = new System.Windows.Forms.Label();
            this.txtPajakAkhir = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJlhBrg = new System.Windows.Forms.Label();
            this.btnDelListBelanja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kd_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(693, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(600, 500);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 28);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "%";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(597, 437);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(664, 434);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 20;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(600, 464);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(116, 28);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaBarang,
            this.HargaBarang,
            this.QtyBarang});
            this.dgv2.Location = new System.Drawing.Point(17, 346);
            this.dgv2.Margin = new System.Windows.Forms.Padding(4);
            this.dgv2.MultiSelect = false;
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(549, 258);
            this.dgv2.TabIndex = 19;
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "Nama";
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            // 
            // HargaBarang
            // 
            this.HargaBarang.HeaderText = "Harga/pcs";
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.ReadOnly = true;
            // 
            // QtyBarang
            // 
            this.QtyBarang.HeaderText = "Qty";
            this.QtyBarang.Name = "QtyBarang";
            this.QtyBarang.ReadOnly = true;
            // 
            // lblPajak
            // 
            this.lblPajak.AutoSize = true;
            this.lblPajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPajak.Location = new System.Drawing.Point(597, 405);
            this.lblPajak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPajak.Name = "lblPajak";
            this.lblPajak.Size = new System.Drawing.Size(58, 17);
            this.lblPajak.TabIndex = 18;
            this.lblPajak.Text = "Pajak :";
            // 
            // txtPajakAkhir
            // 
            this.txtPajakAkhir.Location = new System.Drawing.Point(664, 402);
            this.txtPajakAkhir.Margin = new System.Windows.Forms.Padding(4);
            this.txtPajakAkhir.Name = "txtPajakAkhir";
            this.txtPajakAkhir.Size = new System.Drawing.Size(52, 22);
            this.txtPajakAkhir.TabIndex = 17;
            this.txtPajakAkhir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPajakAkhir_KeyPress);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kd_barang,
            this.Nama,
            this.Harga,
            this.Pajak});
            this.dgv1.Location = new System.Drawing.Point(18, 40);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(775, 233);
            this.dgv1.TabIndex = 16;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(171, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 28);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Daftar Belanja :";
            // 
            // lblJlhBrg
            // 
            this.lblJlhBrg.AutoSize = true;
            this.lblJlhBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJlhBrg.Location = new System.Drawing.Point(434, 325);
            this.lblJlhBrg.Name = "lblJlhBrg";
            this.lblJlhBrg.Size = new System.Drawing.Size(115, 17);
            this.lblJlhBrg.TabIndex = 27;
            this.lblJlhBrg.Text = "Jumlah Barang : ";
            // 
            // btnDelListBelanja
            // 
            this.btnDelListBelanja.Location = new System.Drawing.Point(600, 536);
            this.btnDelListBelanja.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelListBelanja.Name = "btnDelListBelanja";
            this.btnDelListBelanja.Size = new System.Drawing.Size(115, 28);
            this.btnDelListBelanja.TabIndex = 28;
            this.btnDelListBelanja.Text = "Delete Row";
            this.btnDelListBelanja.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "NB : Click pada kolom KodeBarang untuk manipulasi data (Add/Edit/Delete).";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "        Double Click pada kolom KodeBarang untuk menambah daftar belanja.";
            // 
            // kd_barang
            // 
            this.kd_barang.HeaderText = "KodeBarang";
            this.kd_barang.Name = "kd_barang";
            this.kd_barang.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // Pajak
            // 
            this.Pajak.HeaderText = "Pajak (%)";
            this.Pajak.Name = "Pajak";
            this.Pajak.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelListBelanja);
            this.Controls.Add(this.lblJlhBrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.lblPajak);
            this.Controls.Add(this.txtPajakAkhir);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTampilan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label lblPajak;
        private System.Windows.Forms.TextBox txtPajakAkhir;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJlhBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyBarang;
        private System.Windows.Forms.Button btnDelListBelanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn kd_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pajak;
    }
}

