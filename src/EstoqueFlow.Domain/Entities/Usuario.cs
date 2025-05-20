namespace EstoqueFlow.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public bool Ativo { get; set; } = true;
    public DateTime DataCadastro { get; set; }

    public Usuario AtualizarDados(string nome, string email, string senha)
    {
        Nome = nome;
        Email = email;
        Senha = senha;

        return this;
    }
}
