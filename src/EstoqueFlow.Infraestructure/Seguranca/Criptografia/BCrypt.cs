using EstoqueFlow.Domain.Seguranca.Criptografia;
using BC = BCrypt.Net.BCrypt;

namespace EstoqueFlow.Infraestructure.Seguranca.Criptografia;

public class BCrypt : ICriptografarSenha
{
    public string Criptografar(string senha)
    {
        var senhaHash = BC.HashPassword(senha);

        return senhaHash;
    }

    public bool VerificarSenha(string senha, string senhaHash) => BC.Verify(senha, senhaHash);
}
