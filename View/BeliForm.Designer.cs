using System.Windows.Forms;

namespace AplikasiPenjualanParfum.View
{
    partial class BeliForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbParfum;
        private System.Windows.Forms.NumericUpDown numJumlah;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbParfum = new System.Windows.Forms.ComboBox();
            this.numJumlah = new System.Windows.Forms.NumericUpDown();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.SuspendLayout();

            // 
            // cmbParfum
            // 
            this.cmbParfum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParfum.FormattingEnabled = true;
            this.cmbParfum.Location = new System.Drawing.Point(100, 20);
            this.cmbParfum.Name = "cmbParfum";
            this.cmbParfum.Size = new System.Drawing.Size(200, 21);
            this.cmbParfum.TabIndex = 0;

            // 
            // numJumlah
            // 
            this.numJumlah.Location = new System.Drawing.Point(100, 50);
            this.numJumlah.Minimum = 1;
            this.numJumlah.Maximum = 100;
            this.numJumlah.Value = 1;
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(60, 20);
            this.numJumlah.TabIndex = 1;

            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(12, 80);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.Size = new System.Drawing.Size(500, 200);
            this.dgvKeranjang.TabIndex = 2;

            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(310, 18);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(310, 50);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(430, 290);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(75, 23);
            this.btnBeli.TabIndex = 5;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pilih Parfum :";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jumlah :";

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(390, 295);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 8;

            // 
            // BeliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.numJumlah);
            this.Controls.Add(this.cmbParfum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BeliForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Beli Parfum";
            this.Load += new System.EventHandler(this.BeliForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}