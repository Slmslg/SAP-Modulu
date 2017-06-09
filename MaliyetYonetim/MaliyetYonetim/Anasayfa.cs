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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa3_Load(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            pnlAnasayfa.Controls.Add(f1);
            f1.Show();
            f1.Dock = DockStyle.Top;
            f1.BringToFront();
        }

        private void gELİRLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Gelir gelir = new Gelir();
            gelir.TopLevel = false;
            pnlAnasayfa.Controls.Add(gelir);
            gelir.Show();
            gelir.Dock = DockStyle.Top;
            gelir.BringToFront();
        }

        private void gİDERLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Gider gider = new Gider();
            gider.TopLevel = false;
            pnlAnasayfa.Controls.Add(gider);
            gider.Show();
            gider.Dock = DockStyle.Top;
            gider.BringToFront();
           
        }

        private void tURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Tur tur = new Tur();
            tur.TopLevel = false;
            pnlAnasayfa.Controls.Add(tur);
            tur.Show();
            tur.Dock = DockStyle.Top;
            tur.BringToFront();
        }

        private void cINSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Cins cins = new Cins();
            cins.TopLevel = false;
            pnlAnasayfa.Controls.Add(cins);
            cins.Show();
            cins.Dock = DockStyle.Top;
            cins.BringToFront();
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Personel personel = new Personel();
            personel.TopLevel = false;
            pnlAnasayfa.Controls.Add(personel);
            personel.Show();
            personel.Dock = DockStyle.Top;
            personel.BringToFront();
        }

        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Musteri musteri = new Musteri();
            musteri.TopLevel = false;
            pnlAnasayfa.Controls.Add(musteri);
            musteri.Show();
            musteri.Dock = DockStyle.Top;
            musteri.BringToFront();

        }

        private void mALZEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Malzeme malzeme = new Malzeme();
            malzeme.TopLevel = false;
            pnlAnasayfa.Controls.Add(malzeme);
            malzeme.Show();
            malzeme.Dock = DockStyle.Top;
            malzeme.BringToFront();
        }

        private void üRÜNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Urunler urun = new Urunler();
            urun.TopLevel = false;
            pnlAnasayfa.Controls.Add(urun);
            urun.Show();
            urun.Dock = DockStyle.Top;
            urun.BringToFront();
        }

        private void sTOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Stok stok = new Stok();
            stok.TopLevel = false;
            pnlAnasayfa.Controls.Add(stok);
            stok.Show();
            stok.Dock = DockStyle.Top;
            stok.BringToFront();
        }

        private void sATIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Satis satis = new Satis();
            satis.TopLevel = false;
            pnlAnasayfa.Controls.Add(satis);
            satis.Show();
            satis.Dock = DockStyle.Top;
            satis.BringToFront();
        }

        private void rAPORLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Raporlar rapor = new Raporlar();
            rapor.TopLevel = false;
            pnlAnasayfa.Controls.Add(rapor);
            rapor.Show();
            rapor.Dock = DockStyle.Top;
            rapor.BringToFront();
        }

        private void sİPARİŞLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Siparis siparis = new Siparis();
            siparis.TopLevel = false;
            pnlAnasayfa.Controls.Add(siparis);
            siparis.Show();
            siparis.Dock = DockStyle.Top;
            siparis.BringToFront();
        }

        private void mALİYETYONETİMİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAnasayfa.Controls.Clear();//formun içini temizliyoruz..
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            pnlAnasayfa.Controls.Add(f1);
            f1.Show();
            f1.Dock = DockStyle.Top;
            f1.BringToFront();
        }
    }
}
