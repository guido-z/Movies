using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Models
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            TiposDocumento = new List<SelectListItem>();
        }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Nombre de usuario")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Contrasenia")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Confirme la contrasenia")]
        public string PasswordConfirmation { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]        
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }
        
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int TipoDocumento { get; set; }

        public IEnumerable<SelectListItem> TiposDocumento { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Numero de documento")]
        public string NumeroDocumento { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]       
        public string Email { get; set; }
    }
}