using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace HashLibrary.Hash
{
    public class Sha256 : IHashable
    {
        public string Hesapla(Dosya dosya)
        {
            using (var sha256 = new SHA256Managed())
            {
                string okunanAkis = new StreamReader(dosya.Oku()).ReadToEnd();
                byte[] encoding = Encoding.UTF8.GetBytes(okunanAkis);
                return BitConverter.ToString(sha256.ComputeHash(encoding)).TiresizVeKucukHarfliYaz();
            }
        }
    }
}