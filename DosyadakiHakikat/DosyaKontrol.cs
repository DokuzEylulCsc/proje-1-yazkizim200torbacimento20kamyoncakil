using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyadakiHakikat
{
    class DosyaKontrol
    {
        public static StreamReader sr;
        private bool dosyaGecerliMi = false;
        private bool DosyaGecerliMi { get; set; }
        private string dosyaAdi;
        public string DosyaAdi { get; set; }
        Log log;

        public DosyaKontrol()
        {
            DosyaAdiKontrol();
        }

        public DosyaKontrol(string dosyaAdi)
        {
            this.DosyaAdi = dosyaAdi;
            DosyaAdiKontrol();
        }
        public DosyaKontrol(string dosyaAdi, bool b)
        {
            this.DosyaAdi = dosyaAdi;
            LogDosyaAdiKontrol();
        }
        public void DosyaAdiKontrol()
        {
            log = new Log();
            // Geçerli bir dosya adı alana kadar dosya adı iste
            do
            {
                try
                {
                    sr = File.OpenText(DosyaAdi);
                    DosyaGecerliMi = true;
                    log.Kaydet(DateTime.Now + " tarihinde " + DosyaAdi + " isimli dosya başarıyla açıldı.");
                }
                catch (FileNotFoundException)
                {
                    log.Kaydet(DateTime.Now + " tarihinde " + DosyaAdi + " dosya adı ile FileNotFoundException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    DosyaAdi = Console.ReadLine();
                }
                catch (ArgumentNullException)
                {
                    log.Kaydet(DateTime.Now + " tarihinde " + DosyaAdi + " dosya adı ile ArgumentNullException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    DosyaAdi = Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    log.Kaydet(DateTime.Now + " tarihinde " + DosyaAdi + " dosya adı ile ArgumentException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    DosyaAdi = Console.ReadLine();
                }

            } while (!DosyaGecerliMi);
        }

        public void LogDosyaAdiKontrol()
        {
            // Geçerli bir dosya adı alana kadar dosya adı iste
            do
            {
                try
                {
                    sr = File.OpenText(DosyaAdi);
                    DosyaGecerliMi = true;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Dosya Adı Giriniz:");
                    DosyaAdi = Console.ReadLine();
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Dosya Adı Giriniz:");
                    DosyaAdi = Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Dosya Adı Giriniz:");
                    DosyaAdi = Console.ReadLine();
                }

            } while (!DosyaGecerliMi);
        }

    }
}
