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
    public partial class DetailKaryawanTransaksi : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		string id_karyawan;
		Koneksi Konn = new Koneksi();
		public DetailKaryawanTransaksi()
        {
            InitializeComponent();
        }
		
		void isiCmbKaryawan(){
			SqlDataAdapter da = new SqlDataAdapter();
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select *  FROM KARYAWAN ", conn);
			da.SelectCommand = cmd;
			DataTable table1 = new DataTable();
			da.Fill(table1);
			cmbKaryawan.DataSource = table1;
			cmbKaryawan.DisplayMember = "NAMA";
			cmbKaryawan.ValueMember = "ID_KARYAWAN";
			conn.Close();
		}
		
		void bersihkanLayar()
		{
			txtIdTransaksi.Text = "";
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
		}
		void tampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select DETAIL_KARYAWAN_BEKERJA.id_transaksi, DETAIL_KARYAWAN_BEKERJA.id_karyawan, karyawan.nama, jenis_pekerjaan.nama_pekerjaan " +
				                     "from DETAIL_KARYAWAN_BEKERJA inner join karyawan on DETAIL_KARYAWAN_BEKERJA.id_karyawan = karyawan.id_karyawan "+
				                     " inner join jenis_pekerjaan on karyawan.id_jenis_pekerjaan = jenis_pekerjaan.id_jenis_pekerjaan" + 
				                     " where id_transaksi = '"+txtIdTransaksi.Text+"'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "DETAIL_KARYAWAN_BEKERJA");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "DETAIL_KARYAWAN_BEKERJA";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				
			}
			catch (Exception G)
			{
				MessageBox.Show(G.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		private void DetailKaryawanTransaksi_Load(object sender, EventArgs e)
        {
			
        }
        
        void BtnCariClick(object sender, EventArgs e)
        {
        	    SqlConnection conn = Konn.GetConn();
        		conn.Open();
        		cmd = new SqlCommand("Select id_transaksi from TRANSAKSI where id_transaksi= '"+txtIdTransaksi.Text+"'", conn);
				SqlDataReader reader;
				reader = cmd.ExecuteReader();
				if(reader.Read()){
					MessageBox.Show("Data Ditemukan");
					tampilData();
					isiCmbKaryawan();
					txtIdTransaksi.Enabled = false;
				} else {
					MessageBox.Show("Data Tidak ditemukan");
					bersihkanLayar();
				}
				conn.Close();
        }
        
        void BtnSimpanClick(object sender, EventArgs e)
        {
        	if (txtIdTransaksi.Text == "")
			{
				MessageBox.Show("Lengkapi data terlebih dahulu!");

			}
			else
			{
				if (MessageBox.Show("Apakah anda ingin Menyimpan data ini?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					SqlConnection conn = Konn.GetConn();
					try
					{
						cmd = new SqlCommand("insert into DETAIL_KARYAWAN_BEKERJA values ('" + txtIdTransaksi.Text + "','" + cmbKaryawan.SelectedValue.ToString() + "')", conn);
						conn.Open();
						cmd.ExecuteNonQuery();
						MessageBox.Show("Insert Data Berhasil!");
						tampilData();
						bersihkanLayar();
						conn.Close();
					}
					catch (Exception x)
					{
						MessageBox.Show("Tidak dapat menyimpan data \n" + x);
					}
				}
				else
				{
					tampilData();
					bersihkanLayar();
				}
				txtIdTransaksi.Enabled = true;
				
			}
        }
        
        void BtnEditClick(object sender, EventArgs e)
        {
			if (txtIdTransaksi.Text == "")
			{
				MessageBox.Show("Lengkapi data terlebih dahulu!");

			}
			else
			{
				if (MessageBox.Show("Apakah anda ingin Menyimpan data ini?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					SqlConnection conn = Konn.GetConn();
					try
					{
						cmd = new SqlCommand("update DETAIL_KARYAWAN_BEKERJA set id_karyawan = '" + cmbKaryawan.SelectedValue.ToString() + "' where id_transaksi = '" + txtIdTransaksi.Text + "' and id_karyawan = '" + id_karyawan + "'", conn);
						conn.Open();
						cmd.ExecuteNonQuery();
						MessageBox.Show("Update Data Berhasil!");
						tampilData();
						bersihkanLayar();
						conn.Close();
					}
					catch (Exception x)
					{
						MessageBox.Show("Tidak dapat menyimpan data \n" + x);
					}
				}
				else
				{
					tampilData();
					bersihkanLayar();
				}
				txtIdTransaksi.Enabled = true;
				
			}
        }
        
        void BtnHapusClick(object sender, EventArgs e)
        {
			if (txtIdTransaksi.Text == "")
			{
				MessageBox.Show("Lengkapi data terlebih dahulu!");

			}
			else
			{
				if (MessageBox.Show("Apakah anda ingin Menyimpan data ini?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					SqlConnection conn = Konn.GetConn();
					try
					{
						cmd = new SqlCommand("delete from detail_karyawan_bekerja where id_transaksi= '"+txtIdTransaksi.Text+"' and id_karyawan = '"+ id_karyawan + " '", conn);
						conn.Open();
						cmd.ExecuteNonQuery();
						MessageBox.Show("Hapus Data Berhasil!");
						tampilData();
						bersihkanLayar();
						conn.Close();
						
					}
					catch (Exception x)
					{
						MessageBox.Show("Tidak dapat menyimpan data \n" + x);
					}
				}
				else
				{
					tampilData();
					bersihkanLayar();
				}
				txtIdTransaksi.Enabled = true;
				
			}        	
        }
        
        void BtnBersihkanClick(object sender, EventArgs e)
        {
			bersihkanLayar();
        }
        
        void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        	try
			{
				
				btnSimpan.Enabled = false;
				btnEdit.Enabled = true;
				btnHapus.Enabled = true;
				txtIdTransaksi.Enabled = true;
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtIdTransaksi.Text = row.Cells["ID_TRANSAKSI"].Value.ToString();
				cmbKaryawan.Text = row.Cells["ID_KARYAWAN"].Value.ToString();
				id_karyawan = row.Cells["ID_KARYAWAN"].Value.ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
        }
    }
}
