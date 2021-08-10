using System;
using System.Security.Cryptography;

namespace HashLibrary
{
    public sealed class Sha1 : Hash
    {
        public Sha1(string dosyaAdi) : base(dosyaAdi)
        {
        }

        public override void Hesapla()
        {
            HashHesapla = SHA1.Create().ComputeHash(DosyaOku);
            Sonuc = BitConverter.ToString(HashHesapla);
        }
    }
}