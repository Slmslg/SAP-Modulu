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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show();
        }
        SinifAnasayfa anasayfa;
        private void Form1_Load(object sender, EventArgs e)
        {
            anasayfa = new SinifAnasayfa();
            anasayfa.grafikSatis();
            anasayfa.GrafikGoruntule(chart1);
            anasayfa.grafikSiparis();
            anasayfa.GrafikGoruntule(chart2);
            anasayfa.grafikGelir();
            anasayfa.GrafikGoruntule(chart3);
            anasayfa.grafikGider();
            anasayfa.GrafikGoruntule(chart4);
        }
    }
}
