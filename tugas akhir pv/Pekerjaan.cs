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
    public partial class Pekerjaan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public Pekerjaan()
        {
            InitializeComponent();
        }
		void bersihkanLayar()
        {
			txtIdPekerjaan.Text = "";
			txtNamaPekerjaan.Text = "";
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
			NoOtomatis();
        }
		void tampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from Jenis_Pekerjaan", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "Jenis_Pekerjaan");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "Jenis_Pekerjaan";
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
			cmd = new SqlCommand("select ID_JENIS_PEKERJAAN from Jenis_Pekerjaan where ID_JENIS_PEKERJAAN in(select max(ID_JENIS_PEKERJAAN) from Jenis_Pekerjaan) order by ID_JENIS_PEKERJAAN desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["ID_JENIS_PEKERJAAN"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "00" + hitung;
				urutan = "JP" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			}
			else
			{
				urutan = "JP001";
			}
			rd.Close();
			txtIdPekerjaan.Text = urutan;
			conn.Close();
		}

		void cariBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from JENIS_PEKERJAAN where ID_JENIS_PEKERJAAN like '%" + txtCariBarang.Text + "%' or NAMA_PEKERJAAN like '%" + txtCariBarang.Text + "%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "JENIS_PEKERJAAN");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "JENIS_PEKERJAAN";
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

		private void Pekerjaan_Load(object sender, EventArgs e)
        {
			tampilData();
			NoOtomatis();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
			if (txtIdPekerjaan.Text == "" || txtNamaPekerjaan.Text == "")
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
						cmd = new SqlCommand("insert into Jenis_Pekerjaan values ('" + txtIdPekerjaan.Text + "','" + txtNamaPekerjaan.Text + "')", conn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				btnSimpan.Enabled = false;
				btnEdit.Enabled = true;
				btnHapus.Enabled = true;
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtIdPekerjaan.Text = row.Cells["ID_JENIS_PEKERJAAN"].Value.ToString();
				txtNamaPekerjaan.Text = row.Cells["NAMA_PEKERJAAN"].Value.ToString();

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
			if (txtIdPekerjaan.Text == "" || txtNamaPekerjaan.Text == "")
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
						cmd = new SqlCommand("update JENIS_PEKERJAAN set NAMA_PEKERJAAN='" + txtNamaPekerjaan.Text + "' where ID_JENIS_PEKERJAAN = '" + txtIdPekerjaan.Text + "'", conn);
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
			if (txtIdPekerjaan.Text == "" || txtNamaPekerjaan.Text == "")
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
						cmd = new SqlCommand("delete from JENIS_PEKERJAAN WHERE ID_JENIS_PEKERJAAN = '" + txtIdPekerjaan.Text + "'", conn);
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

