using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsuarioController : ControllerBase
    {
         
        
    

    [HttpGet(Name ="ListarUsuario")]
        public IEnumerable<Usuario>Get()
        {
            return UsuarioBusiness.DevolverUsuarios().ToArray();
        }      

        [HttpPost(Name = "CrearUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBusiness.CrearUsuario(usuario);
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBusiness.ModificarUsuario(usuario);
        }


        [HttpDelete(Name = "EliminarUsuario")]
        public void Delete([FromBody] int Id) 
        {
         UsuarioBusiness.EliminarUsuario(Id);
        }

        


    }
}
