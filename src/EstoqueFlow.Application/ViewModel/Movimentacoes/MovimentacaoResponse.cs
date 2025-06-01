using EstoqueFlow.Domain.Entities.Enums;
using System.ComponentModel;

namespace EstoqueFlow.Application.ViewModel.Movimentacoes;

public class MovimentacaoResponse
{
    [DisplayName("ID")]
    public int Id { get; set; }
    [DisplayName("Data")]
    public DateTime Data { get; set; }
    [DisplayName("Tipo da Movimentação")]
    public string Tipo { get; set; } = string.Empty;
    [DisplayName("Valor de Compra")]
    public Decimal PrecoCompra { get; set; }
    [DisplayName("Valor de Venda")]
    public Decimal PrecoVenda { get; set; }
    [DisplayName("Quantidade")]
    public int Quantidade { get; set; }
    [DisplayName("Observação")]
    public string Observacao { get; set; } = string.Empty;
    [DisplayName("Usuário ID")]
    public int UsuarioId { get; set; }
    [DisplayName("Usuário Responsável")]
    public string NomeUsuario { get; set; } = string.Empty;
    [DisplayName("Produto ID")]
    public int ProdutoId { get; set; }
    [DisplayName("Produto")]
    public string NomeProduto { get; set; } = string.Empty;
}
