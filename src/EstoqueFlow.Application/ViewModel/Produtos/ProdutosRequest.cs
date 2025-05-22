namespace EstoqueFlow.Application.ViewModel.Produtos;

public class ProdutosRequest
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal PrecoCompra { get; set; }
    public decimal PrecoVenda { get; set; }
    public int EstoqueMinimo { get; set; }

    public int CategoriaId { get; set; }
    public int FornecedorId { get; set; }
}
