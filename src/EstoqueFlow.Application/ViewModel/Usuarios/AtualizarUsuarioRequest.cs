namespace EstoqueFlow.Application.ViewModel.Usuarios;

public class AtualizarUsuarioRequest(int id, string nome, string email, string senhaAtual = "", string senhaNova = "")
{
    public int Id { get; set; } = id;
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public string SenhaAtual { get; set; } = senhaAtual;
    public string SenhaNova { get; set; } = senhaNova;
}
