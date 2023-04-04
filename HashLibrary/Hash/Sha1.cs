using System;
using System.Security.Cryptography;

namespace HashLibrary.Hash
{
    public class Sha1 : IHashable
    {
        public string Hesapla(Dosya dosya)
        {
            var sha1 = SHA1.Create().ComputeHash(dosya.Oku());
            return BitConverter.ToString(sha1).TiresizYaz();
        }
    }
}