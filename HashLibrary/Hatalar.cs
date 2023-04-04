using System;
using System.Windows.Forms;

namespace HashLibrary
{
    public class GenelHata : Exception
    {
        public GenelHata()
        {
            MessageBox.Show("@Açmak istediğiniz dosyada sorun olabileceği gibi, dosya kullanımda da olabilir", @"Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}