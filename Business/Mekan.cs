using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public abstract class Mekan
    {

        public  string ulkeAdi { get; set; }
        public string sehirAdi { get; set; }
        public int tarih { get; set; }
        public  int fiyat { get; set; }
        public int yildiz { get; set; }

        
        




        public int Fiyat

        {
            get
            {
                return fiyat;
            }
            set
            {
                if (value >= 0 && value < 100)
                {
                    throw new ArgumentException("Bu fiyatlarda bir seyahat bulunmamaktadır.");
                }
                else
                {
                    value = fiyat;
                }
            }
        }
        
       

        
    }
}
