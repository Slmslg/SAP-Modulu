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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
            Show();
        }

        SinifSatis sinifsatis;
        cmbUrun urun;
        double birimfiyat=1,adet=0;
        //AracDoldur arac = new AracDoldur();
        private void Satis_Load(object sender, EventArgs e)
        {

            new AracSatis().SatisDataGrid(dataGridView1);
            urun=new cmbUrun(comboBox2);

            //AracDoldur.cmbUrun(comboBox2);
            
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "GÜNCELLE")
            {               
                sinifsatis = new SinifSatis();
                sinifsatis.msatis = new ModelSatis();
                sinifsatis.msatis.MusteriId ="";
                sinifsatis.msatis.FirmaId = "";
                if (radioButton1.Checked == true)
                {
                    sinifsatis.msatis.FirmaId = comboBox1.SelectedValue.ToString();
                    //cbi = (ComboBoxItem)comboBox1.SelectedItem;
                    //sinifsatis.msatis.FirmaId = cbi.Value.ToString();
                }
                else
                    sinifsatis.msatis.FirmaId = "0";

                if (radioButton2.Checked == true)
                {
                    sinifsatis.msatis.MusteriId = comboBox1.SelectedValue.ToString();
                    //cbi = (ComboBoxItem)comboBox1.SelectedItem;
                    //sinifsatis.msatis.MusteriId = cbi.Value.ToString();
                }
                else
                    sinifsatis.msatis.MusteriId = "0";
                cbi = (ComboBoxItem)comboBox2.SelectedItem;
                sinifsatis.msatis.UrunId = cbi.Value.ToString();
                
                sinifsatis.msatis.Tarih = dateTimePicker1.Value.ToString("dd/MM/yyyy");  
                sinifsatis.msatis.Adet = txtAdet.Text;
                sinifsatis.msatis.Tutar =textBox1.Text=Convert.ToString( double.Parse( sinifsatis.msatis.Adet)*birimfiyat);
                sinifsatis.msatis.Aciklama = richTextBox1.Text;

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (sinifsatis.Ekle())
                {
                    MessageBox.Show("Satışınız Eklenmiştir");
                    Temizle();
                    new AracSatis().SatisDataGrid(dataGridView1);
                }
                else MessageBox.Show("Hata");
            }
            else
            {

               
               
                sinifsatis.msatis.SatisId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sinifsatis.msatis.Tarih = dateTimePicker1.Value.ToString("dd-MM-yyyy"); 
                sinifsatis.msatis.Adet = txtAdet.Text;
                sinifsatis.msatis.Tutar = textBox1.Text;
                sinifsatis.msatis.Aciklama = richTextBox1.Text;
                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (sinifsatis.Guncelle())
                {
                    MessageBox.Show("Satışınız Guncellenmiştir");
                    new AracSatis().SatisDataGrid(dataGridView1);
                    groupBox1.Text = "PERSONEL EKLE";
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
                if (item is ComboBox)
                    ((ComboBox)item).Text = "";
                if (item is RadioButton)
                    ((RadioButton)item).Checked = false;
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1 = new AracSatis().Firmalar(comboBox1);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1 = new AracSatis().Musteriler(comboBox1);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            adet = Double.Parse(txtAdet.Text);
            textBox1.Text = (birimfiyat * adet).ToString();
        }
        ComboBoxItem cbi;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            sinifsatis = new SinifSatis();
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                sinifsatis.msatis = new ModelSatis();
                sinifsatis.msatis.SatisId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (sinifsatis.Sil())
                {
                    MessageBox.Show("Satışınız Silinmiştir");
                    new AracSatis().SatisDataGrid(dataGridView1);
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns.Count - 2)
            {
               
                sinifsatis.msatis = new ModelSatis();
                sinifsatis.msatis.SatisId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sinifsatis.msatis.UrunId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               
                
                sinifsatis.msatis.Adet = txtAdet.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();
                sinifsatis.msatis.Tutar = textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                sinifsatis.msatis.Aciklama = richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                sinifsatis.msatis.MusteriId = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sinifsatis.msatis.FirmaId = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (sinifsatis.msatis.MusteriId=="0")
                {
                    radioButton1.Enabled = true;
                    radioButton2.Checked = false;
                    radioButton2.Enabled = false;
                    radioButton1.Checked = true;
                   
                }
                else if (sinifsatis.msatis.FirmaId=="0")
                {
                    radioButton2.Enabled = true;
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                    radioButton1.Enabled = false;
                    
                }

                for (int i = 0; i < comboBox2.Items.Count; i++)
                {

                    cbi = (ComboBoxItem)comboBox2.Items[i];
                    if (cbi.Value.ToString() == sinifsatis.msatis.UrunId)
                    {
                        comboBox2.SelectedIndex = i;

                    }
                }
                comboBox2.Enabled = false;
                comboBox1.Enabled = false;
                button1.Text = "GÜNCELLE";
                groupBox1.Text = "SATIŞ GÜNCELLE";
            }
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(double.Parse(txtAdet.Text) * birimfiyat);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cmb = (ComboBoxItem)comboBox2.SelectedItem;

            birimfiyat = urun.cmbBirimFiyat(cmb);
        }
    }
}
