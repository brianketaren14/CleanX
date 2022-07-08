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
	public partial class DetailJasaTransaksi : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		private string id_harga_jasa;
		Koneksi Konn = new Koneksi();

		public DetailJasaTransaksi()
		{
			InitializeComponent();
		}
		
		void isiCmbJenisJasa(){
			SqlDataAdapter da = new SqlDataAdapter();
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select *  FROM HARGA_JASA ", conn);
			da.SelectCommand = cmd;
			DataTable table1 = new DataTable();
			da.Fill(table1);
			cmbJenisJasa.DataSource = table1;
			cmbJenisJasa.DisplayMember = "KETERANGAN";
			cmbJenisJasa.ValueMember = "ID_HARGA_JASA";
			conn.Close();
			
		}
		
		private void DetailJasaTransaksi_Load(object sender, EventArgs e)
		{
			
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
				cmd = new SqlCommand("Select DETAIL_HARGA_JASA.id_transaksi, DETAIL_HARGA_JASA.id_harga_jasa, HARGA_JASA.KETERANGAN, HARGA_JASA.Harga from DETAIL_HARGA_JASA inner join harga_jasa on DETAIL_HARGA_JASA.id_harga_jasa = harga_jasa.id_harga_jasa where id_transaksi = '"+txtIdTransaksi.Text+"'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "DETAIL_HARGA_JASA");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "DETAIL_HARGA_JASA";
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

		private void btnSimpan_Click(object sender, EventArgs e)
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
						cmd = new SqlCommand("insert into Detail_harga_jasa values ('" + txtIdTransaksi.Text + "','" + cmbJenisJasa.SelectedValue.ToString() + "')", conn);
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

		private void btnEdit_Click(object sender, EventArgs e)
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
						cmd = new SqlCommand("update Detail_harga_jasa set id_harga_jasa = '" + cmbJenisJasa.SelectedValue.ToString() + "' where id_transaksi = '" + txtIdTransaksi.Text + "' and id_harga_jasa = '" + id_harga_jasa + "'", conn);
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

        private void btnHapus_Click(object sender, EventArgs e)
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
						cmd = new SqlCommand("delete from Detail_harga_jasa where id_transaksi= '"+txtIdTransaksi.Text+"' and id_harga_jasa = '"+ id_harga_jasa + " '", conn);
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
				btnSimpan.Enabled = true;
			}
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				
				btnSimpan.Enabled = false;
				btnEdit.Enabled = true;
				btnHapus.Enabled = true;
				txtIdTransaksi.Enabled = true;
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtIdTransaksi.Text = row.Cells["ID_TRANSAKSI"].Value.ToString();
				cmbJenisJasa.Text = row.Cells["ID_HARGA_JASA"].Value.ToString();
				id_harga_jasa = row.Cells["ID_HARGA_JASA"].Value.ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
			bersihkanLayar();
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
					isiCmbJenisJasa();
					txtIdTransaksi.Enabled = false;
				} else {
					MessageBox.Show("Data Tidak ditemukan");
					bersihkanLayar();
				}
				conn.Close();
        }
    }
}
