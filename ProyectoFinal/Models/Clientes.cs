using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteID { get; set; }

        [Display(Name = "Nombre del Cliente")]
        [Required]
        public string NombreCliente { get; set; }

        [Display(Name = "Apellido Paterno")]
        [Required]
        public string ApellidoPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        [Required]
        public string ApellidoMaterno { get; set; }

        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailCliente { get; set; }

        [Display(Name = "Número Telefónico")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoCliente { get; set; }

        public ICollection<Pedidos> Pedidos { get; set; }
    }
}
