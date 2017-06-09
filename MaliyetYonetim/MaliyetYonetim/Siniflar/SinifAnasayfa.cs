using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class SinifAnasayfa : Araclar
    {
        public void grafikSatis()
        {
            baglan.Open();
            cmd = new SqlCommand("select tarih,sum(tutar) from satıs group by tarih order by tarih desc", baglan);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            baglan.Close();


        }
        public void grafikSiparis()
        {
            baglan.Open();
            cmd = new SqlCommand("select tarih,sum(tutar) from SIPARISLER group by tarih order by tarih desc", baglan);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            baglan.Close();


        }
        public void grafikGelir()
        {
            baglan.Open();
            cmd = new SqlCommand("select tarih,sum(tutar) from GELIRLER group by tarih order by tarih desc", baglan);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            baglan.Close();


        }
        public void grafikGider()
        {
            baglan.Open();
            cmd = new SqlCommand("select tarih,sum(tutar) from GIDERLER group by tarih order by tarih desc", baglan);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            baglan.Close();


        }
        public void GrafikGoruntule(System.Windows.Forms.DataVisualization.Charting.Chart graf)
        {
            graf.Series.Clear();
            graf.Series.Add("1");
            graf.ChartAreas[0].AxisX.Interval = 1;
            graf.Series["1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            string sutunad = "", yvalue = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                yvalue = dt.Rows[i][1].ToString();
                sutunad = DateTime.Parse(dt.Rows[i][0].ToString()).ToString("dd-MM-yyy");

                graf.Series["1"].Points.AddXY(sutunad, yvalue);
            }
            graf.Series["1"].LegendText = " ";
        }
        public string v1 = "", v2 = "";
        public bool SiparisVarmi()
        { 
            baglan.Open();
            cmd = new SqlCommand("select top 1 siparisId from SIPARISLER order by siparisId desc",baglan);
            dr = cmd.ExecuteReader(); 
            if (dr.Read()) 
                v1 = dr[0].ToString();
            baglan.Close();
            if (v1 != v2)
            {
                v2 = v1;
                return true;
            }
            else return false;
        }
    }
}
