using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductoVendidoController : Controller
    {
        [HttpGet(Name = "ListarProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBusiness.ListarProductosVendido().ToArray();
        }

        [HttpPost(Name = "CrearProductoVendido")]
        public void Post([FromBody] ProductoVendido productovendido)
        {
            ProductoVendidoBusiness.CrearProductoVendido(productovendido);
        }

        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productovendido)
        {
            ProductoVendidoBusiness.ModificarProductoVendido(productovendido);
        }


        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete([FromBody] int Id)
        {
            ProductoVendidoBusiness.EliminarProductoVendido(Id);
        }
    }
}
