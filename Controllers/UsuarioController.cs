using CadastroUsuarioAPI.Models;
using CadastroUsuarioAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuarioAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly UsuarioRepository _usuarioRepository;

    public UsuarioController()
    {
        _usuarioRepository = new UsuarioRepository();
    }

    [HttpPost]
    public IActionResult CadastrarUsuario([FromBody] UsuarioModel usuario)
    {
        if (string.IsNullOrEmpty(usuario.Nome) || string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.Senha))
        {
            return BadRequest("Todos os campos são obrigatórios.");
        }

        var usuarioCadastrado = _usuarioRepository.CadastrarUsuario(usuario);
        return CreatedAtAction(nameof(ListarUsuarios), new { id = usuarioCadastrado.Id }, usuarioCadastrado);
    }

    [HttpGet]
    public IActionResult ListarUsuarios()
    {
        var usuarios = _usuarioRepository.ListarUsuarios();
        return Ok(usuarios);
    }
}
