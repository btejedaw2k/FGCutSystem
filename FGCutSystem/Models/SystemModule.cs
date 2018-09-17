using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FGCutSystem.Models
{
    public class SystemModule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), Column(Order = 0)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nombre de Modulo"), Index("ModuleNameIndex", IsUnique = true)]
        [Required(ErrorMessage = "Nombre de Modulo es requerido."), Column(Order = 1), StringLength(30, ErrorMessage = "El Nombre del moudlo debe de ser entre 6 y 30 caracteres", MinimumLength = 6)]
        public string Nombre { get; set; }

        [DisplayName("Codigo del Modulo"), Index("ModuleCodeIndex", IsUnique = true)]
        [Required(ErrorMessage = "Codigo de Modulo es requerido."), Column(Order = 2), StringLength(10, ErrorMessage = "El Codigo del modulo debe de ser entre 4 y 10 caracteres", MinimumLength = 4)]
        public string Codigo { get; set; }

        [DisplayName("Modulo Activo"), Column(Order = 3), DefaultValue(true)]
        public bool Activo { get; set; }
    }
}