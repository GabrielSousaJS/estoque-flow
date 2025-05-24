namespace EstoqueFlow.Application.ViewModel.Movimentacoes;

public class MovimentacaoRequest
{
    public int Tipo { get; set; } // 1 - Entrada, 2 - Saída
    public int Quantidade { get; set; }
    public string Observacao { get; set; } = string.Empty;

    public int UsuarioId { get; set; }
    public int ProdutoId { get; set; }
}
