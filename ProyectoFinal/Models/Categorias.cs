using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaID { get; set; }

        [Display(Name = "Nombre de la Categoría")]
        [Required]
        public string NombreCategoria { get; set; }

        public ICollection<Productos> Productos { get; set; }
    }
}
