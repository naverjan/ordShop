using OrdShop.Interfaces;
using OrdShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Providers
{
    public class ProviderCliente : IClientes
    {
        private readonly AppDbContext dbContext;

        public ProviderCliente(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Clientes getClienteById(int id)
        {
            var result = dbContext.Clientes.Where(c => c.id == id).FirstOrDefault();
            return result;
        }
    }
}
