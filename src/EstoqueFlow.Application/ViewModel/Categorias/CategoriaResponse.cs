using System.ComponentModel;

namespace EstoqueFlow.Application.ViewModel.Categorias;

public class CategoriaResponse
{
    [DisplayName("ID")]
    public int Id { get; set; }
    [DisplayName("Nome")]
    public string Nome { get; set; } = string.Empty;
    [DisplayName("Descrição")]
    public string Descricao { get; set; } = string.Empty;
}
