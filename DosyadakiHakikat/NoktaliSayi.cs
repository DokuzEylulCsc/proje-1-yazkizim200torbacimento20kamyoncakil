using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class NoktaliSayi : Sayi
    {
        private double deger;
        protected override List<Sayi> sayi { get; set; } = new List<Sayi>();

        public override double Değer
        {
            get
            {
                return deger;
            }
            set
            {
                deger = value;
            }
        }

        public override int adet
        {
            get
            {
                return sayi.Count;
            }
        }

        public NoktaliSayi[] getArray()
        {
            NoktaliSayi[] temp = new NoktaliSayi[sayi.Count];
            for (int i = 0; i < sayi.Count; i++)
            {
                temp[i] = (NoktaliSayi)sayi[i];
            }
            return temp;
        }

        public override void Ekle(Sayi gelen)
        {
            sayi.Add(gelen);
        }

        public override bool Check(string s)
        {
            bool noktaVarMı = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    if (!(s[i] == '-') && !(s[i] >= '0' && s[i] <= '9'))
                    {
                        return false;
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        if (s[0] == '-' && s[i] == '.')
                        {
                            return false;
                        }
                    }
                    if (!(s[i] >= '0' && s[i] <= '9') && !(s[i] == '.'))
                    {
                        return false;
                    }
                    if ((s[i] == '.'))
                    {
                        if (noktaVarMı) return false;
                        else noktaVarMı = true;
                    }
                }
            }
            if (noktaVarMı) return true;
            else return false;
        }
    }
}
