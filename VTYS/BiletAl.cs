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
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblBiletal_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432 ; Database=TrenTakipSistemi; user ID= postgres; password=718093");
        private void btnBiletiAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into bilet(biletid,musteriid,tarifeid,hareketid,subeid,vagonid,bilettur,sefertarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into musteri(musteriid,trenid,musteriad,musterisoyad,mustericinsiyet,musteritel,musterieposta) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtmusteriid.Text));
            komut2.Parameters.AddWithValue("@p2", int.Parse(txttrenid.Text));
            komut2.Parameters.AddWithValue("@p3", txtBoxAd.Text);
            komut2.Parameters.AddWithValue("@p4", txtBoxSoyad.Text);
            if (rdBtnErkek.Checked == true)
            {
                komut2.Parameters.AddWithValue("@p5", rdBtnErkek.Text);
            }
            else if (rdBtnKadin.Checked == true)
            {
                komut2.Parameters.AddWithValue("@p5", rdBtnKadin.Text);
            }
            komut2.Parameters.AddWithValue("@p6", int.Parse(txtBoxTelNo.Text));
            komut2.Parameters.AddWithValue("@p7", txtBoxEposta.Text);
            komut2.ExecuteNonQuery();
            

            komut1.Parameters.AddWithValue("@p1", int.Parse(txtbiletid.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtmusteriid.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(txttarifeid.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(txthareketid.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(txtsubeid.Text));
            komut1.Parameters.AddWithValue("@p6", int.Parse(txtvagonid.Text));
            if(rdBtnBusiness.Checked==true)
            {
                komut1.Parameters.AddWithValue("@p7", rdBtnBusiness.Text);
            }
            else if (rdBtnEkonomi.Checked == true)
            {
                komut1.Parameters.AddWithValue("@p7", rdBtnEkonomi.Text);
            }
            komut1.Parameters.AddWithValue("@p8", dateSefer.Value);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarılı bir şekilde eklendi.");
            this.Close();

        }

        private void rdBtnBusiness_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
