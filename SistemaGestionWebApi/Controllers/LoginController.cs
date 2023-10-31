using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase


    {
        public class LoginRequest
        {
            public string? Usuario { get; set; }
            public string? Contraseña { get; set; }
        }


        [HttpPost("Login", Name = "LoginUsuario")]
        public ActionResult<bool> LoginUsuario([FromForm] LoginRequest usuarioLogueado)
        {


            bool logueado = UsuarioBusiness.Login(usuarioLogueado.Usuario,usuarioLogueado.Contraseña);
            return logueado;
        }
    }
}