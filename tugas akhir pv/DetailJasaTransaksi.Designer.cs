
namespace tugas_akhir_pv
{
    partial class DetailJasaTransaksi
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
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        	this.cmbJenisJasa = new System.Windows.Forms.ComboBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.btnBersihkan = new System.Windows.Forms.Button();
        	this.btnHapus = new System.Windows.Forms.Button();
        	this.btnEdit = new System.Windows.Forms.Button();
        	this.btnSimpan = new System.Windows.Forms.Button();
        	this.label3 = new System.Windows.Forms.Label();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtIdTransaksi = new System.Windows.Forms.TextBox();
        	this.btnCari = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// cmbJenisJasa
        	// 
        	this.cmbJenisJasa.FormattingEnabled = true;
        	this.cmbJenisJasa.Location = new System.Drawing.Point(178, 121);
        	this.cmbJenisJasa.Name = "cmbJenisJasa";
        	this.cmbJenisJasa.Size = new System.Drawing.Size(503, 21);
        	this.cmbJenisJasa.TabIndex = 61;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(73, 122);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(99, 16);
        	this.label4.TabIndex = 60;
        	this.label4.Text = "JENIS JASA : ";
        	// 
        	// btnBersihkan
        	// 
        	this.btnBersihkan.BackColor = System.Drawing.Color.MediumSlateBlue;
        	this.btnBersihkan.Location = new System.Drawing.Point(581, 170);
        	this.btnBersihkan.Name = "btnBersihkan";
        	this.btnBersihkan.Size = new System.Drawing.Size(75, 29);
        	this.btnBersihkan.TabIndex = 59;
        	this.btnBersihkan.Text = "Bersihkan";
        	this.btnBersihkan.UseVisualStyleBackColor = false;
        	this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
        	// 
        	// btnHapus
        	// 
        	this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
        	this.btnHapus.Enabled = false;
        	this.btnHapus.Location = new System.Drawing.Point(437, 170);
        	this.btnHapus.Name = "btnHapus";
        	this.btnHapus.Size = new System.Drawing.Size(82, 29);
        	this.btnHapus.TabIndex = 58;
        	this.btnHapus.Text = "Hapus";
        	this.btnHapus.UseVisualStyleBackColor = false;
        	this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
        	// 
        	// btnEdit
        	// 
        	this.btnEdit.BackColor = System.Drawing.Color.Gold;
        	this.btnEdit.Enabled = false;
        	this.btnEdit.Location = new System.Drawing.Point(286, 170);
        	this.btnEdit.Name = "btnEdit";
        	this.btnEdit.Size = new System.Drawing.Size(82, 29);
        	this.btnEdit.TabIndex = 57;
        	this.btnEdit.Text = "Edit";
        	this.btnEdit.UseVisualStyleBackColor = false;
        	this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
        	// 
        	// btnSimpan
        	// 
        	this.btnSimpan.BackColor = System.Drawing.Color.SpringGreen;
        	this.btnSimpan.Location = new System.Drawing.Point(149, 170);
        	this.btnSimpan.Name = "btnSimpan";
        	this.btnSimpan.Size = new System.Drawing.Size(82, 29);
        	this.btnSimpan.TabIndex = 56;
        	this.btnSimpan.Text = "Simpan";
        	this.btnSimpan.UseVisualStyleBackColor = false;
        	this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(27, 267);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(253, 29);
        	this.label3.TabIndex = 53;
        	this.label3.Text = "DB : Cleanx, Table : Detail_Harga_Jasa";
        	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
        	dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        	dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        	dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
        	dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        	dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        	dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        	this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
        	this.dataGridView1.Location = new System.Drawing.Point(27, 304);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(751, 163);
        	this.dataGridView1.TabIndex = 52;
        	this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(54, 81);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(118, 16);
        	this.label1.TabIndex = 51;
        	this.label1.Text = "ID TRANSAKSI : ";
        	// 
        	// txtIdTransaksi
        	// 
        	this.txtIdTransaksi.BackColor = System.Drawing.SystemColors.Window;
        	this.txtIdTransaksi.Location = new System.Drawing.Point(178, 80);
        	this.txtIdTransaksi.Name = "txtIdTransaksi";
        	this.txtIdTransaksi.Size = new System.Drawing.Size(406, 20);
        	this.txtIdTransaksi.TabIndex = 50;
        	// 
        	// btnCari
        	// 
        	this.btnCari.Location = new System.Drawing.Point(606, 78);
        	this.btnCari.Name = "btnCari";
        	this.btnCari.Size = new System.Drawing.Size(75, 23);
        	this.btnCari.TabIndex = 62;
        	this.btnCari.Text = "Cari";
        	this.btnCari.UseVisualStyleBackColor = true;
        	this.btnCari.Click += new System.EventHandler(this.BtnCariClick);
        	// 
        	// DetailJasaTransaksi
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(804, 542);
        	this.Controls.Add(this.btnCari);
        	this.Controls.Add(this.cmbJenisJasa);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.btnBersihkan);
        	this.Controls.Add(this.btnHapus);
        	this.Controls.Add(this.btnEdit);
        	this.Controls.Add(this.btnSimpan);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtIdTransaksi);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "DetailJasaTransaksi";
        	this.Text = "DetailJasaTransaksi";
        	this.Load += new System.EventHandler(this.DetailJasaTransaksi_Load);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button btnCari;

        #endregion
        private System.Windows.Forms.ComboBox cmbJenisJasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdTransaksi;
    }
}