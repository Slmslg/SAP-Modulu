using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaliyetYonetim.Siniflar
{
    class Araclar
    {

        public Araclar()
        {
            baglan = new SqlConnection(@"Data Source=.;Initial Catalog=MALIYET_YONETIMI;Integrated Security=True");
        }
        // Global Tanımlamalar

        public SqlCommand cmd;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public DataTable dt;
        public DataSet ds;
        public SqlConnection baglan;

        //////////////////////

        public bool islemsonuc = false;
        public bool cmdCalistir()
        {
            islemsonuc = false;
            baglan.Open();
            try
            {
                cmd.ExecuteNonQuery();
                islemsonuc = true;
            }
            catch (Exception) { }
            baglan.Close();
            return islemsonuc;
        }
       // ComboBoxItem cbi;
        public ComboBoxItem cbi;
        public void ComboboxDoldur(ComboBox cmb,DataTable dt) {
            cmb.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbi = new ComboBoxItem();
                cbi.Text = dt.Rows[i][1].ToString();
                cbi.Value= dt.Rows[i][0].ToString();
            }
        }



      

        public void comboIndexSelect(ComboBox cmb, string deger, bool textfalsevaluetrue)
        {
            ComboBoxItem cbi;
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if (textfalsevaluetrue)
                {
                    cbi = (ComboBoxItem)cmb.Items[i];
                    if (cbi.Value.ToString() == deger)
                    {
                        cmb.SelectedIndex = i;
                    }
                }
                else
                {
                    cbi = new ComboBoxItem();
                    cbi.Text = cmb.Items[i].ToString();
                    if (cbi.Text.ToString() == deger)
                    {
                        cmb.SelectedIndex = i;
                    }
                }
            }
        }
    }
   
}
