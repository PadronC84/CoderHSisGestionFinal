using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VentaController : Controller
    {
        [HttpGet(Name = "ListarVenta")]
        public IEnumerable<Venta> Get()
        {
            return VentaBusiness.ListarVenta().ToArray();
        }

        [HttpPost(Name = "CrearVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBusiness.CrearVenta(venta);
        }

        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)
        {
            VentaBusiness.ModificarVenta(venta);
        }


        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int Id)
        {
            VentaBusiness.EliminarVenta(Id);
        }


    }
}
