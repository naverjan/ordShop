using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Models
{
    public class OrdenCompraCompleta
    {
        public OrdenCompra ordenCompra { get; set; }
        public Clientes cliente { get; set; }
        public List<Productos>  productos { get; set; }
    }
}
