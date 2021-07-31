using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdShop.Interfaces;
using OrdShop.Models;
using OrdShop.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenCompraController : ControllerBase
    {
        private readonly IOrdenCompra providerOrden;

        public OrdenCompraController(IOrdenCompra providerOrden)
        {
            this.providerOrden = providerOrden;
        }

        [HttpGet]
        public List<OrdenCompra> getOrdenesCompra()
        {
            var result = providerOrden.GetOrdenCompras();
            return result;
        }
    }
}
