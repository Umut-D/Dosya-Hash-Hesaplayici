using System.IO;

namespace HashLibrary
{
    public abstract class Hash
    {
        public Stream DosyaOku { get; }
        protected byte[] HashHesapla { get; set; }
        private string _sonuc;

        public string Sonuc
        {
            get => _sonuc.Replace("-", "");
            set => _sonuc = value;
        }

        protected Hash(string dosyaAdi)
        {
            DosyaOku = new FileStream(dosyaAdi, FileMode.Open, FileAccess.Read);
        }

        public abstract void Hesapla();
    }
}