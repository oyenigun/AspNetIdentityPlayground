using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityFrameworkApi.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        public string? mfatoken { get; set; }
    }
}

