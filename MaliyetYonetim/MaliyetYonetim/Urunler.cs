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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
            Show();
        }

        SinifUrunler urunler;
        Araclar arac;
        private void button1_Click(object sender, EventArgs e)
        {
            if (urunler == null)
            {
                urunler = new SinifUrunler();
                urunler.murunler = new ModelUrunler();
            }
            urunler.murunler.Aciklama = richTextBox1.Text;
            urunler.murunler.Urunad = textBox2.Text;
            urunler.murunler.Birimfiyat = textBox1.Text;
            urunler.murunler.Tur = comboBox1.Text;

            if (button1.Text == "KAYDET")
            {
                if (urunler.Ekle())
                {
                    MessageBox.Show("Ürün Eklendi");
                    listeYenile();
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                if (urunler.Guncelle())
                {
                    MessageBox.Show("Ürün Güncellendi");
                    button1.Text = "KAYDET";
                    listeYenile();
                }
                else MessageBox.Show("Hata");
            }
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            listeYenile();
            new cmbTur(comboBox1);
        }
        void listeYenile() { new AracUrunler(dataGridView1); }

        ComboBoxItem cbi;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.Count - 2)
            {
                urunler = new SinifUrunler();
                urunler.murunler = new ModelUrunler();
                urunler.murunler.Urunid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                urunler.murunler.Turid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                richTextBox1.Text = urunler.murunler.Aciklama = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox2.Text = urunler.murunler.Urunad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = urunler.murunler.Birimfiyat = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                // comboBox1.Text = urunler.murunler.Tur = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                new Araclar().comboIndexSelect(comboBox1, urunler.murunler.Tur, true);

                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    cbi = (ComboBoxItem)comboBox1.Items[i];
                    if (cbi.Value.ToString() == urunler.murunler.Turid)
                    {
                        comboBox1.SelectedIndex = i;

                    }
                }


                button1.Text = "GÜNCELLE";
            }
            else if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                urunler = new SinifUrunler();
                urunler.murunler = new ModelUrunler();
                urunler.murunler.Urunid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Ürün Silinsin mi?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (urunler.Sil())
                    {
                        MessageBox.Show("Ürün Silindi");
                        listeYenile();
                    }
                    else MessageBox.Show("Hata");

                }


            }
        }
    }
}
