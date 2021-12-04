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

            // reflection ile kullanıcının tipine ulaşıldı.
            Console.WriteLine(Extensions.GetUserType(UserType.user1));

            // interface'ten alınan metodu movirepo'da kullandık.
            MovieRepo movie = new MovieRepo();

            // MovieRepo'da kullandığımız metodu burada bastırdık.
            movie.welcomeToMovieRepo();

            Console.ReadLine();
        }
    }
}
