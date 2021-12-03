using Model.Concrete;
using Model.Extensions;
using System;
using System.Linq;

namespace PratikConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Şuanki saat alındı.
            // tokyo ve la saatlerine dönüştüren extension'lar kullanıldı.
            DateTime trSaati = DateTime.Now;

            Console.WriteLine("Los Angeles Saati: " + Extensions.toLosAngelesTimeZone(trSaati));
            Console.WriteLine("Tokyo Saati: " + Extensions.toTokyoTimeZone(trSaati));

            Console.ReadLine();
        }
    }
}
