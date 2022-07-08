/*
 * Created by SharpDevelop.
 * User: User
 * Date: 03/06/2022
 * Time: 8:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas_akhir_pv
{
	partial class Laporan
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCari = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdTransaksi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTanggal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtHarga = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.listJasa = new System.Windows.Forms.ListBox();
			this.listKaryawan = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnCari
			// 
			this.btnCari.Location = new System.Drawing.Point(631, 46);
			this.btnCari.Name = "btnCari";
			this.btnCari.Size = new System.Drawing.Size(75, 23);
			this.btnCari.TabIndex = 65;
			this.btnCari.Text = "Cari";
			this.btnCari.UseVisualStyleBackColor = true;
			this.btnCari.Click += new System.EventHandler(this.BtnCariClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 16);
			this.label1.TabIndex = 64;
			this.label1.Text = "ID TRANSAKSI : ";
			// 
			// txtIdTransaksi
			// 
			this.txtIdTransaksi.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdTransaksi.Location = new System.Drawing.Point(203, 48);
			this.txtIdTransaksi.Name = "txtIdTransaksi";
			this.txtIdTransaksi.Size = new System.Drawing.Size(406, 20);
			this.txtIdTransaksi.TabIndex = 63;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(98, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 16);
			this.label2.TabIndex = 67;
			this.label2.Text = "JENIS JASA : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(95, 275);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 16);
			this.label3.TabIndex = 69;
			this.label3.Text = "KARYAWAN  : ";
			// 
			// txtTanggal
			// 
			this.txtTanggal.BackColor = System.Drawing.SystemColors.Window;
			this.txtTanggal.Enabled = false;
			this.txtTanggal.Location = new System.Drawing.Point(203, 356);
			this.txtTanggal.Name = "txtTanggal";
			this.txtTanggal.Size = new System.Drawing.Size(406, 20);
			this.txtTanggal.TabIndex = 70;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 16);
			this.label4.TabIndex = 71;
			this.label4.Text = "TANGGAL TRANSAKSI  : ";
			// 
			// txtHarga
			// 
			this.txtHarga.BackColor = System.Drawing.SystemColors.Window;
			this.txtHarga.Enabled = false;
			this.txtHarga.Location = new System.Drawing.Point(203, 410);
			this.txtHarga.Name = "txtHarga";
			this.txtHarga.Size = new System.Drawing.Size(406, 20);
			this.txtHarga.TabIndex = 72;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(129, 414);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 73;
			this.label5.Text = "HARGA : ";
			// 
			// listJasa
			// 
			this.listJasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listJasa.FormattingEnabled = true;
			this.listJasa.Location = new System.Drawing.Point(203, 91);
			this.listJasa.Name = "listJasa";
			this.listJasa.Size = new System.Drawing.Size(406, 93);
			this.listJasa.TabIndex = 74;
			// 
			// listKaryawan
			// 
			this.listKaryawan.FormattingEnabled = true;
			this.listKaryawan.Location = new System.Drawing.Point(203, 234);
			this.listKaryawan.Name = "listKaryawan";
			this.listKaryawan.Size = new System.Drawing.Size(406, 95);
			this.listKaryawan.TabIndex = 75;
			// 
			// Laporan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 542);
			this.Controls.Add(this.listKaryawan);
			this.Controls.Add(this.listJasa);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtHarga);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTanggal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCari);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIdTransaksi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Laporan";
			this.Text = "Laporan";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox listKaryawan;
		private System.Windows.Forms.ListBox listJasa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtHarga;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTanggal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdTransaksi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCari;
	}
}
