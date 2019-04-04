using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class TamSayi : Sayi
    {
        private int deger;
        protected override List<Sayi> sayi { get; set; } = new List<Sayi>();

        public override double Değer
        {
            get
            {
                return deger;
            }
            set
            {
                deger = Convert.ToInt32(value);
            }
        }

        public override int adet
        {
            get
            {
                return sayi.Count;
            }
        }

        public TamSayi[] getArray()
        {
            TamSayi [] temp = new TamSayi[sayi.Count];
            for (int i = 0; i < sayi.Count; i++)
            {
                temp[i] = (TamSayi)sayi[i];
            }
            return temp;
        }

        public override void Ekle(Sayi gelen)
        {
            sayi.Add(gelen);
        }

        public override bool Check(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    if (!(s[i] == '-') && !(s[i] >= '0' && s[i] <= '9'))
                    {
                        return false;
                    }
                }
                else if (!(s[i] >= '0' && s[i] <= '9'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
