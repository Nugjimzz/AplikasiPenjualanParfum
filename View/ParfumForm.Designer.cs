namespace AplikasiPenjualanParfum.View
{
    partial class ParfumForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvParfum;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvParfum = new System.Windows.Forms.DataGridView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParfum)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvParfum
            // 
            this.dgvParfum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParfum.Location = new System.Drawing.Point(12, 12);
            this.dgvParfum.Name = "dgvParfum";
            this.dgvParfum.Size = new System.Drawing.Size(500, 250);
            this.dgvParfum.TabIndex = 0;
            this.dgvParfum.SelectionChanged += new System.EventHandler(this.dgvParfum_SelectionChanged);

            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(12, 275);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(150, 20);
            this.txtNama.TabIndex = 1;

            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(168, 275);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 2;

            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(274, 275);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(50, 20);
            this.txtStok.TabIndex = 3;

            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(330, 273);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(411, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(492, 273);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nama Parfum :";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Harga :";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stok :";

            // 
            // ParfumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.dgvParfum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParfumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Data Parfum";
            this.Load += new System.EventHandler(this.ParfumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParfum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}