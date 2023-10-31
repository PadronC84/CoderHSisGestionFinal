using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductoController : Controller
    {
        [HttpGet(Name = "ListarProducto")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBusiness.ListarProductos().ToArray();
        }

        [HttpPost(Name = "CrearProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBusiness.CrearProducto(producto);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBusiness.ModificarProducto(producto);
        }


        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int id)
        {
            ProductoBusiness.EliminarProducto(id);
        }

    }
}
