using OrdShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Interfaces
{
    public interface IOrdenCompra
    {
        List<OrdenCompra> GetOrdenCompras();
    }
}
