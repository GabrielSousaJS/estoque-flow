namespace EstoqueFlow.Application.ViewModel.Movimentacoes;

public class MovimentacaoRequest(int tipo, int quantidade, string observacao, int usuarioId, int produtoId)
{
    public int Tipo { get; set; } = tipo; // 1 - Entrada, 2 - Saída
    public int Quantidade { get; set; } = quantidade;
    public string Observacao { get; set; } = observacao;

    public int UsuarioId { get; set; } = usuarioId;
    public int ProdutoId { get; set; } = produtoId;
}
