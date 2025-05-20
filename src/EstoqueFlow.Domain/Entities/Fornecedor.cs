namespace EstoqueFlow.Domain.Entities;

public class Fornecedor
{
    public int Id { get; set; }
    public string RazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public Fornecedor AtualizarDados(
        string razaoSocial,
        string nomeFantasia,
        string cnpj,
        string telefone,
        string email)
    {
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        CNPJ = cnpj;
        Telefone = telefone;
        Email = email;

        return this;
    }
}
