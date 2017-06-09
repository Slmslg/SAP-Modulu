using MaliyetYonetim.Siniflar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaliyetYonetim.AracDoldur
{
    class AracSatis:Araclar
    {
        public void SatisDataGrid(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new SqlCommand("select SatisID,s.UrunID,s.MusteriID,s.FirmaId,u.UrunAd,Adet,Tutar,s.Aciklama,case s.FirmaId WHEN '0' THEN '-----' else (select FirmaAdi from FIRMALAR where FirmaId=s.FirmaId) END as Firma,case s.MusteriID WHEN '0' THEN '-----' else (select MusteriAd from MUSTERILER where MusteriID=s.MusteriID) END as Müşteri  from SATIS as s inner join URUNLER as u on s.UrunID=u.UrunID", baglan);
            da = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            dg.Columns[1].Visible = false;
            dg.Columns[2].Visible = false;
            dg.Columns[3].Visible = false;
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
       
        public ComboBox Firmalar(ComboBox combobox)
        {
            combobox.DisplayMember = null;
            combobox.ValueMember = null;
            combobox.DataSource = null;
            cmd = new SqlCommand("SELECT * FROM FIRMALAR", baglan);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "FIRMALAR");
            combobox.DisplayMember = "FirmaAdi";
            combobox.ValueMember = "FirmaID";
            combobox.DataSource = ds.Tables["FIRMALAR"];
            return combobox;
        }
        public ComboBox Musteriler(ComboBox combobox)
        {
            combobox.DisplayMember = null;
            combobox.ValueMember = null;
            combobox.DataSource = null;
            cmd = new SqlCommand("SELECT * FROM MUSTERILER", baglan);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "MUSTERILER");
            combobox.DisplayMember = "MusteriAd";
            combobox.ValueMember = "MusteriID";
            combobox.DataSource = ds.Tables["MUSTERILER"];
            return combobox;
        }
        public string bf;
        public ComboBox Urunler(ComboBox combobox)
        {
            cmd = new SqlCommand("SELECT * FROM URUNLER", baglan);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "URUNLER");
            combobox.DisplayMember = "UrunAd";
            combobox.ValueMember = "UrunID";
            combobox.DataSource = ds.Tables["URUNLER"];
            bf = "BirimFiyat";
            return combobox;
        }
    }
}
