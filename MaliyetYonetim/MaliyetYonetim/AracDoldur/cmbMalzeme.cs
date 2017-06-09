using MaliyetYonetim.Siniflar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaliyetYonetim.AracDoldur
{
    class cmbMalzeme:Araclar
    {
        public cmbMalzeme() { }
        public cmbMalzeme(ComboBox cmb)
        {
            ComboBoxItem tur;
            cmb.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select MalzemeID,MalzemeAdi from MALZEME order by MalzemeAdi asc", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tur = new ComboBoxItem();
                tur.Value = dr["MalzemeID"];
                tur.Text = dr["MalzemeAdi"].ToString();
                cmb.Items.Add(tur);
            }
            baglan.Close();
        }
    }
}
