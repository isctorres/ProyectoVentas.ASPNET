using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class DetallePedido
    {
        public int PedidoID { get; set; }
        public Pedidos Pedido { get; set; }

        [Display(Name = "Producto ID")]
        public int ProductoID { get; set; }
        public Productos Producto { get; set; }

        [Display(Name = "Precio de Venta")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal PrecioVenta { get; set; }

        [Display(Name = "Cantidad Vendida")]
        [Required]
        [Range(1,100000)]
        public int CantidadVendida { get; set; }

        [Display(Name = "Descuento de Venta")]
        public decimal DescuentoVenta { get; set; }
    }
}
