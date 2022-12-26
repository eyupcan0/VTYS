using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class BireyselForm : Form
    {
        public BireyselForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BireyselForm_Load(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432 ; Database=TrenTakipSistemi; user ID= postgres; password=718093");
        private void btnSeyahatlerim_Click(object sender, EventArgs e)
        {
            GrpBoxSeyahatlerim.Visible = true;
            string sorgu = "select * from bilet full outer join musteri on musteri.musteriid = bilet.musteriid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnBiletAlBireysel_Click(object sender, EventArgs e)
        {
            BiletAl biletalform = new BiletAl();
            biletalform.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnacik_Click(object sender, EventArgs e)
        {
            BiletiAcigaAl biletacigaalform = new BiletiAcigaAl();
            biletacigaalform.ShowDialog();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            BiletiIptalEt biletiiptalet = new BiletiIptalEt();
            biletiiptalet.ShowDialog();
        }
    }
}
