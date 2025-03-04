using Microsoft.AspNetCore.Mvc;

namespace apiclase.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuariosController : Controller
{
    [HttpPost]
    public IActionResult validarUsuario([FromBody] Usuarios usuarios)
    {
        if (usuarios.email == "" && usuarios.password == "1234"){
            return Ok("Usuario correcto");
        }else{
            return BadRequest("Usuario incorrecto");
        }
    }

}