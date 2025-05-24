namespace EstoqueFlow.Application.ViewModel.Categorias;

public class CategoriaRequest(string nome, string descricao)
{
    public string Nome { get; set; } = nome;
    public string Descricao { get; set; } = descricao;
}
