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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
            Show();
        }
        SinifPersonel sinifpersonel;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "GÜNCELLE")
            {
                sinifpersonel = new SinifPersonel();
                sinifpersonel.mpersonel = new ModelPersonel();
                sinifpersonel.mpersonel.Ad = textBox1.Text;
                sinifpersonel.mpersonel.Soyad = textBox2.Text;
                sinifpersonel.mpersonel.TC = textBox3.Text;
                sinifpersonel.mpersonel.Unvan = textBox4.Text;
                sinifpersonel.mpersonel.Maas = textBox5.Text;
                sinifpersonel.mpersonel.GirisTarihi = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (sinifpersonel.Ekle())
                {
                    MessageBox.Show("Personel Eklendi");
                    Temizle();
                    new AracPersonel().PersonelDataGrid(dataGridView1);
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                sinifpersonel.mpersonel.Ad = textBox1.Text;
                sinifpersonel.mpersonel.Soyad = textBox2.Text;
                sinifpersonel.mpersonel.TC = textBox3.Text;
                sinifpersonel.mpersonel.Unvan = textBox4.Text;
                sinifpersonel.mpersonel.Maas = textBox5.Text;
                sinifpersonel.mpersonel.GirisTarihi = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (sinifpersonel.Guncelle())
                {
                    MessageBox.Show("Personel Güncellendi");
                    new AracPersonel().PersonelDataGrid(dataGridView1);
                    groupBox1.Text = "PERSONEL EKLE";
                    button1.Text = "KAYDET";
                    Temizle();
                }
                else MessageBox.Show("Hata");
            }
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            new AracPersonel().PersonelDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sinifpersonel = new SinifPersonel();
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                sinifpersonel.mpersonel = new ModelPersonel();
                sinifpersonel.mpersonel.PersonelId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (sinifpersonel.Sil())
                    MessageBox.Show("Personel Silindi");
                new AracPersonel().PersonelDataGrid(dataGridView1);
            }
            else if (e.ColumnIndex == dataGridView1.Columns.Count - 2)
            {
                sinifpersonel.mpersonel = new ModelPersonel(); int a = 0;
                sinifpersonel.mpersonel.PersonelId = dataGridView1.CurrentRow.Cells[a].Value.ToString(); a++;
                sinifpersonel.mpersonel.Ad = textBox1.Text = dataGridView1.CurrentRow.Cells[a].Value.ToString(); a++;
                sinifpersonel.mpersonel.Soyad = textBox2.Text = dataGridView1.CurrentRow.Cells[a].Value.ToString(); a++;
                sinifpersonel.mpersonel.TC = textBox3.Text = dataGridView1.CurrentRow.Cells[a].Value.ToString(); a++;
                sinifpersonel.mpersonel.Unvan = textBox4.Text = dataGridView1.CurrentRow.Cells[a].Value.ToString(); a++;
                sinifpersonel.mpersonel.Maas = textBox5.Text = dataGridView1.CurrentRow.Cells[a].Value.ToString(); a++;
                button1.Text = "GÜNCELLE";
                groupBox1.Text = "PERSONEL GÜNCELLE";
            }
        }
        void Temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
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
            }
            return sonuc;
        }
    }
}
