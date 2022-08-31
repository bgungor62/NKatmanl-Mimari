using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Departman
    {
        private int ıd;
        private string ad;
        private string acıklama;

        public int Id { get => ıd; set => ıd = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Acıklama { get => acıklama; set => acıklama = value; }
    }
}
