using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HashHesaplayici.Islem;

namespace HashHesaplayici
{
    public partial class FrmHash : Form
    {
        public FrmHash()
        {
            InitializeComponent();
        }

        private void BtnDosyaAc_Click(object sender, EventArgs e)
        {
            KarsilastirmaDegeriniSil();
            TextBoxRenkleriniSifirla();

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string dosyaAdi = openFileDialog.FileName;
                DosyaAdiniGoster(dosyaAdi);

                HashDegerleri(dosyaAdi);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Açmak istediğiniz dosyada sorun olabileceği gibi, dosya kullanımda da olabilir.",
                    @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KarsilastirmaDegeriniSil()
        {
            txtKarsilastir.Text = string.Empty;
        }

        private void TextBoxRenkleriniSifirla()
        {
            foreach (TextBox textBox in AramaYapilanTextBoxlar())
                textBox.BackColor = DefaultBackColor;
        }

        private void DosyaAdiniGoster(string dosyaAdi)
        {
            txtDosyaAdi.Text = Path.GetFileName(dosyaAdi);
        }

        private void HashDegerleri(string dosyaAdi)
        {
            HashBul(new Sha1(dosyaAdi));
            HashBul(new Md5(dosyaAdi));
        }

        private void HashBul(Hash hash)
        {
            Text = @"Devam Ediyor...";

            Thread thread = new Thread(() =>
            {
                try
                {
                    hash.Hesapla();
                }
                finally
                {
                    HashYazdir(hash);
                    Text = ProductName;
                }
            });
            thread.Start();
        }

        private void HashYazdir(Hash hash)
        {
            Invoke((Action) (() =>
            {
                if (hash.Sonuc.Length == 32)
                    txtMd5.Text = hash.Sonuc;
                else
                    txtSha1.Text = hash.Sonuc;
            }));
        }

        private void LblDosyaAc_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void LblDosyaAc_DragDrop(object sender, DragEventArgs e)
        {
            KarsilastirmaDegeriniSil();
            TextBoxRenkleriniSifirla();

            try
            {
                string[] surukleBirakDosyasi = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
                DosyaAdiniGoster(surukleBirakDosyasi[0]);

                HashDegerleri(surukleBirakDosyasi[0]);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Açmak istediğiniz dosyada sorun olabileceği gibi, dosya kullanımda da olabilir.",
                    @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKontrolEt_Click(object sender, EventArgs e)
        {
            if (txtKarsilastir.Text == string.Empty)
                return;

            ArananDegerVarMi();
        }

        private void ArananDegerVarMi()
        {
            TextBoxRenkleriniSifirla();

            string arananHash = txtKarsilastir.Text.Trim();
            IEnumerable<TextBox> aramaKriteri = AramaYapilanTextBoxlar().Where(t => t.Text.StartsWith(arananHash));
            foreach (var textBox in aramaKriteri)
                textBox.BackColor = Color.GreenYellow;
        }

        private List<TextBox> AramaYapilanTextBoxlar()
        {
            return new List<TextBox>
            {
                txtMd5, txtSha1
            };
        }

        private void TxtKarsilastir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnKontrolEt_Click(this, new EventArgs());
        }

        private void TxtKarsilastir_TextChanged(object sender, EventArgs e)
        {
            BtnKontrolEt_Click(this, new EventArgs());
        }
    }
}