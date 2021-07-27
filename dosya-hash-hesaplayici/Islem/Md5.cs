using System;
using System.Security.Cryptography;

namespace HashHesaplayici.Islem
{
    public sealed class Md5 : Hash
    {
        public Md5(string dosyaAdi) : base(dosyaAdi)
        {
        }

        public override void Hesapla()
        {
            HashHesapla = MD5.Create().ComputeHash(DosyaOku);
            Sonuc = BitConverter.ToString(HashHesapla);
        }
    }
}