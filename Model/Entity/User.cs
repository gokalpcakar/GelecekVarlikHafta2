using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Ad 3 ile 30 karakter arasında olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Soyad 3 ile 30 karakter arasında olmalıdır.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "E-Mail alanı zorunludur.")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "E-Mail 6 ile 30 karakter arasında olmalıdır.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-mail adresi.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(3, ErrorMessage = "Şifre en az 3 karakter içermelidir.")]
        public string Password { get; set; }

        [Required]
        public bool isAuthorized { get; set; }
    }
}
