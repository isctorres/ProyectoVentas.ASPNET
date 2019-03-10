using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Productos
    {
        [Key]
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public int Existencia { get; set; }

        [Range(0.01, 100000.00,ErrorMessage = "El precio debe estar entre 0.01 y 100000.00")]
        public decimal Precio { get; set; }

        public bool Descontinuado { get; set; }

        public Categorias Categorias { get; set; }
        public ICollection<Promociones> Promociones { get; set; }
    }
}
