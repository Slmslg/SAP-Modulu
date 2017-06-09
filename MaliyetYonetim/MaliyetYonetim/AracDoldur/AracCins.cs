﻿using MaliyetYonetim.Siniflar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaliyetYonetim.AracDoldur
{
    class AracCins:Araclar
    {
        public void CinsDataGrid(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new SqlCommand("select tc.TurCinsId,t.TurId,c.CinsId,t.TurAd,c.CinsAd,c.Acıklama from TurCins as tc inner join Cins as c on tc.CinsId=c.CinsId inner join TUR as t on tc.TurId=t.TurID", baglan);
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
