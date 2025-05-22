using System.ComponentModel;

namespace EstoqueFlow.Application.ViewModel.Produtos;

public class ProdutoResponse
{
    [DisplayName("Id")]
    public int Id { get; set; }
    [DisplayName("Nome")]
    public string Nome { get; set; } = string.Empty;
    [DisplayName("Descrição")]
    public string Descricao { get; set; } = string.Empty;
    [DisplayName("Preço de Compra")]
    public Decimal PrecoCompra { get; set; }
    [DisplayName("Preço de Venda")]
    public Decimal PrecoVenda { get; set; }
    [DisplayName("Quantidade")]
    public int Quantidade { get; set; }
    [DisplayName("Estoque mínimo")]
    public int EstoqueMinimo { get; set; }
    [DisplayName("Categoria ID")]
    public int CategoriaId { get; set; }
    [DisplayName("Categoria")]
    public string NomeCategoria { get; set; } = string.Empty;
    [DisplayName("Fornecedor ID")]
    public int FornecedorId { get; set; }
    [DisplayName("Fornecedor")]
    public string NomeFantasiaFornecedor { get; set; } = string.Empty;
}
