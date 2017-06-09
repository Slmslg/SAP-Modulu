using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{    
    class SinifFirma:Araclar,CRUD
    {
        public ModelFirma mfirma;

        public bool Ekle()
        {
            cmd = new SqlCommand("insert into FIRMALAR(FirmaAdi,Adres,Telefon) values(@ad,@adres,@telefon)", baglan);
            cmd.Parameters.AddWithValue("@ad",mfirma.FirmaAd);
            cmd.Parameters.AddWithValue("@adres", mfirma.FirmaAdres);
            cmd.Parameters.AddWithValue("@telefon", mfirma.FirmaTelefon);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update FIRMALAR set FirmaAdi=@ad,Adres=@adres,Telefon=@telefon where FirmaID=@id ", baglan);
            cmd.Parameters.AddWithValue("@ad", mfirma.FirmaAd);
            cmd.Parameters.AddWithValue("@adres", mfirma.FirmaAdres);
            cmd.Parameters.AddWithValue("@telefon", mfirma.FirmaTelefon);
            cmd.Parameters.AddWithValue("@id", mfirma.FirmaId);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from FIRMALAR where FirmaID=@id", baglan);
            cmd.Parameters.AddWithValue("@id", mfirma.FirmaId);
            return cmdCalistir();
        }
    }
}
