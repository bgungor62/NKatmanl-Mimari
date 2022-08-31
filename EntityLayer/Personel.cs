using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Personel
    {
        private int id;
        private string ad;
        private string soyad;
        private string sehir;
        private string gorevi;
        private short maas;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorevi { get => gorevi; set => gorevi = value; }
        public short Maas { get => maas; set => maas = value; }
    }

}
