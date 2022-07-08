
namespace tugas_akhir_pv
{
    partial class Pekerjaan
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
        	this.label4 = new System.Windows.Forms.Label();
        	this.btnBersihkan = new System.Windows.Forms.Button();
        	this.btnHapus = new System.Windows.Forms.Button();
        	this.btnEdit = new System.Windows.Forms.Button();
        	this.btnSimpan = new System.Windows.Forms.Button();
        	this.label8 = new System.Windows.Forms.Label();
        	this.txtCariBarang = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtIdPekerjaan = new System.Windows.Forms.TextBox();
        	this.txtNamaPekerjaan = new System.Windows.Forms.TextBox();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(76, 102);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(140, 16);
        	this.label4.TabIndex = 72;
        	this.label4.Text = "NAMA PEKERJAAN : ";
        	// 
        	// btnBersihkan
        	// 
        	this.btnBersihkan.BackColor = System.Drawing.Color.MediumSlateBlue;
        	this.btnBersihkan.Location = new System.Drawing.Point(573, 150);
        	this.btnBersihkan.Name = "btnBersihkan";
        	this.btnBersihkan.Size = new System.Drawing.Size(75, 29);
        	this.btnBersihkan.TabIndex = 71;
        	this.btnBersihkan.Text = "Bersihkan";
        	this.btnBersihkan.UseVisualStyleBackColor = false;
        	this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
        	// 
        	// btnHapus
        	// 
        	this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
        	this.btnHapus.Enabled = false;
        	this.btnHapus.Location = new System.Drawing.Point(429, 150);
        	this.btnHapus.Name = "btnHapus";
        	this.btnHapus.Size = new System.Drawing.Size(82, 29);
        	this.btnHapus.TabIndex = 70;
        	this.btnHapus.Text = "Hapus";
        	this.btnHapus.UseVisualStyleBackColor = false;
        	this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
        	// 
        	// btnEdit
        	// 
        	this.btnEdit.BackColor = System.Drawing.Color.Gold;
        	this.btnEdit.Enabled = false;
        	this.btnEdit.Location = new System.Drawing.Point(278, 150);
        	this.btnEdit.Name = "btnEdit";
        	this.btnEdit.Size = new System.Drawing.Size(82, 29);
        	this.btnEdit.TabIndex = 69;
        	this.btnEdit.Text = "Edit";
        	this.btnEdit.UseVisualStyleBackColor = false;
        	this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
        	// 
        	// btnSimpan
        	// 
        	this.btnSimpan.BackColor = System.Drawing.Color.SpringGreen;
        	this.btnSimpan.Location = new System.Drawing.Point(141, 150);
        	this.btnSimpan.Name = "btnSimpan";
        	this.btnSimpan.Size = new System.Drawing.Size(82, 29);
        	this.btnSimpan.TabIndex = 68;
        	this.btnSimpan.Text = "Simpan";
        	this.btnSimpan.UseVisualStyleBackColor = false;
        	this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
        	// 
        	// label8
        	// 
        	this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label8.Location = new System.Drawing.Point(479, 247);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(97, 29);
        	this.label8.TabIndex = 67;
        	this.label8.Text = "Cari Pekerjaan :";
        	this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// txtCariBarang
        	// 
        	this.txtCariBarang.BackColor = System.Drawing.Color.White;
        	this.txtCariBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtCariBarang.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtCariBarang.ForeColor = System.Drawing.Color.Black;
        	this.txtCariBarang.Location = new System.Drawing.Point(582, 253);
        	this.txtCariBarang.Name = "txtCariBarang";
        	this.txtCariBarang.Size = new System.Drawing.Size(188, 21);
        	this.txtCariBarang.TabIndex = 66;
        	this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(19, 247);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(253, 29);
        	this.label3.TabIndex = 65;
        	this.label3.Text = "DB : Cleanx, Table : Jenis_Pekerjaan";
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
        	this.dataGridView1.Location = new System.Drawing.Point(19, 284);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(751, 163);
        	this.dataGridView1.TabIndex = 64;
        	this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(63, 55);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(153, 16);
        	this.label1.TabIndex = 63;
        	this.label1.Text = "ID JENIS PEKERJAAN: ";
        	// 
        	// txtIdPekerjaan
        	// 
        	this.txtIdPekerjaan.BackColor = System.Drawing.SystemColors.Window;
        	this.txtIdPekerjaan.Location = new System.Drawing.Point(222, 55);
        	this.txtIdPekerjaan.Name = "txtIdPekerjaan";
        	this.txtIdPekerjaan.Size = new System.Drawing.Size(503, 20);
        	this.txtIdPekerjaan.TabIndex = 62;
        	// 
        	// txtNamaPekerjaan
        	// 
        	this.txtNamaPekerjaan.BackColor = System.Drawing.SystemColors.Window;
        	this.txtNamaPekerjaan.Location = new System.Drawing.Point(222, 101);
        	this.txtNamaPekerjaan.Name = "txtNamaPekerjaan";
        	this.txtNamaPekerjaan.Size = new System.Drawing.Size(503, 20);
        	this.txtNamaPekerjaan.TabIndex = 73;
        	// 
        	// Pekerjaan
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(788, 503);
        	this.Controls.Add(this.txtNamaPekerjaan);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.btnBersihkan);
        	this.Controls.Add(this.btnHapus);
        	this.Controls.Add(this.btnEdit);
        	this.Controls.Add(this.btnSimpan);
        	this.Controls.Add(this.label8);
        	this.Controls.Add(this.txtCariBarang);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtIdPekerjaan);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "Pekerjaan";
        	this.Text = "Pekerjaan";
        	this.Load += new System.EventHandler(this.Pekerjaan_Load);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCariBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPekerjaan;
        private System.Windows.Forms.TextBox txtNamaPekerjaan;
    }
}