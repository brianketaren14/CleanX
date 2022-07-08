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
    public partial class dashboard : Form
    {
		string id;
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;

		Koneksi Konn = new Koneksi();

		public dashboard()
        {
            InitializeComponent();
            
        }

		void tampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * FROM TRANSAKSI", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TRANSAKSI");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TRANSAKSI";
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


		void bersihkanLayar()
        {
			txtIdTransaksi.Text = "";
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
        }
		private void dashboard_Load(object sender, EventArgs e)
        {
			tampilData();
			NoOtomatis();

		}

		void cariBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TRANSAKSI where ID_TRANSAKSI like '%" + txtCariBarang.Text + "%' or TANGGAL-TRANSAKSI like '%" + txtCariBarang.Text + "%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TRANSAKSI");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TRANSAKSI";
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
		
		void NoOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select ID_TRANSAKSI from TRANSAKSI where ID_TRANSAKSI in(select max(ID_TRANSAKSI) from TRANSAKSI) order by ID_TRANSAKSI desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["ID_TRANSAKSI"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "00" + hitung;
				urutan = "TR" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			}
			else
			{
				urutan = "TR001";
			}
			rd.Close();
			txtIdTransaksi.Text = urutan;
			conn.Close();
		}
		

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				btnSimpan.Enabled = false;
				btnEdit.Enabled = true;
				btnHapus.Enabled = true;
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtIdTransaksi.Text = row.Cells["ID_TRANSAKSI"].Value.ToString();
				id= row.Cells["ID_TRANSAKSI"].Value.ToString();
				tglTransaksi.Text = row.Cells["TANGGAL_TRANSAKSI"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
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
						cmd = new SqlCommand("insert into TRANSAKSI values ('" + txtIdTransaksi.Text + "','" + tglTransaksi.Text + "')", conn);
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

						cmd = new SqlCommand("UPDATE TRANSAKSI SET ID_TRANSAKSI = '" + txtIdTransaksi.Text + "', TANGGAL_TRANSAKSI = '" + tglTransaksi.Text + "' WHERE ID_TRANSAKSI = '"+id+"'", conn);
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
						
						cmd = new SqlCommand("DELETE FROM TRANSAKSI WHERE ID_TRANSAKSI = '"+ txtIdTransaksi.Text +"'", conn);
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
			}        	
        }
        
        void BtnBersihkanClick(object sender, EventArgs e)
        {
        	bersihkanLayar();
        }
    }
}
