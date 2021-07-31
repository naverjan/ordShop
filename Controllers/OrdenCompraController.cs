using Microsoft.AspNetCore.Cors;
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
        public ActionResult getOrdenesCompra()
        {
            var result = providerOrden.GetOrdenCompras();
            return Ok(new { listOrdenes = result});
        }

        [HttpGet]
        [Route("aprobarOrdenCompra")]
        public ActionResult aprobarOrdenCompra(int idCompra)
        {
            var result = providerOrden.aprobarOrdenCompra(idCompra);
            return Ok(new { status = result.status, message = result.message });
        }

        [HttpGet]
        [Route("anularOrdenCompra")]
        public ActionResult anularOrdenCompra(int idCompra)
        {
            var result = providerOrden.anularOrdenCompra(idCompra);
            return Ok(new { status = result.status, message = result.message });
        }
    }
}
