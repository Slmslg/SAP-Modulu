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
    class cmbCins:Araclar
    {
        public cmbCins() { }
        public cmbCins(ComboBox cmb)
        {
            ComboBoxItem tur;
            cmb.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select * from Cins order by CinsAd asc", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tur = new ComboBoxItem();
                tur.Value = dr["CinsId"];
                tur.Text = dr["CinsAd"].ToString();
                cmb.Items.Add(tur);
            }
            baglan.Close();
        }
        //select cins.CinsId,cins.cinsAd from TurCins as tcins inner join Tur as tur on tcins.TurId=tur.TurId inner join Cins as cins on cins.CinsId=tcins.CinsId where tur.TurID=

        public cmbCins(ComboBox cmb,string turid)
        {
            ComboBoxItem tur;
            cmb.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select cins.CinsId,cins.cinsAd from TurCins as tcins inner join Tur as tur on tcins.TurId=tur.TurId inner join Cins as cins on cins.CinsId=tcins.CinsId where tur.TurID=@turid", baglan);
            cmd.Parameters.AddWithValue("@turid",turid);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tur = new ComboBoxItem();
                tur.Value = dr["CinsId"];
                tur.Text = dr["CinsAd"].ToString();
                cmb.Items.Add(tur);
            }
            baglan.Close();
        }
    }
}
