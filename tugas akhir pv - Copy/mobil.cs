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
    public partial class mobil : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;

		Koneksi Konn = new Koneksi();

		public mobil()
        {
            InitializeComponent();
        }
		void tampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from JENIS_MOBIL", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "JENIS_MOBIL");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "JENIS_MOBIL";
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

		private void mobil_Load(object sender, EventArgs e)
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
				cmd = new SqlCommand("Select * from JENIS_MOBIL where ID_JENIS_MOBIL like '%" + txtCariBarang.Text + "%' or JENIS_MOBIL like '%" + txtCariBarang.Text + "%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "JENIS_MOBIL");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "JENIS_MOBIL";
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
			cmd = new SqlCommand("select ID_JENIS_MOBIL from Jenis_MOBIL where ID_JENIS_MOBIL in(select max(ID_JENIS_MOBIL) from Jenis_MOBIL) order by ID_JENIS_MOBIL desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["ID_JENIS_MOBIL"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "00" + hitung;
				urutan = "MB" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			}
			else
			{
				urutan = "MB001";
			}
			rd.Close();
			txtIdMobil.Text = urutan;
			conn.Close();
		}

		void bersihkanLayar()
        {
			txtIdMobil.Text = "";
			txtJenisMobil.Text = "";
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
			NoOtomatis();
		}
		private void btnSimpan_Click(object sender, EventArgs e)
        {
			if (txtIdMobil.Text == "" || txtJenisMobil.Text == "")
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
						cmd = new SqlCommand("insert into Jenis_Mobil values ('" + txtIdMobil.Text + "','" + txtJenisMobil.Text + "')", conn);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
			if (txtIdMobil.Text == "" || txtJenisMobil.Text == "")
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
						cmd = new SqlCommand("update JENIS_mobil set ID_JENIS_MOBIL = '"+txtIdMobil.Text+"',+ JENIS_MOBIL='" + txtJenisMobil.Text + "' where ID_JENIS_mobil = '" + txtIdMobil.Text + "'", conn);
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
			if (txtIdMobil.Text == "" || txtJenisMobil.Text == "")
			{
				MessageBox.Show("Lengkapi data terlebih dahulu!");
			}
			else
			{
				if (MessageBox.Show("Apakah anda ingin Menghapus data ini?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					SqlConnection conn = Konn.GetConn();
					try
					{
						cmd = new SqlCommand("delete from JENIS_mobil WHERE ID_JENIS_mobil = '" + txtIdMobil.Text + "'", conn);
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

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
			bersihkanLayar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				btnSimpan.Enabled = false;
				btnEdit.Enabled = true;
				btnHapus.Enabled = true;
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtIdMobil.Text = row.Cells["ID_JENIS_MOBIL"].Value.ToString();
				txtJenisMobil.Text = row.Cells["JENIS_MOBIL"].Value.ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(txtCariBarang.Text))
			{
				tampilData();
			}
			else
			{
				cariBarang();
			}

		}
	}
}
