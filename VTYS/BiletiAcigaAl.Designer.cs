
namespace VTYS
{
    partial class BiletiAcigaAl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnBusiness = new System.Windows.Forms.RadioButton();
            this.rdBtnEkonomi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnErkek = new System.Windows.Forms.RadioButton();
            this.rdBtnKadin = new System.Windows.Forms.RadioButton();
            this.txtsefertarih = new System.Windows.Forms.TextBox();
            this.txtBoxEposta = new System.Windows.Forms.TextBox();
            this.txttrenid = new System.Windows.Forms.TextBox();
            this.txtvagonid = new System.Windows.Forms.TextBox();
            this.txtsubeid = new System.Windows.Forms.TextBox();
            this.txtmusteriid = new System.Windows.Forms.TextBox();
            this.txthareketid = new System.Windows.Forms.TextBox();
            this.txttarifeid = new System.Windows.Forms.TextBox();
            this.txtbiletid = new System.Windows.Forms.TextBox();
            this.txtBoxTelNo = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBiletTur = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSubeID = new System.Windows.Forms.Label();
            this.lblHareketID = new System.Windows.Forms.Label();
            this.lblTarifeID = new System.Windows.Forms.Label();
            this.lbltrenid = new System.Windows.Forms.Label();
            this.lblVagonID = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblBiletID = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(736, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 48);
            this.button1.TabIndex = 75;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(58, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(969, 225);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnBusiness);
            this.groupBox2.Controls.Add(this.rdBtnEkonomi);
            this.groupBox2.Location = new System.Drawing.Point(212, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 40);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            // 
            // rdBtnBusiness
            // 
            this.rdBtnBusiness.AutoSize = true;
            this.rdBtnBusiness.Location = new System.Drawing.Point(204, 16);
            this.rdBtnBusiness.Name = "rdBtnBusiness";
            this.rdBtnBusiness.Size = new System.Drawing.Size(67, 17);
            this.rdBtnBusiness.TabIndex = 3;
            this.rdBtnBusiness.TabStop = true;
            this.rdBtnBusiness.Text = "Business";
            this.rdBtnBusiness.UseVisualStyleBackColor = true;
            // 
            // rdBtnEkonomi
            // 
            this.rdBtnEkonomi.AutoSize = true;
            this.rdBtnEkonomi.Location = new System.Drawing.Point(6, 16);
            this.rdBtnEkonomi.Name = "rdBtnEkonomi";
            this.rdBtnEkonomi.Size = new System.Drawing.Size(66, 17);
            this.rdBtnEkonomi.TabIndex = 3;
            this.rdBtnEkonomi.TabStop = true;
            this.rdBtnEkonomi.Text = "Ekonomi";
            this.rdBtnEkonomi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnErkek);
            this.groupBox1.Controls.Add(this.rdBtnKadin);
            this.groupBox1.Location = new System.Drawing.Point(212, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 45);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // rdBtnErkek
            // 
            this.rdBtnErkek.AutoSize = true;
            this.rdBtnErkek.Location = new System.Drawing.Point(204, 19);
            this.rdBtnErkek.Name = "rdBtnErkek";
            this.rdBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.rdBtnErkek.TabIndex = 2;
            this.rdBtnErkek.TabStop = true;
            this.rdBtnErkek.Text = "Erkek";
            this.rdBtnErkek.UseVisualStyleBackColor = true;
            // 
            // rdBtnKadin
            // 
            this.rdBtnKadin.AutoSize = true;
            this.rdBtnKadin.Location = new System.Drawing.Point(0, 19);
            this.rdBtnKadin.Name = "rdBtnKadin";
            this.rdBtnKadin.Size = new System.Drawing.Size(52, 17);
            this.rdBtnKadin.TabIndex = 2;
            this.rdBtnKadin.TabStop = true;
            this.rdBtnKadin.Text = "Kadın";
            this.rdBtnKadin.UseVisualStyleBackColor = true;
            // 
            // txtsefertarih
            // 
            this.txtsefertarih.Location = new System.Drawing.Point(212, 327);
            this.txtsefertarih.Name = "txtsefertarih";
            this.txtsefertarih.Size = new System.Drawing.Size(271, 20);
            this.txtsefertarih.TabIndex = 71;
            // 
            // txtBoxEposta
            // 
            this.txtBoxEposta.Location = new System.Drawing.Point(212, 179);
            this.txtBoxEposta.Name = "txtBoxEposta";
            this.txtBoxEposta.Size = new System.Drawing.Size(271, 20);
            this.txtBoxEposta.TabIndex = 70;
            // 
            // txttrenid
            // 
            this.txttrenid.Location = new System.Drawing.Point(736, 303);
            this.txttrenid.Name = "txttrenid";
            this.txttrenid.Size = new System.Drawing.Size(271, 20);
            this.txttrenid.TabIndex = 69;
            // 
            // txtvagonid
            // 
            this.txtvagonid.Location = new System.Drawing.Point(736, 265);
            this.txtvagonid.Name = "txtvagonid";
            this.txtvagonid.Size = new System.Drawing.Size(271, 20);
            this.txtvagonid.TabIndex = 68;
            // 
            // txtsubeid
            // 
            this.txtsubeid.Location = new System.Drawing.Point(736, 225);
            this.txtsubeid.Name = "txtsubeid";
            this.txtsubeid.Size = new System.Drawing.Size(271, 20);
            this.txtsubeid.TabIndex = 67;
            // 
            // txtmusteriid
            // 
            this.txtmusteriid.Location = new System.Drawing.Point(736, 93);
            this.txtmusteriid.Name = "txtmusteriid";
            this.txtmusteriid.Size = new System.Drawing.Size(271, 20);
            this.txtmusteriid.TabIndex = 66;
            // 
            // txthareketid
            // 
            this.txthareketid.Location = new System.Drawing.Point(736, 177);
            this.txthareketid.Name = "txthareketid";
            this.txthareketid.Size = new System.Drawing.Size(271, 20);
            this.txthareketid.TabIndex = 65;
            // 
            // txttarifeid
            // 
            this.txttarifeid.Location = new System.Drawing.Point(736, 130);
            this.txttarifeid.Name = "txttarifeid";
            this.txttarifeid.Size = new System.Drawing.Size(271, 20);
            this.txttarifeid.TabIndex = 64;
            // 
            // txtbiletid
            // 
            this.txtbiletid.Location = new System.Drawing.Point(736, 50);
            this.txtbiletid.Name = "txtbiletid";
            this.txtbiletid.Size = new System.Drawing.Size(271, 20);
            this.txtbiletid.TabIndex = 63;
            // 
            // txtBoxTelNo
            // 
            this.txtBoxTelNo.Location = new System.Drawing.Point(212, 134);
            this.txtBoxTelNo.Name = "txtBoxTelNo";
            this.txtBoxTelNo.Size = new System.Drawing.Size(271, 20);
            this.txtBoxTelNo.TabIndex = 62;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Location = new System.Drawing.Point(212, 92);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(271, 20);
            this.txtBoxSoyad.TabIndex = 61;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(212, 52);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(271, 20);
            this.txtBoxAd.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 47;
            this.label1.Text = "Sefer Tarihi";
            // 
            // lblBiletTur
            // 
            this.lblBiletTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiletTur.Location = new System.Drawing.Point(54, 274);
            this.lblBiletTur.Name = "lblBiletTur";
            this.lblBiletTur.Size = new System.Drawing.Size(152, 40);
            this.lblBiletTur.TabIndex = 48;
            this.lblBiletTur.Text = "Bilet Türü";
            // 
            // lblEposta
            // 
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEposta.Location = new System.Drawing.Point(54, 172);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(152, 40);
            this.lblEposta.TabIndex = 49;
            this.lblEposta.Text = "E-Posta";
            // 
            // lblTelNo
            // 
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.Location = new System.Drawing.Point(54, 132);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(152, 40);
            this.lblTelNo.TabIndex = 50;
            this.lblTelNo.Text = "Telefon Numarası";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.Location = new System.Drawing.Point(54, 212);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(152, 40);
            this.lblCinsiyet.TabIndex = 51;
            this.lblCinsiyet.Text = "Cinsiyeti";
            // 
            // lblSubeID
            // 
            this.lblSubeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubeID.Location = new System.Drawing.Point(597, 225);
            this.lblSubeID.Name = "lblSubeID";
            this.lblSubeID.Size = new System.Drawing.Size(152, 40);
            this.lblSubeID.TabIndex = 58;
            this.lblSubeID.Text = "subeID";
            // 
            // lblHareketID
            // 
            this.lblHareketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHareketID.Location = new System.Drawing.Point(597, 177);
            this.lblHareketID.Name = "lblHareketID";
            this.lblHareketID.Size = new System.Drawing.Size(152, 40);
            this.lblHareketID.TabIndex = 52;
            this.lblHareketID.Text = "hareketID";
            // 
            // lblTarifeID
            // 
            this.lblTarifeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifeID.Location = new System.Drawing.Point(597, 130);
            this.lblTarifeID.Name = "lblTarifeID";
            this.lblTarifeID.Size = new System.Drawing.Size(152, 40);
            this.lblTarifeID.TabIndex = 53;
            this.lblTarifeID.Text = "tarifeID";
            // 
            // lbltrenid
            // 
            this.lbltrenid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrenid.Location = new System.Drawing.Point(597, 301);
            this.lbltrenid.Name = "lbltrenid";
            this.lbltrenid.Size = new System.Drawing.Size(152, 40);
            this.lbltrenid.TabIndex = 54;
            this.lbltrenid.Text = "trenID";
            // 
            // lblVagonID
            // 
            this.lblVagonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagonID.Location = new System.Drawing.Point(597, 265);
            this.lblVagonID.Name = "lblVagonID";
            this.lblVagonID.Size = new System.Drawing.Size(152, 40);
            this.lblVagonID.TabIndex = 55;
            this.lblVagonID.Text = "vagonID";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteriID.Location = new System.Drawing.Point(597, 90);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(152, 40);
            this.lblMusteriID.TabIndex = 56;
            this.lblMusteriID.Text = "musteriID";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyadi.Location = new System.Drawing.Point(54, 92);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(152, 40);
            this.lblSoyadi.TabIndex = 57;
            this.lblSoyadi.Text = "Soyadı";
            // 
            // lblBiletID
            // 
            this.lblBiletID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiletID.Location = new System.Drawing.Point(597, 50);
            this.lblBiletID.Name = "lblBiletID";
            this.lblBiletID.Size = new System.Drawing.Size(152, 40);
            this.lblBiletID.TabIndex = 59;
            this.lblBiletID.Text = "biletID";
            // 
            // lblAdi
            // 
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdi.Location = new System.Drawing.Point(54, 52);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(152, 40);
            this.lblAdi.TabIndex = 46;
            this.lblAdi.Text = "Adı";
            // 
            // BiletiAcigaAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsefertarih);
            this.Controls.Add(this.txtBoxEposta);
            this.Controls.Add(this.txttrenid);
            this.Controls.Add(this.txtvagonid);
            this.Controls.Add(this.txtsubeid);
            this.Controls.Add(this.txtmusteriid);
            this.Controls.Add(this.txthareketid);
            this.Controls.Add(this.txttarifeid);
            this.Controls.Add(this.txtbiletid);
            this.Controls.Add(this.txtBoxTelNo);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBiletTur);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSubeID);
            this.Controls.Add(this.lblHareketID);
            this.Controls.Add(this.lblTarifeID);
            this.Controls.Add(this.lbltrenid);
            this.Controls.Add(this.lblVagonID);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblBiletID);
            this.Controls.Add(this.lblAdi);
            this.Name = "BiletiAcigaAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiletiAcigaAl";
            this.Load += new System.EventHandler(this.BiletiAcigaAl_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnBusiness;
        private System.Windows.Forms.RadioButton rdBtnEkonomi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnErkek;
        private System.Windows.Forms.RadioButton rdBtnKadin;
        private System.Windows.Forms.TextBox txtsefertarih;
        private System.Windows.Forms.TextBox txtBoxEposta;
        private System.Windows.Forms.TextBox txttrenid;
        private System.Windows.Forms.TextBox txtvagonid;
        private System.Windows.Forms.TextBox txtsubeid;
        private System.Windows.Forms.TextBox txtmusteriid;
        private System.Windows.Forms.TextBox txthareketid;
        private System.Windows.Forms.TextBox txttarifeid;
        private System.Windows.Forms.TextBox txtbiletid;
        private System.Windows.Forms.TextBox txtBoxTelNo;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBiletTur;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSubeID;
        private System.Windows.Forms.Label lblHareketID;
        private System.Windows.Forms.Label lblTarifeID;
        private System.Windows.Forms.Label lbltrenid;
        private System.Windows.Forms.Label lblVagonID;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblBiletID;
        private System.Windows.Forms.Label lblAdi;
    }
}