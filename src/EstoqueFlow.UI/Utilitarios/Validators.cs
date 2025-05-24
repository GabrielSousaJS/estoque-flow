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

    public static bool ValidarCnpj(string cnpj)
    {
        if (string.IsNullOrWhiteSpace(cnpj))
            return false;

        string cnpjNumeros = RemoverMascara(cnpj);

        if (cnpjNumeros.Length != 14 || !cnpjNumeros.All(char.IsDigit))
            return false;

        if (cnpjNumeros.Distinct().Count() == 1)
            return false;

        var digitosVerificadores = cnpjNumeros.Substring(12, 2);
        var cnpjBase = cnpjNumeros.Substring(0, 12);

        var primeiroDigito = CalcularDigitoVerificador(cnpjBase, [5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2]);
        var segundoDigito = CalcularDigitoVerificador(cnpjBase + primeiroDigito, [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2]);

        var resultado = digitosVerificadores == $"{primeiroDigito}{segundoDigito}";

        if (!resultado)
        {
            throw new ArgumentException("CNPJ inválido");
        }

        return true;
    }

    private static string RemoverMascara(string cnpj)
    {
        return new string(cnpj.Where(char.IsDigit).ToArray());
    }

    private static int CalcularDigitoVerificador(string cnpjParcial, int[] multiplicadores)
    {
        int soma = 0;

        for (int i = 0; i < multiplicadores.Length; i++)
        {
            soma += (cnpjParcial[i] - '0') * multiplicadores[i];
        }

        int resto = soma % 11;
        return resto < 2 ? 0 : 11 - resto;
    }

    public static bool ValidarTelefoneFixo(string telefone)
    {
        string padrao = @"^\(\d{2}\) \d{4}-\d{4}$";

        if (!Regex.IsMatch(telefone, padrao))
            return false;

        string digitos = new string(telefone.Where(char.IsDigit).ToArray());

        int ddd = int.Parse(digitos.Substring(0, 2));
        if (ddd < 11 || ddd > 99)
            return false;

        if (digitos.Skip(2).All(c => c == digitos[2]))
            return false;

        return true;
    }

    public static void AllowNumber(KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }
}
