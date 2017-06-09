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
    public partial class Cins : Form
    {
        public Cins()
        {
            InitializeComponent();
            Show();
        }
        Cinsler cins;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "GÜNCELLE")
            {
                cins = new Cinsler();
                cins.mturcins = new ModelTurCins();
                ComboBoxItem model = (ComboBoxItem)cmboxTur.Items[cmboxTur.SelectedIndex];
                cins.mturcins.TurId = model.Value.ToString();
                cins.mturcins.CinsAd = txtCinsAd.Text;
                cins.mturcins.Aciklama = richTxtAciklama.Text;

                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (cins.Ekle())
                {
                    MessageBox.Show("Cins Eklendi");
                    Temizle();
                    new AracTur().TurDataGrid(dataGridView1);
                }
                else MessageBox.Show("Hata");
            }
            else
            {
                cins.mturcins.CinsId = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cins.mturcins.CinsAd = txtCinsAd.Text;
                cins.mturcins.Aciklama = richTxtAciklama.Text;
                if (txtKontrol())
                {
                    MessageBox.Show("Alanları Doldurunuz");
                    return;
                }
                if (cins.Guncelle())
                {
                    MessageBox.Show("Cins Güncellendi");
                    new AracCins().CinsDataGrid(dataGridView1);
                    groupBox1.Text = "Cins Ekle";
                    button1.Text = "KAYDET";
                    Temizle();
                    new cmbTur(cmboxTur);
                }
                else MessageBox.Show("Hata");
            }
        }

        private void Cins_Load(object sender, EventArgs e)
        {
            new cmbTur(cmboxTur);
            new AracCins().CinsDataGrid(dataGridView1);
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

        
        ComboBoxItem cbi;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cins = new Cinsler();
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                cins.mturcins = new ModelTurCins();
                cins.mturcins.CinsId = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (cins.Sil())
                    MessageBox.Show("Cins Silindi");
                new AracCins().CinsDataGrid(dataGridView1);

            }
            if (e.ColumnIndex == dataGridView1.Columns.Count - 2)
            {
                cins.mturcins = new ModelTurCins();
                cins.mturcins.TurId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cins.mturcins.CinsId = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cins.mturcins.CinsAd = txtCinsAd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cins.mturcins.Aciklama = richTxtAciklama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                for (int i = 0; i < cmboxTur.Items.Count; i++)
                {
                    cbi = (ComboBoxItem)cmboxTur.Items[i];
                    if (cbi.Value.ToString() == cins.mturcins.TurId)
                    {
                        cmboxTur.SelectedIndex = i;
                       
                    }
                }
                button1.Text = "GÜNCELLE";
                groupBox1.Text = "Cins Güncelle";




              
                
            }
        }
    }
}
