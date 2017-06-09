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
    public partial class Tur : Form
    {
        public Tur()
        {
            InitializeComponent();
            Show();
        }

        Turler tur;
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "GÜNCELLE")
            {
                tur = new Turler();
                tur.mturler = new ModelTur();
                tur.mturler.TurAd = txtTurAd.Text;
                tur.mturler.Aciklama = richTxtAciklama.Text;

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (tur.Ekle())
                {
                    MessageBox.Show("Tür Eklendi");
                    Temizle();
                    new AracTur().TurDataGrid(dataGridView1);
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                tur.mturler.TurAd = txtTurAd.Text;
                tur.mturler.Aciklama = richTxtAciklama.Text;
                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (tur.Guncelle())
                {
                    MessageBox.Show("Tur Güncellendi");
                    new AracTur().TurDataGrid(dataGridView1);
                    groupBox1.Text = "Tür Ekle";
                    button1.Text = "KAYDET";
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
            }
            return sonuc;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tur = new Turler();
            if (e.ColumnIndex==dataGridView1.Columns.Count-1)
            {
                tur.mturler = new ModelTur();
                tur.mturler.TurId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (tur.Sil())
                    MessageBox.Show("Tür Silindi");
                new AracTur().TurDataGrid(dataGridView1);

            }
            if (e.ColumnIndex==dataGridView1.Columns.Count-2)
            {
                tur.mturler = new ModelTur();
                tur.mturler.TurId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tur.mturler.TurAd = txtTurAd.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tur.mturler.Aciklama = richTxtAciklama.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                button1.Text = "GÜNCELLE";
                groupBox1.Text = "Tür Güncelle";
            }
        }

        private void Tur_Load(object sender, EventArgs e)
        {
            new AracTur().TurDataGrid(dataGridView1);

        }
    }
}
