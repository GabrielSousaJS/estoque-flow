namespace EstoqueFlow.Application.ViewModel.Usuarios;

public class UsuarioRequest(string nome, string email, string senha)
{
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public string Senha { get; set; } = senha;
}
