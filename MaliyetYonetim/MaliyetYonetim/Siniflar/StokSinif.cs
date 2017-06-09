using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class StokSinif : Araclar, CRUD
    {
        public ModelStok mStok;

        public bool Ekle()
        {
            cmd = new SqlCommand("insert into STOK values(@urunID,@adet,@tarih)", baglan);
            cmd.Parameters.AddWithValue("@urunID", mStok.UrunId);
            cmd.Parameters.AddWithValue("@adet", mStok.Adet);
            cmd.Parameters.AddWithValue("@tarih", mStok.Tarih);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update STOK set UrunID=@urunID,Adet=@adet,Tarih=@tarih where StokID=@StokID ", baglan);
            cmd.Parameters.AddWithValue("@urunID", mStok.UrunId);
            cmd.Parameters.AddWithValue("@adet", mStok.Adet);
            cmd.Parameters.AddWithValue("@tarih", mStok.Tarih);
            cmd.Parameters.AddWithValue("@StokID", mStok.StokID);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from STOK where StokID=@StokID", baglan);
            cmd.Parameters.AddWithValue("@id", mStok.StokID);
            return cmdCalistir();
        }
    }
}
