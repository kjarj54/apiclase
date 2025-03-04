using Microsoft.AspNetCore.Mvc;

namespace apiclase.Controllers;

public class UsuariosController: Controller{
    [HttpPost]
    public IActionResult validarUsuario([FromBody] Usuarios usuarios){
        return Ok(usuarios);
    }
    
}