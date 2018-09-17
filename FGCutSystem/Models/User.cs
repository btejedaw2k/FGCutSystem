using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FGCutSystem.Models
{
    public class User
    {
        [Key, Column(Order =0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [Column(Order = 1), MaxLength(30, ErrorMessage = "No se permiten mas de 30 caracteres para el nombre de ususario."), Required(ErrorMessage = "Nombre de usuario es requeido")]
        [DisplayName("Nombres")]
        public string Nombre { get; set; }

        [Column(Order = 2), MaxLength(30, ErrorMessage = "No se permiten mas de 30 caracteres para el apellido de ususario."), Required(ErrorMessage = "Apellido de usuario es requeido")]
        [DisplayName("Apellidos")]
        public string Apellido { get; set; }

        [Column(Order =3), StringLength(15, MinimumLength = 6, ErrorMessage ="El ID del usuario debe de ser entre 6 y 15 caracteres."), Required(ErrorMessage ="El ID de usuario es requerido.")]
        [DisplayName("ID de Usuario"), Index("UserNameIndex", IsUnique = true)]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password es requerido.")]
        [StringLength(255, ErrorMessage = "La clave debe de ser entre 6 y 255 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password), Column(Order = 4)]
        [DisplayName("Clave:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password es requerido.")]
        [StringLength(255, ErrorMessage = "La clave debe de ser entre 6 y 255 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Las claves no coinciden"), Column(Order = 5)]
        [DisplayName("Confirmacion de clave:")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(50, ErrorMessage = "El corre debe de ser entre 5 y 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Correo invalido")]
        [Column(Order = 6)]
        [DisplayName("Direccion de Correo")]
        public string Email { get; set; }

        [DataType(DataType.DateTime), Column(Order = 7)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Ultimo acceso")]
        public DateTime Lastlogin { get; set; }

        [Column(Order = 8)]
        [DisplayName("Creador Por"), DefaultValue("")]
        public string CreatedBy { get; set; }

        [Column(Order = 9)]
        [DisplayName("Creado en")]
        public DateTime CreatedDate { get; set; }

        [Column(Order = 10)]
        [DisplayName("Actualizado por"), DefaultValue("")]
        public string UpdatedBy { get; set; }

        [Column(Order = 11)]
        [DisplayName("Actualizado en:")]
        public DateTime UpdatedDate { get; set; }
    }
}