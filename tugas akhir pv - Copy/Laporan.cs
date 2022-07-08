using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tugas_akhir_pv
{
	/// <summary>
	/// Description of Laporan.
	/// </summary>
	public partial class Laporan : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;

		Koneksi Konn = new Koneksi();
		public Laporan()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void isiListBoxKaryawan(){
			SqlConnection conn = Konn.GetConn();
			conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT karyawan.nama from detail_karyawan_bekerja inner join karyawan on detail_karyawan_bekerja.id_karyawan = karyawan.id_karyawan where id_transaksi = '"+txtIdTransaksi.Text+"'", conn);
            adapter.Fill(ds);
            listKaryawan.DataSource = ds.Tables[0]; 
            listKaryawan.DisplayMember = "nama"; 
            conn.Close();
		}
		void isiListBoxJasa(){
			SqlConnection conn = Konn.GetConn();
			conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT harga_jasa.keterangan from detail_harga_jasa inner join harga_jasa on detail_harga_jasa.id_harga_jasa = harga_jasa.id_harga_jasa where id_transaksi = '"+txtIdTransaksi.Text+"'", conn);
            adapter.Fill(ds);
            listJasa.DataSource = ds.Tables[0]; 
            listJasa.DisplayMember = "keterangan"; 
            conn.Close();
		}
		void setTanggal(){
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("Select tanggal_transaksi from transaksi where id_transaksi = '"+txtIdTransaksi.Text+"'", conn);
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read()) {
				txtTanggal.Text = reader.GetValue(0).ToString();
			}
			conn.Close();
		}
		void setHarga(){
						SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("Select sum(harga_jasa.harga) from detail_harga_jasa inner join harga_jasa on detail_harga_jasa.id_harga_jasa = harga_jasa.id_harga_jasa where id_transaksi = '"+txtIdTransaksi.Text+"'", conn);
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read()) {
				txtHarga.Text = reader.GetValue(0).ToString();
			}
			conn.Close();
		}
		void BtnCariClick(object sender, EventArgs e)
		{
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("Select id_transaksi from transaksi where id_transaksi = '"+txtIdTransaksi.Text+"'", conn);
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read()) {
				MessageBox.Show("Data ditemukan");
				isiListBoxKaryawan();
				isiListBoxJasa();
				setTanggal();
				setHarga();
			} else{
				MessageBox.Show("Data tidak ditemukan");
			}
			conn.Close();
		}
	}
}
