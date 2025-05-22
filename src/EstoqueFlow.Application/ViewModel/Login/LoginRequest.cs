namespace EstoqueFlow.Application.ViewModel.Login;

public class LoginRequest(string email, string senha)
{
    public string Email { get; set; } = email;
    public string Senha { get; set; } = senha;
}
