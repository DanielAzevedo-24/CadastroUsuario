namespace CadastroUsuarioAPI.Models;

public class UsuarioModel
{
    public Guid Id { get; set; }
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public required string Senha { get; set; }
}
