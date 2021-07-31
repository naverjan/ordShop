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

        public (int status, string message) anularOrdenCompra(int idCompra)
        {
            try
            {
                var order = dbContext.ordenCompras.Where(o => o.id == idCompra).FirstOrDefault();
                order.estado = 3;//estado anulado
                dbContext.ordenCompras.Update(order);
                dbContext.SaveChanges();
                return (200, "Anulacion exitosa");
            }
            catch
            {
                return (400, "Ocurrio un error al ralizar la anulacion");
            }
        }

        public (int status, string message) aprobarOrdenCompra(int idCompra)
        {
            try
            {
                var order = dbContext.ordenCompras.Where(o => o.id == idCompra).FirstOrDefault();
                order.estado = 2;//estado aprobado
                dbContext.ordenCompras.Update(order);
                dbContext.SaveChanges();
                return (200, "Aprobacion exitosa");
            }
            catch
            {
                return (400, "Ocurrio un error al ralizar la aprobacion");
            }

        }

        public List<OrdenCompra> GetOrdenCompras()
        {
            var result = dbContext.ordenCompras.ToList();
            return result;
        }
    }
}
