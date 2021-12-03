using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extensions
{
    public static class Extensions
    {
        // Los Angeles saat dilimine dönüştüren fonksiyon.
        public static string toLosAngelesTimeZone(this DateTime trSaati)
        {
            return trSaati.AddHours(1).ToLongTimeString();
        }

        // Tokyo saat dilimine dönüştüren fonksiyon.
        public static string toTokyoTimeZone(this DateTime trSaati)
        {
            return trSaati.AddHours(6).ToLongTimeString();
        }
    }
}
