using System.ComponentModel;

namespace EstoqueFlow.Application.ViewModel.Usuarios;

public class UsuarioResponse
{
    [DisplayName("ID")]
    public int Id { get; set; }
    [DisplayName("Nome")]
    public string Nome { get; set; } = string.Empty;
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;
    [DisplayName("Ativo")]
    public bool Ativo { get; set; } = true;
    [DisplayName("Data de cadastro")]
    public DateTime DataCadastro { get; set; }
}
