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
	public partial class Karyawan : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;

		Koneksi Konn = new Koneksi();

		public Karyawan()
		{
			InitializeComponent();
		}
		void tampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("SELECT KARYAWAN.ID_KARYAWAN, " +
					"NAMA, TEMPAT_LAHIR AS TMP_LAHIR," +
					"TANGGAL_LAHIR AS TGL_LAHIR, " +
					"NO_HP, ALAMAT, " +
					"KARYAWAN.ID_JENIS_PEKERJAAN, " +
					"JENIS_PEKERJAAN.NAMA_PEKERJAAN " +
					"FROM KARYAWAN " +
					"INNER JOIN " +
					"JENIS_PEKERJAAN ON KARYAWAN.ID_JENIS_PEKERJAAN = JENIS_PEKERJAAN.ID_JENIS_PEKERJAAN", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "KARYAWAN");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "KARYAWAN";
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
			txtIdKaryawan.Text = "";
			txtNama.Text = "";
			txtTempatLahir.Text = "";
			txtNoHp.Text = "";
			txtAlamat.Text = "";
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
			NoOtomatis();
		}
		void NoOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select ID_KARYAWAN from KARYAWAN where ID_KARYAWAN in(select max(ID_KARYAWAN) from KARYAWAN) order by ID_KARYAWAN desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["ID_KARYAWAN"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "00" + hitung;
				urutan = "EM" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			}
			else
			{
				urutan = "EM001";
			}
			rd.Close();
			txtIdKaryawan.Text = urutan;
			conn.Close();
		}
		void isiComboBox()
        {
			SqlDataAdapter da = new SqlDataAdapter();
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select ID_JENIS_PEKERJAAN, NAMA_PEKERJAAN FROM JENIS_PEKERJAAN", conn);
			da.SelectCommand = cmd;
			DataTable table1 = new DataTable();
			da.Fill(table1);
			cmbJenisPekerjaan.DataSource = table1;
			cmbJenisPekerjaan.DisplayMember = "NAMA_PEKERJAAN";
			cmbJenisPekerjaan.ValueMember = "ID_JENIS_PEKERJAAN";
			conn.Close();
		}
		void cariBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select NAMA, TEMPAT_LAHIR AS TMP_LAHIR," +
					"NAMA, TEMPAT_LAHIR AS TMP_LAHIR,"+
					"TANGGAL_LAHIR AS TGL_LAHIR, " +
					"NO_HP, ALAMAT, " +
					"KARYAWAN.ID_JENIS_PEKERJAAN, " +
					"JENIS_PEKERJAAN.NAMA_PEKERJAAN " +
					"from KARYAWAN " +
					"INNER JOIN " +
					"JENIS_PEKERJAAN ON KARYAWAN.ID_JENIS_PEKERJAAN = JENIS_PEKERJAAN.ID_JENIS_PEKERJAAN " +
					"where ID_KARYAWAN like '%" + txtCariBarang.Text + "%' or NAMA like '%" + txtCariBarang.Text + "%'or NAMA like '%" + txtCariBarang.Text + "%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "KARYAWAN");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "KARYAWAN";
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

		private void Karyawan_Load(object sender, EventArgs e)
		{
			tampilData();
			NoOtomatis();
			isiComboBox();
		}

		private void btnSimpan_Click(object sender, EventArgs e)
		{

			if (txtIdKaryawan.Text == "" || txtNama.Text == "" || txtTempatLahir.Text == "" || txtNoHp.Text == "" || txtAlamat.Text == "" || cmbJenisPekerjaan.Text == "")
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
						
						cmd = new SqlCommand("insert into KARYAWAN values ('" + txtIdKaryawan.Text + "','" + txtNama.Text + "','" + txtTempatLahir.Text + "','" + dateTanggalLahir.Text + "','" + txtNoHp.Text+ "','"+ txtAlamat.Text + "','"+ cmbJenisPekerjaan.SelectedValue.ToString() + "')", conn);
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
				txtIdKaryawan.Text = row.Cells["ID_KARYAWAN"].Value.ToString();
				txtNama.Text = row.Cells["NAMA"].Value.ToString();
				txtTempatLahir.Text = row.Cells["TMP_LAHIR"].Value.ToString();
				dateTanggalLahir.Text = row.Cells["TGL_LAHIR"].Value.ToString();
				txtNoHp.Text = row.Cells["NO_HP"].Value.ToString();
				txtAlamat.Text = row.Cells["ALAMAT"].Value.ToString();
				cmbJenisPekerjaan.Text = row.Cells["NAMA_PEKERJAAN"].Value.ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void btnEdit_Click(object sender, EventArgs e)
        {
			if (txtIdKaryawan.Text == "" || txtNama.Text == "" || txtTempatLahir.Text == "" || txtNoHp.Text == "" || txtAlamat.Text == "" || cmbJenisPekerjaan.Text == "")
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
						cmd = new SqlCommand("update KARYAWAN set ID_KARYAWAN= '" + txtIdKaryawan.Text + "',NAMA= '"+ txtNama.Text+"',TEMPAT_LAHIR='"+txtTempatLahir.Text+"',TANGGAL_LAHIR='"+dateTanggalLahir.Text+"',NO_HP='"+txtNoHp.Text+"',ALAMAT='"+txtAlamat.Text+"', ID_JENIS_PEKERJAAN= '"+ cmbJenisPekerjaan.SelectedValue.ToString()+"' where ID_KARYAWAN = '" + txtIdKaryawan.Text + "'", conn);
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
			if (txtIdKaryawan.Text == "" || txtNama.Text == "" || txtTempatLahir.Text == "" || txtNoHp.Text == "" || txtAlamat.Text == "" || cmbJenisPekerjaan.Text == "")
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
						cmd = new SqlCommand("delete from KARYAWAN WHERE ID_KARYAWAN = '" + txtIdKaryawan.Text + "'", conn);
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
