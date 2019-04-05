using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Promociones
    {
        [Key]
        public int PromocionID { get; set; }

        [Display(Name = "Descuento")]
        [Required]
        public decimal Descuento { get; set; }

        [Display(Name = "Fecha Inicial")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha Final")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        [Display(Name = "Producto")]
        public int ProductoID { get; set; }
        [ForeignKey("ProductoID")]
        public virtual Productos Productos { get; set; }
    }
}
