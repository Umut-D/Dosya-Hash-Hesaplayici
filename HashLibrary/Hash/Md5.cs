using System;
using System.Security.Cryptography;

namespace HashLibrary.Hash
{
    public class Md5 : IHashable
    {
        public string Hesapla(Dosya dosya)
        {
            var md5 = MD5.Create().ComputeHash(dosya.Oku());
            return BitConverter.ToString(md5).TiresizVeKucukHarfliYaz();
        }
    }
}