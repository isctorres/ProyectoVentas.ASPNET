using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Pedidos
    {
        [Key]
        public int PedidoID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaPedido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEmbarque { get; set; }

        public int ClienteID { get; set; }
        public Clientes Clientes { get; set; }

        public int EstatusID { get; set; }
        public virtual EstatusPedido EstatusPedido { get; set; }

        public ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
