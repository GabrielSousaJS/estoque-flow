namespace EstoqueFlow.Domain.Seguranca.Criptografia;

public interface ICriptografarSenha
{
    string Criptografar(string senha);
    bool VerificarSenha(string senha, string senhaHash);
}
