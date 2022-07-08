using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_akhir_pv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(3);
                Form f = Form as Form;

                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
                this.mainPanel.Tag = f;
                f.Show();
            }

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

                pictureBox2.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                menuStripTransaksi.Enabled = true;
                menuStripTransaksi.Visible = true;
                loadform(new dashboard());
            
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPelayanan_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            menuStripTransaksi.Enabled = false;
            menuStripTransaksi.Visible = false;    
            loadform(new Pelayanan());
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            menuStripTransaksi.Enabled = false;
            menuStripTransaksi.Visible = false;    
            loadform(new Karyawan());
        }

        private void btnMobil_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            menuStripTransaksi.Enabled = false;
            menuStripTransaksi.Visible = false;            
            loadform(new mobil());
        }

        private void btnHarga_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            menuStripTransaksi.Enabled = false;
            menuStripTransaksi.Visible = false;                
            loadform(new Harga());
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            menuStripTransaksi.Enabled = false;
            menuStripTransaksi.Visible = false;               
            loadform(new Pekerjaan());
        }
        

        
        void TransaksiToolStripMenuItemClick(object sender, EventArgs e)
        {
            loadform(new dashboard());
        }
        

        
        void JasaToolStripMenuItemClick(object sender, EventArgs e)
        {
        	loadform(new DetailJasaTransaksi());
        }
        
        void KaryawanToolStripMenuItemClick(object sender, EventArgs e)
        {
        	loadform(new DetailKaryawanTransaksi());
        }
        
        void LaporanToolStripMenuItemClick(object sender, EventArgs e)
        {
        	loadform(new Laporan());
        }
    }
}
