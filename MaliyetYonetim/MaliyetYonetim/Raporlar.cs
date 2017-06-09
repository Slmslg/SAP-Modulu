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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
            Show();
        }
        OpenFileDialog ofd;

        ExcelIslem disaaktar = new ExcelIslem();
        string dosyaad = "Satis";
        private void button3_Click(object sender, EventArgs e)
        {
            disaaktar = new ExcelIslem();
            disaaktar.satisDataset();
            disaaktar.dosyaadi = dosyaad;
            disaaktar.satisDisaAktar();
        }
        bool islem = true;

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }
    }
}
