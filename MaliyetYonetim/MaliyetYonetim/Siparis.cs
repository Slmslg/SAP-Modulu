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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
            Show();
        }
        SinifSiparis siparis;
        private void button1_Click(object sender, EventArgs e)
        {
            if (siparis == null)
            {
                siparis = new SinifSiparis();
                siparis.msiparis = new ModelSiparisler();
            }
            siparis.cbi = (ComboBoxItem)comboBox1.SelectedItem;
            siparis.msiparis.Malzemeid = siparis.cbi.Value.ToString();
            siparis.msiparis.Adet = numericUpDown1.Value.ToString();
            siparis.msiparis.Tarih = dateTimePicker1.Value;
            siparis.msiparis.Tahminigelistarihi = dateTimePicker2.Value;
            siparis.msiparis.Aciklama = richTextBox1.Text;
            siparis.msiparis.Tutar = textBox1.Text;
            if (button1.Text == "KAYDET")
            {
                if (siparis.Ekle())
                {
                    MessageBox.Show("Sipariş Eklendi");
                    listeYenile();
                    formTemizle();
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                if (siparis.Guncelle())
                {
                    MessageBox.Show("Sipariş Güncellendi");
                    listeYenile();
                    formTemizle();
                    button1.Text = "KAYDET";
                    siparis = null;
                }
                else MessageBox.Show("Hata");


            }
        }
       

         cmbMalzeme cmb;
        private void Siparis_Load(object sender, EventArgs e)
        {
            listeYenile();
            cmb = new cmbMalzeme(comboBox1);
            
        }
        void listeYenile()
        {
            new AracSiparis(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.Count - 2)
            {
                siparis = new SinifSiparis();
                siparis.msiparis = new ModelSiparisler();
                siparis.msiparis.Siparisid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                siparis.msiparis.Malzemeid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                siparis.msiparis.Adet = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                siparis.msiparis.Tarih = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                siparis.msiparis.Tahminigelistarihi = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                siparis.msiparis.Aciklama = richTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                siparis.msiparis.Tutar = textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker1.Value = siparis.msiparis.Tarih;
                dateTimePicker2.Value = siparis.msiparis.Tahminigelistarihi;
                numericUpDown1.Value = int.Parse(siparis.msiparis.Adet);
                new Araclar().comboIndexSelect(comboBox1, siparis.msiparis.Malzemeid, true);
                button1.Text = "GÜNCELLE";
            }
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                siparis = new SinifSiparis();
                siparis.msiparis = new ModelSiparisler();
                siparis.msiparis.Siparisid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Sipariş Silinsin mi?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (siparis.Sil())
                    {
                        MessageBox.Show("Sipariş Silindi");
                        listeYenile();
                    }
                }
            }
        }
        void formTemizle()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            richTextBox1.Text = "";
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }
    }
}
