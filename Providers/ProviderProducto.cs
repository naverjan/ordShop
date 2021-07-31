using OrdShop.Interfaces;
using OrdShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Providers
{
    public class ProviderProducto : IProductos
    {
        private readonly AppDbContext dbContext;

        public ProviderProducto(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Productos getProductById(int id)
        {
            var result = dbContext.Productos.Where(p => p.id == id).FirstOrDefault();
            return result;
        }
    }
}
