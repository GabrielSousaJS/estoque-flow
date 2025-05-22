namespace EstoqueFlow.Domain.Entities;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Decimal PrecoCompra { get; set; }
    public Decimal PrecoVenda { get; set; }
    public int Quantidade { get; set; }
    public int EstoqueMinimo { get; set; }

    public int CategoriaId { get; set; }
    public int FornecedorId { get; set; }

    public Categoria Categoria { get; set; } = default!;
    public Fornecedor Fornecedor { get; set; } = default!;

    public Produto AtualizarDados(
        string nome,
        string descricao,
        Decimal precoCompra,
        Decimal precoVenda,
        int estoqueMinimo,
        int categoriaId,
        int fornecedorId)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoCompra = precoCompra;
        PrecoVenda = precoVenda;
        EstoqueMinimo = estoqueMinimo;
        CategoriaId = categoriaId;
        FornecedorId = fornecedorId;

        return this;
    }
}
