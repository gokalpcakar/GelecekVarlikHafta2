using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    // Burada konsol uygulamasında kullanacağımız property'ler tanımlandı.
    public interface IMovieRepo
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        void welcomeToMovieRepo();
    }
}
