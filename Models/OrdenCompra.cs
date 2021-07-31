using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Models
{
    public class OrdenCompra
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Clientes")]
        public int idCliente { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int estado { get; set; }
        public string direccionEntrega { get; set; }
        public int prioridad { get; set; }
        [ForeignKey("Productos")]
        public int idProducto { get; set; }
        public Decimal valorUnitario { get; set; }
        public int cantidad { get; set; }
        public Decimal valorTotal { get; set; }
    }
}
