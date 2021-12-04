using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extensions
{

    public enum UserType
    {
        [Display(Name = "Yonetici")]
        user1 = 1,

        [Display(Name = "Calisan")]
        user2 = 2
    }
}
