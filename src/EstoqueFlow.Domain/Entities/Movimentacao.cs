using EstoqueFlow.Domain.Entities.Enums;

namespace EstoqueFlow.Domain.Entities;

public class Movimentacao
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public TipoMovimentacao Tipo { get; set; }
    public int Quantidade { get; set; }
    public string Observacao { get; set; } = string.Empty;

    public int UsuarioId { get; set; }
    public int ProdutoId { get; set; }

    public Usuario Usuario { get; set; } = default!;
    public Produto Produto { get; set; } = default!;
}
