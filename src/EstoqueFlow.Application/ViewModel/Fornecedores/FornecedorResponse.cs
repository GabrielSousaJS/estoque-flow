using System.ComponentModel;

namespace EstoqueFlow.Application.ViewModel.Fornecedores;

public class FornecedorResponse
{
    [DisplayName("Id")]
    public int Id { get; set; }
    [DisplayName("Razão Social")]
    public string RazaoSocial { get; set; } = string.Empty;
    [DisplayName("Nome Fantasia")]
    public string NomeFantasia { get; set; } = string.Empty;
    [DisplayName("CNPJ")]
    public string CNPJ { get; set; } = string.Empty;
    [DisplayName("Telefone")]
    public string Telefone { get; set; } = string.Empty;
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;
}
