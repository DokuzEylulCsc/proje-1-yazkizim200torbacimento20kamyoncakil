using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class TamSayi : Sayi
    {
        public override List<object> sayi { get; set; } = new List<object>();

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
