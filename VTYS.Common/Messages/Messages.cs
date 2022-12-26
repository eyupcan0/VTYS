using System.Windows.Forms;

namespace VTYS.Messages
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            MessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void UyariMesaji(string UyariMesaji)
        {
            MessageBox.Show(UyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void BilgiMesaji(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        public static DialogResult HayirSeciliEvethayir(string mesaj, string baslik)
        {
            return MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        public static DialogResult EvetSeciliEvethayirIptal(string mesaj, string baslik)
        {
            return MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        public static DialogResult SilMesaj()
        {
            return HayirSeciliEvethayir("Seçili Olan Kayıt Silinecektir. Onaylıyor Musunuz?", "Silme Onayı");
        }
        public static DialogResult SilMesaj(string mesaj)
        {
            return HayirSeciliEvethayir(mesaj, "Silme Onayı");
        }
        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvethayirIptal("Yapılan değişiklikler Kayıt Edilsin Mi?", "Çıkış Onay");
        }
        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Edilsin Mi?", "Kayıt Onay");
        }
        public static DialogResult OnayMesaj(string mesaj)
        {
            return EvetSeciliEvetHayir(mesaj, "Onay Mesaj");
        }
        public static DialogResult KayitMesaj(string mesaj)
        {
            return EvetSeciliEvetHayir(mesaj, "Kayıt Onay");
        }
        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen Bir Kart Seçiniz");
        }
        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            HataMesaji($"Girmiş Olduğunuz {alanAdi} Daha Önce Kullanılmıştır.");
        }
        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo {dosyaFormati} Olarak Dışarı Aktarılacaktır Onaylıyor Musunuz?", "Aktarım Onay");
        }
    }

}
