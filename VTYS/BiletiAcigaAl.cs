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
    public partial class BiletiAcigaAl : Form
    {
        public BiletiAcigaAl()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432 ; Database=TrenTakipSistemi; user ID= postgres; password=718093");
        

        private void BiletiAcigaAl_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from bilet full outer join musteri on musteri.musteriid = bilet.musteriid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
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
            if (dataGridView1.Rows[choosen].Cells[6].Value.ToString() == "Business")
            {
                rdBtnBusiness.Checked = true;
            }
            else if (dataGridView1.Rows[choosen].Cells[6].Value.ToString() == "Ekonomi")
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
            NpgsqlCommand komut7 = new NpgsqlCommand("update musteri set trenid=@p2,musteriad=@p3,musterisoyad=@p4,mustericinsiyet=@p5,musteritel=@p6,musterieposta=@p7 where musteriid=@p1", baglanti);

            komut7.Parameters.AddWithValue("@p1", int.Parse(txtmusteriid.Text));
            komut7.Parameters.AddWithValue("@p2", int.Parse(txttrenid.Text));
            komut7.Parameters.AddWithValue("@p3", txtBoxAd.Text);
            komut7.Parameters.AddWithValue("@p4", txtBoxSoyad.Text);
            if (rdBtnErkek.Checked == true)
            {
                komut7.Parameters.AddWithValue("@p5", rdBtnErkek.Text);
            }
            else if (rdBtnKadin.Checked == true)
            {
                komut7.Parameters.AddWithValue("@p5", rdBtnKadin.Text);
            }
            komut7.Parameters.AddWithValue("@p6", int.Parse(txtBoxTelNo.Text));
            komut7.Parameters.AddWithValue("@p7", txtBoxEposta.Text);
            komut7.ExecuteNonQuery();
           
            NpgsqlCommand komut6 = new NpgsqlCommand("update bilet set musteriid=@p2,tarifeid=@p3,hareketid=@p4,subeid=@p5,vagonid=@p6,bilettur=@p7,sefertarih=@p8 where biletid=@p1", baglanti);

            komut6.Parameters.AddWithValue("@p1", int.Parse(txtbiletid.Text));
            komut6.Parameters.AddWithValue("@p2", int.Parse(txtmusteriid.Text));
            komut6.Parameters.AddWithValue("@p3", int.Parse(txttarifeid.Text));
            komut6.Parameters.AddWithValue("@p4", int.Parse(txthareketid.Text));
            komut6.Parameters.AddWithValue("@p5", int.Parse(txtsubeid.Text));
            komut6.Parameters.AddWithValue("@p6", int.Parse(txtvagonid.Text));
            if (rdBtnBusiness.Checked == true)
            {
                komut6.Parameters.AddWithValue("@p7", rdBtnBusiness.Text);
            }
            else if (rdBtnEkonomi.Checked == true)
            {
                komut6.Parameters.AddWithValue("@p7", rdBtnEkonomi.Text);
            }
            komut6.Parameters.AddWithValue("@p8", DateTime.Parse(txtsefertarih.Text));
            komut6.ExecuteNonQuery();
            MessageBox.Show("Bilet Başarıyla Güncellendi");
            this.Close();

            baglanti.Close();
        }
    }
}
