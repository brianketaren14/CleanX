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
    public partial class Harga : Form
    {
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;

		Koneksi Konn = new Koneksi();
		private string id;
		public Harga()
        {
            InitializeComponent();
        }
		void tampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("SELECT " +
					"HARGA_JASA.ID_HARGA_JASA, " +
					"JENIS_JASA.ID_JENIS_JASA, " +
					"JENIS_JASA.JENIS_JASA, " +
					"JENIS_MOBIL.ID_JENIS_MOBIL," +
					"JENIS_MOBIL.JENIS_MOBIL, " +
					"HARGA, keterangan from HARGA_JASA inner join JENIS_JASA ON HARGA_JASA.ID_JENIS_JASA = JENIS_JASA.ID_JENIS_JASA " +
					"inner join JENIS_MOBIL ON HARGA_JASA.ID_JENIS_MOBIL = JENIS_MOBIL.ID_JENIS_MOBIL", conn);
				
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "HARGA_JASA");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "HARGA_JASA";
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
		void cariBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("SELECT " +
					"HARGA_JASA.ID_HARGA_JASA, " +
					"JENIS_JASA.ID_JENIS_JASA, " +
					"JENIS_JASA.JENIS_JASA, " +
					"JENIS_MOBIL.ID_JENIS_MOBIL," +
					"JENIS_MOBIL.JENIS_MOBIL, " +
					"HARGA, keterangan from HARGA_JASA inner join JENIS_JASA ON HARGA_JASA.ID_JENIS_JASA = JENIS_JASA.ID_JENIS_JASA " +
					"inner join JENIS_MOBIL ON HARGA_JASA.ID_JENIS_MOBIL = JENIS_MOBIL.ID_JENIS_MOBIL "+
					"WHERE HARGA_JASA.ID_HARGA_JASA LIKE '%"+txtCariBarang.Text+ "%' or HARGA_JASA.keterangan like '%"+txtCariBarang.Text +"%'", conn);
				
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "HARGA_JASA");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "HARGA_JASA";
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
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
			txtIdHargaJasa.Text = "";
			txtHarga.Text = "";
        }
		void isiCmbJasa()
        {
			SqlDataAdapter da = new SqlDataAdapter();
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select ID_JENIS_JASA, JENIS_JASA FROM JENIS_JASA", conn);
			da.SelectCommand = cmd;
			DataTable table1 = new DataTable();
			da.Fill(table1);
			cmbJenisJasa.DataSource = table1;
			cmbJenisJasa.DisplayMember = "JENIS_JASA";
			cmbJenisJasa.ValueMember = "ID_JENIS_JASA";
			conn.Close();

		}
		void isiCmbMobil()
        {
			SqlDataAdapter da = new SqlDataAdapter();
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select ID_JENIS_MOBIL, JENIS_MOBIL FROM JENIS_MOBIL", conn);
			da.SelectCommand = cmd;
			DataTable table1 = new DataTable();
			da.Fill(table1);
			cmbJenisMobil.DataSource = table1;
			cmbJenisMobil.DisplayMember = "JENIS_MOBIL";
			cmbJenisMobil.ValueMember = "ID_JENIS_MOBIL";
			conn.Close();
		}

		void NoOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select ID_HARGA_JASA from HARGA_JASA where ID_HARGA_JASA in(select max(ID_HARGA_JASA) from HARGA_JASA) order by ID_HARGA_JASA desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["ID_HARGA_JASA"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "00" + hitung;
				urutan = "HJ" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			}
			else
			{
				urutan = "HJ001";
			}
			rd.Close();
			txtIdHargaJasa.Text = urutan;
			conn.Close();
		}
		private void Harga_Load(object sender, EventArgs e)
        {

			tampilData();
			isiCmbMobil();
			isiCmbJasa();
			NoOtomatis();

		}

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if ( txtIdHargaJasa.Text == "" || txtHarga.Text == "")
            {
				MessageBox.Show("Lengkapi data terlebih dahulu!");
			} else
            {
				if (MessageBox.Show("Apakah anda ingin Menyimpan data ini?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					SqlConnection conn = Konn.GetConn();
					try
					{

						cmd = new SqlCommand("insert into HARGA_JASA values ('" + txtIdHargaJasa.Text + "','" + cmbJenisJasa.SelectedValue.ToString() + "','" + cmbJenisMobil.SelectedValue.ToString() + "','"+ txtHarga.Text+"', '"+txtKeterangan.Text+"')", conn);
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
				id = row.Cells["ID_HARGA_JASA"].Value.ToString();
				txtIdHargaJasa.Text = row.Cells["ID_HARGA_JASA"].Value.ToString();
				cmbJenisJasa.Text = row.Cells["JENIS_JASA"].Value.ToString();
				cmbJenisMobil.Text = row.Cells["JENIS_MOBIL"].Value.ToString();
				txtHarga.Text = row.Cells["HARGA"].Value.ToString();
				txtKeterangan.Text = row.Cells["KETERANGAN"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void btnEdit_Click(object sender, EventArgs e)
        {
			if (txtIdHargaJasa.Text == "" || txtHarga.Text == "")
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

						cmd = new SqlCommand("UPDATE HARGA_JASA set ID_HARGA_JASA = '" + txtIdHargaJasa.Text + "', ID_JENIS_JASA = '" + cmbJenisJasa.SelectedValue.ToString() + "', ID_JENIS_MOBIL = '" + cmbJenisMobil.SelectedValue.ToString() + "', HARGA = '" + txtHarga.Text + "', keterangan = '"+txtKeterangan.Text+"' where ID_HARGA_JASA = '"+id+"'", conn);
						conn.Open();
						cmd.ExecuteNonQuery();
						MessageBox.Show("update Data Berhasil!");
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
			if (txtIdHargaJasa.Text == "" || txtHarga.Text == "")
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

						cmd = new SqlCommand("DELETE FROM HARGA_JASA WHERE ID_HARGA_JASA = '" + txtIdHargaJasa.Text +"'", conn);
						conn.Open();
						cmd.ExecuteNonQuery();
						MessageBox.Show("HAPUS Data Berhasil!");
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
