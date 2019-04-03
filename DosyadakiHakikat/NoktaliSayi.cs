using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class NoktaliSayi : Sayi
    {
        protected override List<string> sayi { get; set; } = new List<string>();

        public override int adet
        {
            get
            {
                return sayi.Count;
            }
        }

        public override void Ekle(string gelen)
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
