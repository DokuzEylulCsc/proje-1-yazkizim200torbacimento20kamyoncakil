using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log;
            DosyaKontrol dosyaKontrol;
            DosyaOkuma dosyaOkuma;

            if (args.Length > 0)
            {
                if (args[0] == "-L")
                {
                    dosyaKontrol = new DosyaKontrol(args[1]);
                    dosyaOkuma = new DosyaOkuma(true, dosyaKontrol.DosyaAdi);
                }
                else
                {
                    dosyaKontrol = new DosyaKontrol(args[0]);
                    dosyaOkuma = new DosyaOkuma(dosyaKontrol.DosyaAdi);
                    dosyaOkuma.SiraliYazdir();
                    dosyaOkuma.SonucYazdir();
                    log = new Log();
                    log.Başla();
                }
            }
            else
            {
                dosyaKontrol = new DosyaKontrol();
                dosyaOkuma = new DosyaOkuma(dosyaKontrol.DosyaAdi);
                dosyaOkuma.SiraliYazdir();
                dosyaOkuma.SonucYazdir();
                log = new Log();
                log.Başla();
            }
            
            Console.WriteLine("Program Bitti Çıkmak İçin Enter'e Basınız");
            Console.ReadLine();
        }
    }
}
