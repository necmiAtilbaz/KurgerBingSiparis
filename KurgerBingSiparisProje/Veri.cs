using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurgerBingSiparisProje
{
    public class Veri
    {
        public List<Siparis> Siparisler { get; set; } = new List<Siparis>();
        public int SiparisSirasi { get; set; }
        public List<Urun> Menuler { get; set; } = new List<Urun>();
        public List<Urun> Icecekler { get; set; } = new List<Urun>();
        public List<Urun> Burgerlar { get; set; } = new List<Urun>();
        public List<Urun> IceceklerOzel { get; set; } = new List<Urun>();
        public List<Urun> Patates { get; set; } = new List<Urun>();
        public List<Urun> Ekstralar { get; set; } = new List<Urun>();
    }
}
