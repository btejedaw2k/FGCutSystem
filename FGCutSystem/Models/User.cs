using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FGCutSystem.Models
{
    public class User
    {
        [Key, Column(Order =0)]
        public int Id { get; set; }

        [Column(Order = 1), MaxLength(30, ErrorMessage = "No se permiten mas de 30 caracteres para el nombre de ususario."), Required(ErrorMessage = "Nombre de usuario es requeido")]
        public string Nombre { get; set; }

        [Column(Order = 2), MaxLength(30, ErrorMessage = "No se permiten mas de 30 caracteres para el apellido de ususario."), Required(ErrorMessage = "Apellido de usuario es requeido")]
        public string Apellido { get; set; }

        [Column(Order =3), StringLength(15, MinimumLength = 6, ErrorMessage ="El ID del usuario debe de ser entre 6 y 15 caracteres."), Required(ErrorMessage ="el ID de usuario es requerido.")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password es requerido.")]
        [StringLength(255, ErrorMessage = "La clave debe de ser entre 6 y 255 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password es requerido.")]
        [StringLength(255, ErrorMessage = "La clave debe de ser entre 6 y 255 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Las claves no coinciden")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(50, ErrorMessage = "El corre debe de ser entre 5 y 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Correo invalido")]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string Lastlogin { get; set; }
    }
}