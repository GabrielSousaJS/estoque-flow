namespace EstoqueFlow.Domain.Entities;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    public Categoria AtualizarDados(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;

        return this;
    }
}
