using System.ComponentModel.DataAnnotations;

namespace Guia_P09_Gerson_Gomez.Models
{
    public class Marca
    {
        [Key]
        [Display(Name = "ID")]
        public int id_marcas { get; set; }

        [Display(Name = "Nombre de la marca")]
        public string? nombre_marca { get; set; }

        [Display(Name = "Estado")]
        public string? estados { get; set; }
    }
}
