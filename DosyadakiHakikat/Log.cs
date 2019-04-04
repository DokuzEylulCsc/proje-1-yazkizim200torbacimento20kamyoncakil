using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class Log
    {
        private static int hataSayisi = 0;
        private static int HataSayisi { get; set; }
        bool logmode = false;
        public bool LogMode
        {
            get
            {
                return logmode;
            }
            set
            {
                logmode = value;
            }
        }
        public void Başla()
        {
            if (logmode)
            {
                StreamWriter sw = File.AppendText("log.txt");
                sw.WriteLine("Dosyadaki Hakikat V1.0 " + DateTime.Now.ToString() + " Tarihinde Başladı");
                sw.Flush();
                sw.Close();
            }
        }
        public void Kaydet(string mesaj)
        {
            if (logmode)
            {
                HataSayisi++;
                StreamWriter sw = File.AppendText("log.txt");
                sw.WriteLine(mesaj);
                sw.Flush();
                sw.Close();
            }
        }
        public static void Bitir()
        {
                StreamWriter sw = File.AppendText("log.txt");
                sw.WriteLine("Program " + DateTime.Now.ToString() + " tarihinde" + HataSayisi.ToString() + " adet hata ile sonlandı\n-----------------------------------------\n");
                sw.Flush();
                sw.Close();
        }
    }
}
