namespace EstoqueFlow.Application.ViewModel.Produtos;

public class ProdutosRequest(
    string nome,
    string descricao,
    decimal precoCompra,
    decimal precoVenda,
    int estoqueMinimo,
    int categoriaId,
    int fornecedorId
)
{
    public string Nome { get; set; } = nome;
    public string Descricao { get; set; } = descricao;
    public decimal PrecoCompra { get; set; } = precoCompra;
    public decimal PrecoVenda { get; set; } = precoVenda;
    public int EstoqueMinimo { get; set; } = estoqueMinimo;

    public int CategoriaId { get; set; } = categoriaId;
    public int FornecedorId { get; set; } = fornecedorId;
}
