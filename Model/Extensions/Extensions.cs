using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extensions
{
    public static class Extensions
    {
        // Kullanıcının tipini burada alıyoruz.
        public static string GetUserType(this Enum userType)
        {
            var result = userType.GetType().GetMember(userType.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Name;
            return result.ToString();
        }

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
