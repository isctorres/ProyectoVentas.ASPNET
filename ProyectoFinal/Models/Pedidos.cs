using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Pedidos
    {
        public Pedidos()
        {
            FechaPedido = DateTime.Now;
        }

        [Key]
        public int PedidoID { get; set; }

        [Display(Name = "Fecha de Pedido")]
        [DataType(DataType.Date)]
        public DateTime FechaPedido { get; set; }

        [Display(Name = "Fecha de Embarque")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEmbarque { get; set; }

        [Display(Name = "Referencia de Banco")]
        public String ReferenciaBanco { get; set; }

        [Display(Name = "Cliente ID")]
        public int ClienteID { get; set; }
        public Clientes Clientes { get; set; }

        [Display(Name = "Estatus ID")]
        public int EstatusID { get; set; }
        [ForeignKey("EstatusID")]
        public virtual EstatusPedido EstatusPedido { get; set; }

        public List<DetallePedido> DetallePedido { get; set; }
    }
}
