using System.IO;

namespace HashLibrary
{
    public class Dosya
    {
        private readonly string _dosyaAdi;

        public Dosya(string dosyaAdi)
        {
            _dosyaAdi = dosyaAdi;
        }

        public Stream Oku()
        {
            return new FileStream(_dosyaAdi, FileMode.Open, FileAccess.Read);
        }
    }
}