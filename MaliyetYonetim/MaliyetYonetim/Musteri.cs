using MaliyetYonetim.AracDoldur;
using MaliyetYonetim.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaliyetYonetim
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
            Show();
        }
        SinifMusteri sinifmusteri;
        SinifFirma siniffirma;
        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            if (btnMusteriKaydet.Text != "GÜNCELLE")
            {
                sinifmusteri = new SinifMusteri();
                sinifmusteri.mMusteri = new ModelMusteri();
                sinifmusteri.mMusteri.MusteriAd = textBox1.Text;
                sinifmusteri.mMusteri.MusteriSoyad = textBox2.Text;
                sinifmusteri.mMusteri.MusteriTC = textBox3.Text;
                sinifmusteri.mMusteri.MusteriTelefon = textBox4.Text;
                sinifmusteri.mMusteri.MusteriAdres = richTextBox1.Text;

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (sinifmusteri.Ekle())
                {
                    MessageBox.Show("Müşteri Eklendi");
                    Temizle();
                    new AracMusteri().MusteriDataGrid(dataGridView1);
                }
                else MessageBox.Show("Ekleme Hatası");
            }
            else
            {
                sinifmusteri.mMusteri.MusteriTC = textBox3.Text;
                sinifmusteri.mMusteri.MusteriAd = textBox1.Text;
                sinifmusteri.mMusteri.MusteriSoyad = textBox2.Text;
                sinifmusteri.mMusteri.MusteriAdres = richTextBox1.Text;
                sinifmusteri.mMusteri.MusteriTelefon = textBox4.Text;

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (sinifmusteri.Guncelle())
                {
                    MessageBox.Show("Müşteri Güncellendi");
                    new AracMusteri().MusteriDataGrid(dataGridView1);
                    groupBox1.Text = "MÜŞTERİ EKLE";
                    btnMusteriKaydet.Text = "KAYDET";
                    Temizle();
                }
                else MessageBox.Show("Güncelleme Hatası");
            }
        }

        void Temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is RichTextBox)
                    ((RichTextBox)item).Text = "";
                if (item is ComboBox)
                    ((ComboBox)item).Text = "";
            }
        }
        bool txtKontrol()
        {
            bool sonuc = false;
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                    if (string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        sonuc = true;
                        break;
                    }
                if (item is RichTextBox)
                    if (string.IsNullOrEmpty(((RichTextBox)item).Text))
                    {
                        sonuc = true;
                        break;
                    }
                if (item is ComboBox)
                    if (string.IsNullOrEmpty(((ComboBox)item).Text))
                    {
                        sonuc = true;
                        break;
                    }
            }
            return sonuc;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sinifmusteri = new SinifMusteri();
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                sinifmusteri.mMusteri = new ModelMusteri();
                sinifmusteri.mMusteri.MusteriId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (sinifmusteri.Sil())
                    MessageBox.Show("Müşteri Silindi");
                Temizle();
                new AracMusteri().MusteriDataGrid(dataGridView1);
            }
            else if (e.ColumnIndex == dataGridView1.Columns.Count - 2)
            {
                sinifmusteri.mMusteri = new ModelMusteri(); int i = 0;
                sinifmusteri.mMusteri.MusteriId = dataGridView1.CurrentRow.Cells[i].Value.ToString(); i++;
                sinifmusteri.mMusteri.MusteriTC = textBox3.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString(); i++;
                sinifmusteri.mMusteri.MusteriAd = textBox1.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString(); i++;
                sinifmusteri.mMusteri.MusteriSoyad = textBox2.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString(); i++;
                sinifmusteri.mMusteri.MusteriAdres = richTextBox1.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString(); i++;
                sinifmusteri.mMusteri.MusteriTelefon = textBox4.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString(); i++;
                btnMusteriKaydet.Text = "GÜNCELLE";
                groupBox1.Text = "MÜŞTERİ GÜNCELLE";
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            siniffirma = new SinifFirma();
            if (e.ColumnIndex == dataGridView2.Columns.Count - 1)
            {
                siniffirma.mfirma = new ModelFirma();
                siniffirma.mfirma.FirmaId = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                if (siniffirma.Sil())
                    MessageBox.Show("Firma Silindi");
                Temizle();
                new AracFirma().FirmaDataGrid(dataGridView2);
            }
            else if (e.ColumnIndex == dataGridView2.Columns.Count - 2)
            {
                siniffirma.mfirma = new ModelFirma(); int i = 0;
                siniffirma.mfirma.FirmaId = dataGridView2.CurrentRow.Cells[i].Value.ToString(); i++;
                siniffirma.mfirma.FirmaAd = textBox6.Text = dataGridView2.CurrentRow.Cells[i].Value.ToString(); i++;
                siniffirma.mfirma.FirmaAdres = richTextBox2.Text = dataGridView2.CurrentRow.Cells[i].Value.ToString(); i++;
                siniffirma.mfirma.FirmaTelefon = textBox5.Text = dataGridView2.CurrentRow.Cells[i].Value.ToString(); i++;
                btnFirmaEkle.Text = "GÜNCELLE";
                groupBox2.Text = "FİRMA GÜNCELLE";
            }
        }

        private void btnFirmaEkle_Click_1(object sender, EventArgs e)
        {
            if (btnFirmaEkle.Text != "GÜNCELLE")
            {
                siniffirma = new SinifFirma();
                siniffirma.mfirma = new ModelFirma();
                siniffirma.mfirma.FirmaAd = textBox6.Text;
                siniffirma.mfirma.FirmaTelefon = textBox5.Text;
                siniffirma.mfirma.FirmaAdres = richTextBox2.Text;

                if (txtKontrol2())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (siniffirma.Ekle())
                {
                    MessageBox.Show("Firma Eklendi");
                    Temizle2();
                    new AracFirma().FirmaDataGrid(dataGridView2);
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                siniffirma.mfirma.FirmaAd = textBox6.Text;
                siniffirma.mfirma.FirmaTelefon = textBox5.Text;
                siniffirma.mfirma.FirmaAdres = richTextBox2.Text;

                if (txtKontrol2())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (siniffirma.Guncelle())
                {
                    MessageBox.Show("Firma Güncellendi");
                    new AracFirma().FirmaDataGrid(dataGridView2);
                    groupBox2.Text = "FİRMA EKLE";
                    btnFirmaEkle.Text = "KAYDET";
                    Temizle2();
                }
                else MessageBox.Show("Hata");
            }
        }
        void Temizle2()
        {
            foreach (var item in groupBox2.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is RichTextBox)
                    ((RichTextBox)item).Text = "";
                if (item is ComboBox)
                    ((ComboBox)item).Text = "";
            }
        }
        bool txtKontrol2()
        {
            bool sonuc = false;
            foreach (var item in groupBox2.Controls)
            {
                if (item is TextBox)
                    if (string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        sonuc = true;
                        break;
                    }
                if (item is RichTextBox)
                    if (string.IsNullOrEmpty(((RichTextBox)item).Text))
                    {
                        sonuc = true;
                        break;
                    }
                if (item is ComboBox)
                    if (string.IsNullOrEmpty(((ComboBox)item).Text))
                    {
                        sonuc = true;
                        break;
                    }
            }
            return sonuc;
        }
        private void Musteri_Load(object sender, EventArgs e)
        {
            new AracMusteri().MusteriDataGrid(dataGridView1);
            new AracFirma().FirmaDataGrid(dataGridView2);
        }
    }
}
