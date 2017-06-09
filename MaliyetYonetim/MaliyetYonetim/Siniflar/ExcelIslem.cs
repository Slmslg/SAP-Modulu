using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
using LinqToExcel;
using System.Collections;
using ClosedXML.Excel;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MaliyetYonetim.Siniflar;

namespace MaliyetYonetim
{
    class ExcelIslem : Araclar
    {
        public void satisDataset()
        {//tüm liste
            baglan.Open();
            cmd = new SqlCommand("select satis.SatisID as SatisID,satis.MusteriID,satis.UrunID,mus.MusteriAd,mus.MusteriSoyad,mus.TC,urun.UrunAd,urun.BirimFiyat,urun.Tur,satis.Adet,satis.Tarih,satis.Tutar from SATIS as satis inner join URUNLER as urun on urun.UrunID=satis.UrunID inner join MUSTERILER as mus on mus.MusteriID=satis.MusteriID", baglan);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            baglan.Close();
        }

        public string dosyaadi = "";
        public void satisDisaAktar()
        {

            ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.Tables[0].TableName = dt.TableName;
            string masaustu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Guid gg = Guid.NewGuid();
            string yol = masaustu + @"\" + dosyaadi + "-" + gg.ToString().Substring(0, 11) + ".xlsx";
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(ds);
                wb.Style.Font.Bold = true;
                wb.SaveAs(yol);
            }
        }
    }
}