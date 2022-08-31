using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLaayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<Personel>LLpersonellistesi()
        {
            return DALpersonel.PersonelListesi();
        }

        public static int LLpersonelEkle(Personel p)
        {
            if (p.Ad !="" && p.Soyad !="" && p.Sehir != "" && p.Gorevi != "" && p.Maas >= 6000)
            {
                return DALpersonel.PersonelEKle(p);
            }
            else
            {
                return -1;
                
            }
        }

        public static bool Guncelle(Personel pg)
        {
            if (pg.Ad.Length>5 )
            {
                return DALpersonel.PersonelGuncelle(pg);
            }
            else
            {
                return false;
            }
        }
    }
}
