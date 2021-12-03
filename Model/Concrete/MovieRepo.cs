using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    // IMovieRepo interface'inde bulunan tanımlamalar uygulandı.
    public class MovieRepo : IMovieRepo
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }

        public void welcomeToMovieRepo()
        {
            Console.WriteLine("Welcome To Movie Repo!!!");
        }
    }
}
