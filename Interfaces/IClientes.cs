using OrdShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Interfaces
{
    public interface IClientes
    {
        Clientes getClienteById(int id);
    }
}
