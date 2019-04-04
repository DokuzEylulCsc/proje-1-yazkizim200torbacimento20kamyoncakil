using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class DosyaOkuma
    {
        private string s;
        private string S { get; set; }
        private int girdiAdedi = 0;
        private int GirdiAdedi { get; set; }
        TamSayi tamSayi = new TamSayi();
        NoktaliSayi noktaliSayi = new NoktaliSayi();

        public DosyaOkuma(bool b, string dosyaAdi)
        {
            while ((S = DosyaKontrol.sr.ReadLine()) != null) Console.WriteLine(s);
        }

        public DosyaOkuma(string dosyaAdi)
        {
            while ((S = DosyaKontrol.sr.ReadLine()) != null)
            {
                GirdiAdedi++;
                if (noktaliSayi.Check(S))
                {
                    NoktaliSayi temp = new NoktaliSayi();
                    temp.Değer = Convert.ToDouble(S);
                    noktaliSayi.Ekle(temp);
                }
                else if (tamSayi.Check(S))
                {
                    TamSayi temp = new TamSayi();
                    temp.Değer = Convert.ToInt32(S);
                    tamSayi.Ekle(temp);
                }
            }
                
            Log.Bitir();
        }
        public void SiraliYazdir()
        {
            IntSort intSort1 = new IntSort(tamSayi.getArray());
            IntSort intSort2 = new IntSort(noktaliSayi.getArray());
            Console.WriteLine("Sıralanmış Tam Sayi Arrayi");
            intSort1.PrintSortedArray();
            Console.WriteLine("Sıralanmış Noktali Sayi Arrayi");
            intSort2.PrintSortedArray();
        }
        public void SonucYazdir()
        {
            Console.WriteLine("Toplam Satır Adedi: " + GirdiAdedi);
            Console.WriteLine($"Geçerli Sayi Adedi: {tamSayi.adet + noktaliSayi.adet}" +
                $"(%{100 * (tamSayi.adet + noktaliSayi.adet) / GirdiAdedi})");
            Console.WriteLine($"Geçersiz Satır Adedi: {GirdiAdedi - tamSayi.adet - noktaliSayi.adet }" +
                $"(%{100 - (100 * (tamSayi.adet + noktaliSayi.adet) / GirdiAdedi)})");
        }
    }
}
