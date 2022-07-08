
namespace tugas_akhir_pv
{
    partial class Karyawan
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
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtNama = new System.Windows.Forms.TextBox();
        	this.txtIdKaryawan = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.txtAlamat = new System.Windows.Forms.TextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.txtNoHp = new System.Windows.Forms.TextBox();
        	this.dateTanggalLahir = new System.Windows.Forms.DateTimePicker();
        	this.cmbJenisPekerjaan = new System.Windows.Forms.ComboBox();
        	this.txtTempatLahir = new System.Windows.Forms.TextBox();
        	this.label9 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(84, 121);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(127, 16);
        	this.label4.TabIndex = 84;
        	this.label4.Text = "TANGGAL LAHIR : ";
        	// 
        	// btnBersihkan
        	// 
        	this.btnBersihkan.BackColor = System.Drawing.Color.MediumSlateBlue;
        	this.btnBersihkan.Location = new System.Drawing.Point(579, 264);
        	this.btnBersihkan.Name = "btnBersihkan";
        	this.btnBersihkan.Size = new System.Drawing.Size(75, 29);
        	this.btnBersihkan.TabIndex = 82;
        	this.btnBersihkan.Text = "Bersihkan";
        	this.btnBersihkan.UseVisualStyleBackColor = false;
        	this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
        	// 
        	// btnHapus
        	// 
        	this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
        	this.btnHapus.Enabled = false;
        	this.btnHapus.Location = new System.Drawing.Point(436, 264);
        	this.btnHapus.Name = "btnHapus";
        	this.btnHapus.Size = new System.Drawing.Size(75, 29);
        	this.btnHapus.TabIndex = 81;
        	this.btnHapus.Text = "Hapus";
        	this.btnHapus.UseVisualStyleBackColor = false;
        	this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
        	// 
        	// btnEdit
        	// 
        	this.btnEdit.BackColor = System.Drawing.Color.Gold;
        	this.btnEdit.Enabled = false;
        	this.btnEdit.Location = new System.Drawing.Point(293, 264);
        	this.btnEdit.Name = "btnEdit";
        	this.btnEdit.Size = new System.Drawing.Size(75, 29);
        	this.btnEdit.TabIndex = 80;
        	this.btnEdit.Text = "Edit";
        	this.btnEdit.UseVisualStyleBackColor = false;
        	this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
        	// 
        	// btnSimpan
        	// 
        	this.btnSimpan.BackColor = System.Drawing.Color.SpringGreen;
        	this.btnSimpan.Location = new System.Drawing.Point(150, 264);
        	this.btnSimpan.Name = "btnSimpan";
        	this.btnSimpan.Size = new System.Drawing.Size(75, 29);
        	this.btnSimpan.TabIndex = 79;
        	this.btnSimpan.Text = "Simpan";
        	this.btnSimpan.UseVisualStyleBackColor = false;
        	this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
        	// 
        	// label8
        	// 
        	this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label8.Location = new System.Drawing.Point(483, 325);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(101, 29);
        	this.label8.TabIndex = 78;
        	this.label8.Text = "Cari Karyawan :";
        	this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// txtCariBarang
        	// 
        	this.txtCariBarang.BackColor = System.Drawing.Color.White;
        	this.txtCariBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtCariBarang.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtCariBarang.ForeColor = System.Drawing.Color.Black;
        	this.txtCariBarang.Location = new System.Drawing.Point(590, 331);
        	this.txtCariBarang.Name = "txtCariBarang";
        	this.txtCariBarang.Size = new System.Drawing.Size(188, 21);
        	this.txtCariBarang.TabIndex = 77;
        	this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(27, 325);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(253, 29);
        	this.label3.TabIndex = 76;
        	this.label3.Text = "DB : Cleanx, Table : Karyawan";
        	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
        	dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        	dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        	this.dataGridView1.Location = new System.Drawing.Point(27, 362);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(751, 163);
        	this.dataGridView1.TabIndex = 75;
        	this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(144, 53);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(67, 16);
        	this.label2.TabIndex = 74;
        	this.label2.Text = "NAMA  : ";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(95, 19);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(116, 16);
        	this.label1.TabIndex = 73;
        	this.label1.Text = "ID KARYAWAN : ";
        	// 
        	// txtNama
        	// 
        	this.txtNama.Location = new System.Drawing.Point(217, 52);
        	this.txtNama.Name = "txtNama";
        	this.txtNama.Size = new System.Drawing.Size(503, 20);
        	this.txtNama.TabIndex = 72;
        	// 
        	// txtIdKaryawan
        	// 
        	this.txtIdKaryawan.BackColor = System.Drawing.SystemColors.Window;
        	this.txtIdKaryawan.Location = new System.Drawing.Point(217, 18);
        	this.txtIdKaryawan.Name = "txtIdKaryawan";
        	this.txtIdKaryawan.Size = new System.Drawing.Size(503, 20);
        	this.txtIdKaryawan.TabIndex = 71;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(134, 223);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(77, 16);
        	this.label5.TabIndex = 90;
        	this.label5.Text = "ALAMAT : ";
        	// 
        	// txtAlamat
        	// 
        	this.txtAlamat.BackColor = System.Drawing.SystemColors.Window;
        	this.txtAlamat.Location = new System.Drawing.Point(217, 223);
        	this.txtAlamat.Name = "txtAlamat";
        	this.txtAlamat.Size = new System.Drawing.Size(503, 20);
        	this.txtAlamat.TabIndex = 89;
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.Location = new System.Drawing.Point(141, 189);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(70, 16);
        	this.label6.TabIndex = 88;
        	this.label6.Text = "NO HP  : ";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.Location = new System.Drawing.Point(72, 155);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(139, 16);
        	this.label7.TabIndex = 87;
        	this.label7.Text = "JENIS PEKERJAAN : ";
        	// 
        	// txtNoHp
        	// 
        	this.txtNoHp.Location = new System.Drawing.Point(217, 189);
        	this.txtNoHp.Name = "txtNoHp";
        	this.txtNoHp.Size = new System.Drawing.Size(503, 20);
        	this.txtNoHp.TabIndex = 86;
        	// 
        	// dateTanggalLahir
        	// 
        	this.dateTanggalLahir.CustomFormat = "yyyy-MM-dd";
        	this.dateTanggalLahir.Location = new System.Drawing.Point(218, 120);
        	this.dateTanggalLahir.Name = "dateTanggalLahir";
        	this.dateTanggalLahir.Size = new System.Drawing.Size(503, 20);
        	this.dateTanggalLahir.TabIndex = 91;
        	// 
        	// cmbJenisPekerjaan
        	// 
        	this.cmbJenisPekerjaan.DisplayMember = "SATU";
        	this.cmbJenisPekerjaan.FormattingEnabled = true;
        	this.cmbJenisPekerjaan.Items.AddRange(new object[] {
        	        	        	"SATU",
        	        	        	"DUA",
        	        	        	"TIGA"});
        	this.cmbJenisPekerjaan.Location = new System.Drawing.Point(218, 154);
        	this.cmbJenisPekerjaan.Name = "cmbJenisPekerjaan";
        	this.cmbJenisPekerjaan.Size = new System.Drawing.Size(503, 21);
        	this.cmbJenisPekerjaan.TabIndex = 92;
        	// 
        	// txtTempatLahir
        	// 
        	this.txtTempatLahir.Location = new System.Drawing.Point(218, 86);
        	this.txtTempatLahir.Name = "txtTempatLahir";
        	this.txtTempatLahir.Size = new System.Drawing.Size(503, 20);
        	this.txtTempatLahir.TabIndex = 93;
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label9.Location = new System.Drawing.Point(91, 87);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(120, 16);
        	this.label9.TabIndex = 94;
        	this.label9.Text = "TEMPAT LAHIR : ";
        	// 
        	// Karyawan
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(804, 542);
        	this.Controls.Add(this.label9);
        	this.Controls.Add(this.txtTempatLahir);
        	this.Controls.Add(this.cmbJenisPekerjaan);
        	this.Controls.Add(this.dateTanggalLahir);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.txtAlamat);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.txtNoHp);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.btnBersihkan);
        	this.Controls.Add(this.btnHapus);
        	this.Controls.Add(this.btnEdit);
        	this.Controls.Add(this.btnSimpan);
        	this.Controls.Add(this.label8);
        	this.Controls.Add(this.txtCariBarang);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtNama);
        	this.Controls.Add(this.txtIdKaryawan);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "Karyawan";
        	this.Text = "Karyawan";
        	this.Load += new System.EventHandler(this.Karyawan_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtIdKaryawan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.DateTimePicker dateTanggalLahir;
        private System.Windows.Forms.ComboBox cmbJenisPekerjaan;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.Label label9;
    }
}