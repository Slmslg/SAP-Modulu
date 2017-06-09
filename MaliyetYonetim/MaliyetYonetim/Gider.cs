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
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
            Show();
        }
        Giderler gider;
      
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
        private void Gider_Load(object sender, EventArgs e)
        {
            new AracGiderler().GiderlerDataGrid(dtGridGider);
            anasayfa = new SinifAnasayfa();
            anasayfa.grafikGider();
            anasayfa.GrafikGoruntule(chart1);
        }

        private void dtGridGider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gider = new Giderler();
            if (e.ColumnIndex == dtGridGider.Columns.Count - 1)
            {
                gider.mgiderler = new ModelGider();
                gider.mgiderler.GiderID = dtGridGider.CurrentRow.Cells[0].Value.ToString();
                if (gider.Sil())
                    MessageBox.Show("Gider Silindi");
                new AracGiderler().GiderlerDataGrid(dtGridGider);
                anasayfa = new SinifAnasayfa();
                anasayfa.grafikGider();
                anasayfa.GrafikGoruntule(chart1);

            }
            if (e.ColumnIndex == dtGridGider.Columns.Count - 2)
            {
                gider.mgiderler = new ModelGider();
                gider.mgiderler.GiderID = dtGridGider.CurrentRow.Cells[0].Value.ToString();
                gider.mgiderler.Tur = txtTur.Text = dtGridGider.CurrentRow.Cells[1].Value.ToString();
                gider.mgiderler.Aciklama = richTxtAciklama.Text = dtGridGider.CurrentRow.Cells[2].Value.ToString();
                gider.mgiderler.Tutar = txtTutar.Text = dtGridGider.CurrentRow.Cells[3].Value.ToString();
                gider.mgiderler.Tarih = Convert.ToString(DateTimeTarih.Value = DateTime.Parse(dtGridGider.CurrentRow.Cells[4].Value.ToString()));
                btnGiderKaydet.Text = "GÜNCELLE";
                groupBox1.Text = "Gider Güncelle";
            }
        }

        private void btnGiderKaydet_Click(object sender, EventArgs e)
        {
            if (btnGiderKaydet.Text != "GÜNCELLE")
            {
                gider = new Giderler();
                gider.mgiderler = new ModelGider();
                gider.mgiderler.Tur = txtTur.Text;
                gider.mgiderler.Tutar = txtTutar.Text;
                gider.mgiderler.Tarih = DateTimeTarih.Value.ToString("dd/MM/yyyy");
                gider.mgiderler.Aciklama = richTxtAciklama.Text;

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (gider.Ekle())
                {
                    MessageBox.Show("Gider Eklendi");
                    Temizle();
                    new AracGiderler().GiderlerDataGrid(dtGridGider);
                    anasayfa = new SinifAnasayfa();
                    anasayfa.grafikGider();
                    anasayfa.GrafikGoruntule(chart1);
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                gider.mgiderler.GiderID = dtGridGider.CurrentRow.Cells[0].Value.ToString();
                gider.mgiderler.Tur = txtTur.Text;
                gider.mgiderler.Tutar = txtTutar.Text;
                gider.mgiderler.Aciklama = richTxtAciklama.Text;
                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (gider.Guncelle())
                {
                    MessageBox.Show("Gelir Güncellendi");
                    new AracGiderler().GiderlerDataGrid(dtGridGider);
                    anasayfa = new SinifAnasayfa();
                    anasayfa.grafikGider();
                    anasayfa.GrafikGoruntule(chart1);
                    groupBox1.Text = "Gider Ekle";
                    btnGiderKaydet.Text = "KAYDET";
                    Temizle();

                }
                else MessageBox.Show("Hata");
            }
        }
    }
}
