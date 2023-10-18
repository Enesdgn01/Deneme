using Metotlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metotlar
{

    class SepetManager
    {
        public string Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi. :" + urun.Adi);
            return "merhaba";
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler Sepete Eklendi. :" + urunAdi);

        }
    }
}
