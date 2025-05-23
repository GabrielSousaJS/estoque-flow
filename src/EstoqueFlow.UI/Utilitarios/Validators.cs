using System.Text.RegularExpressions;

namespace EstoqueFlow.UI.Utilitarios;

public static class Validators
{
    public static bool VerificarEmail(string email)
    {
        return Regex.IsMatch(email, @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$", RegexOptions.IgnoreCase);
    }

    public static bool VerificarNome(string nome)
    {
        return Regex.IsMatch(nome, @"^[a-zA-ZÀ-ÿ]{2,}(\s+[a-zA-ZÀ-ÿ]{2,})+$", RegexOptions.IgnoreCase);
    }
}
