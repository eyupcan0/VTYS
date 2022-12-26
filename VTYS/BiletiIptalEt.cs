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
    public partial class BiletiIptalEt : Form
    {
        public BiletiIptalEt()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432 ; Database=TrenTakipSistemi; user ID= postgres; password=718093");
        private void BiletiIptalEt_Load(object sender, EventArgs e)
        {
            
            string sorgu = "select * from bilet full outer join musteri on musteri.musteriid = bilet.musteriid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtbiletid.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            txttarifeid.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txtmusteriid.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            txthareketid.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            txtsubeid.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            txtvagonid.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
            txtsefertarih.Text = dataGridView1.Rows[choosen].Cells[7].Value.ToString();
            txttrenid.Text = dataGridView1.Rows[choosen].Cells[9].Value.ToString();
            txtBoxAd.Text = dataGridView1.Rows[choosen].Cells[10].Value.ToString();
            txtBoxSoyad.Text = dataGridView1.Rows[choosen].Cells[11].Value.ToString();
            txtBoxTelNo.Text = dataGridView1.Rows[choosen].Cells[13].Value.ToString();
            txtBoxEposta.Text = dataGridView1.Rows[choosen].Cells[14].Value.ToString();
            if (dataGridView1.Rows[choosen].Cells[6].Value.ToString()=="Business")
            {
                rdBtnBusiness.Checked = true;
            }
            else if(dataGridView1.Rows[choosen].Cells[6].Value.ToString() == "Ekonomi")
            {
                rdBtnEkonomi.Checked = true;
            }

            if (dataGridView1.Rows[choosen].Cells[12].Value.ToString() == "Kadın")
            {
                rdBtnKadin.Checked = true;
            }
            else if (dataGridView1.Rows[choosen].Cells[12].Value.ToString() == "Erkek")
            {
                rdBtnErkek.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Delete from bilet where musteriid=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtmusteriid.Text));
            komut3.ExecuteNonQuery();
            NpgsqlCommand komut4 = new NpgsqlCommand("Delete from bilet where biletid=@p2", baglanti);
            komut4.Parameters.AddWithValue("@p2", int.Parse(txtbiletid.Text));
            komut4.ExecuteNonQuery();
            NpgsqlCommand komut5 = new NpgsqlCommand("Delete from musteri where trenid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(txttrenid.Text));
            komut5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silme İşlemi Başarıyla Gerçekleşti");
            this.Close();

        }
    }
}
