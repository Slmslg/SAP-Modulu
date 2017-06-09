using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaliyetYonetim.Siniflar;

namespace MaliyetYonetim.AracDoldur
{
    class AracStok:Araclar
    {
        public void StokDataGrid(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new SqlCommand("select s.UrunID,u.UrunAd,s.Adet,s.Adet,s.Tarih from stok s inner join URUNLER u on s.UrunID = u.UrunID", baglan);
            da = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            dg.Columns[1].Visible = false;
            dg.Columns[2].Visible = false;
            baglan.Close();
            dataGridEkleButonu(dg);
            dataGridSilButonu(dg);
        }
        void dataGridEkleButonu(DataGridView dg)
        {
            DataGridViewButtonColumn dbuton = new DataGridViewButtonColumn();
            dbuton.HeaderText = "";
            dbuton.Text = "Düzenle";
            dbuton.UseColumnTextForButtonValue = true;
            dbuton.DefaultCellStyle.BackColor = Color.Blue;
            dbuton.DefaultCellStyle.SelectionBackColor = Color.Red;
            dbuton.Width = 70;
            dg.Columns.Add(dbuton);
        }
        void dataGridSilButonu(DataGridView dg)
        {
            DataGridViewButtonColumn dbuton = new DataGridViewButtonColumn();
            dbuton = new DataGridViewButtonColumn();
            dbuton.HeaderText = "";
            dbuton.Text = "Sil";
            dbuton.UseColumnTextForButtonValue = true;
            dbuton.DefaultCellStyle.BackColor = Color.Blue;
            dbuton.DefaultCellStyle.SelectionBackColor = Color.Red;
            dbuton.Width = 70;
            dg.Columns.Add(dbuton);
        }
    }
}
