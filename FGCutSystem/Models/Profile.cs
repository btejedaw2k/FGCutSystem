using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FGCutSystem.Models
{
    public class Profile
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(Order = 1), Index("ProfileNameIndex", IsUnique = true)]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "El Nombre del perfil debe de ser entre 6 y 15 caracteres."), Required(ErrorMessage = "El Nombre del perfil es requerido.")]
        public string Nombre { get; set; }

        [Column(Order = 2)]
        public bool Activo { get; set; }
    }
}