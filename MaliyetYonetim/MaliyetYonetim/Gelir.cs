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
using MaliyetYonetim.AracDoldur;

namespace MaliyetYonetim
{
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
            Show();
        }
        Gelirler gelir;
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text != "GÜNCELLE")
            {
                gelir = new Gelirler();
                gelir.mgelir = new ModelGelir();
                //ComboBoxItem model = (ComboBoxItem)cm.Items[cmboxTur.SelectedIndex];
                //cins.mturcins.TurId = model.Value.ToString();
                gelir.mgelir.Tur = txtTur.Text;
                gelir.mgelir.Tutar = txtTutar.Text;
                gelir.mgelir.Tarih = DateTimeTarih.Value.ToString("dd/MM/yyyy");
                gelir.mgelir.Aciklama = richTxtAciklama.Text;

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (gelir.Ekle())
                {
                    MessageBox.Show("Gelir Eklendi");
                    Temizle();
                    new AracGelirler().GelirlerDataGrid(dtGridGelir);
                    anasayfa = new SinifAnasayfa();
                    anasayfa.grafikGelir();
                    anasayfa.GrafikGoruntule(chart1);
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                gelir.mgelir.GelirID = dtGridGelir.CurrentRow.Cells[0].Value.ToString();
                gelir.mgelir.Tur = txtTur.Text;
                gelir.mgelir.Tutar = txtTutar.Text;
                gelir.mgelir.Aciklama = richTxtAciklama.Text;
                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (gelir.Guncelle())
                {
                    MessageBox.Show("Gelir Güncellendi");
                    new AracGelirler().GelirlerDataGrid(dtGridGelir);
                    anasayfa = new SinifAnasayfa();
                    anasayfa.grafikGelir();
                    anasayfa.GrafikGoruntule(chart1);
                    groupBox1.Text = "Gelir Ekle";
                    btnKaydet.Text = "KAYDET";
                    Temizle();

                }
                else MessageBox.Show("Hata");
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
        SinifAnasayfa anasayfa;

        private void Gelir_Load(object sender, EventArgs e)
        {
            new AracGelirler().GelirlerDataGrid(dtGridGelir);
            anasayfa = new SinifAnasayfa();
            anasayfa.grafikGelir();
            anasayfa.GrafikGoruntule(chart1);
        }

      
        private void dtGridGelir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gelir = new Gelirler();
            if (e.ColumnIndex == dtGridGelir.Columns.Count - 1)
            {
                gelir.mgelir = new ModelGelir();
                gelir.mgelir.GelirID = dtGridGelir.CurrentRow.Cells[0].Value.ToString();
                if (gelir.Sil())
                    MessageBox.Show("Gelir Silindi");
                new AracGelirler().GelirlerDataGrid(dtGridGelir);
                anasayfa = new SinifAnasayfa();
                anasayfa.grafikGelir();
                anasayfa.GrafikGoruntule(chart1);

            }
            if (e.ColumnIndex == dtGridGelir.Columns.Count - 2)
            {
                gelir.mgelir = new ModelGelir();
                gelir.mgelir.GelirID = dtGridGelir.CurrentRow.Cells[0].Value.ToString();
                gelir.mgelir.Tur =txtTur.Text = dtGridGelir.CurrentRow.Cells[1].Value.ToString();
                gelir.mgelir.Aciklama = richTxtAciklama.Text = dtGridGelir.CurrentRow.Cells[2].Value.ToString();
                gelir.mgelir.Tutar = txtTutar.Text = dtGridGelir.CurrentRow.Cells[3].Value.ToString();
                gelir.mgelir.Tarih = Convert.ToString(DateTimeTarih.Value = DateTime.Parse(dtGridGelir.CurrentRow.Cells[4].Value.ToString()));
                btnKaydet.Text = "GÜNCELLE";
                groupBox1.Text = "Gelir Güncelle";
            }
        }
    }
}
