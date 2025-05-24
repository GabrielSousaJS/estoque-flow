namespace EstoqueFlow.Application.ViewModel.Fornecedores;

public class FornecedorRequest(string razaoSocial, string nomeFantasia, string cnpj, string telefone, string email)
{
    public string RazaoSocial { get; set; } = razaoSocial;
    public string NomeFantasia { get; set; } = nomeFantasia;
    public string CNPJ { get; } = cnpj;
    public string Telefone { get; set; } = telefone;
    public string Email { get; set; } = email;
}
