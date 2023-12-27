using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC_Web_UI.Models
{
    public class Login
    {
        [Required]
        [DisplayName("E-posta")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla")]
        public bool RememberMe{ get; set; }

        
    }
}