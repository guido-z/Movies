using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Debe ingresar un nombre de usuario.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Debe ingresar una contraseña.")]
        public string Password { get; set; }
    }
}