using CadastroUsuarioAPI.Models;

namespace CadastroUsuarioAPI.Repositories;

public class UsuarioRepository
{
    private static readonly List<UsuarioModel> Usuarios = new();

    public UsuarioModel CadastrarUsuario(UsuarioModel usuario)
    {
        usuario.Id = Guid.NewGuid();
        Usuarios.Add(usuario);
        return usuario;
    }

    public List<UsuarioModel> ListarUsuarios()
    {
        return Usuarios;
    }
}
