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
    class cmbTur:Araclar
    {
        public cmbTur() { }
        public cmbTur(ComboBox cmb)
        {
            ComboBoxItem tur;
            cmb.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select TurId,TurAd from Tur order by TurAd asc", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tur = new ComboBoxItem();
                tur.Value = dr["TurId"];
                tur.Text = dr["TurAd"].ToString();
                cmb.Items.Add(tur);
            }
            baglan.Close();
        }
        public cmbTur(ComboBox cmb, string  turad)
        {
            ComboBoxItem tur;
            cmb.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select TurId,TurAd from Tur where TurAd=@turad", baglan);
            cmd.Parameters.AddWithValue("@turad", turad);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tur = new ComboBoxItem();
                tur.Value = dr["TurId"];
                tur.Text = dr["TurAd"].ToString();
                cmb.Items.Add(tur);
            }
            baglan.Close();
        }
    }
}
