using OrdShop.Interfaces;
using OrdShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Providers
{
    public class ProviderOrdenCompra : IOrdenCompra
    {
        private readonly AppDbContext dbContext;

        public ProviderOrdenCompra(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<OrdenCompra> GetOrdenCompras()
        {
            var result = dbContext.ordenCompras.ToList();
            return result;
        }
    }
}
