using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC_Web_UI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }


        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("E-posta")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta")]
        public string Email { get; set; }


        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare ("Password", ErrorMessage ="Uyuşmayan şifre")]
        public string RePassword { get; set; }

    }
}