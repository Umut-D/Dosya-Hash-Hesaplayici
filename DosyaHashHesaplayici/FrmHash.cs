using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashLibrary;
using HashLibrary.Hash;

namespace HashUI
{
    public partial class FrmHash : Form
    {
        public FrmHash()
        {
            InitializeComponent();
        }

        private void BtnDosyaAc_Click(object sender, EventArgs e)
        {
            TboxDegerleriniSil();
            TboxRenkleriniSifirla();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string dosyaAdi = openFileDialog.FileName;
                    DosyaAdiniGoster(dosyaAdi);
                    HashDegerleri(dosyaAdi);
                }
                catch (Exception)
                {
                    throw new GenelHata();
                }
            }
        }

        private void TboxDegerleriniSil()
        {
            txtMd5.Text = string.Empty;
            txtSha1.Text = string.Empty;
            txtKarsilastir.Text = string.Empty;
        }

        private void TboxRenkleriniSifirla()
        {
            foreach (TextBox textBox in AramaYapilanTextBoxlar())
                textBox.BackColor = DefaultBackColor;
        }

        private List<TextBox> AramaYapilanTextBoxlar()
        {
            return new List<TextBox>
            {
                txtMd5, txtSha1
            };
        }

        private void DosyaAdiniGoster(string dosyaAdi)
        {
            txtDosyaAdi.Text = Path.GetFileName(dosyaAdi);
        }

        private async void HashDegerleri(string dosyaAdi)
        {
            Dosya dosya = new Dosya(dosyaAdi);
            Text = @"İşlem Devam Ediyor. Bekleyiniz...";

            await HashIslemleri(dosya);

            Task.WaitAll();
            Text = @"Tamamlandı";
        }

        private async Task HashIslemleri(Dosya dosya)
        {
            txtMd5.Text = await Task.Run(() => HashBul(new Md5(), dosya));
            txtSha1.Text = await Task.Run(() => HashBul(new Sha1(), dosya));
        }

        private string HashBul(IHashable hash, Dosya dosya)
        {
            return hash.Hesapla(dosya);
        }

        private void LblDosyaAc_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void LblDosyaAc_DragDrop(object sender, DragEventArgs e)
        {
            TboxDegerleriniSil();
            TboxRenkleriniSifirla();

            try
            {
                var surukleBirakDosyasi = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                DosyaAdiniGoster(surukleBirakDosyasi[0]);
                HashDegerleri(surukleBirakDosyasi[0]);
            }
            catch (Exception)
            {
                throw new GenelHata();
            }
        }

        private void TxtKarsilastir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtKarsilastir.Text != string.Empty)
            {
                TboxRenkleriniSifirla();

                string arananHash = txtKarsilastir.Text.Trim();
                IEnumerable<TextBox> aramaKriteri = AramaYapilanTextBoxlar()
                    .Where(t => t.Text.StartsWith(arananHash));

                foreach (var textBox in aramaKriteri)
                    textBox.BackColor = Color.GreenYellow;
            }
        }

        private void TxtKarsilastir_TextChanged(object sender, EventArgs e)
        {
            TxtKarsilastir_KeyDown(this, new KeyEventArgs(Keys.Enter));
        }
    }
}