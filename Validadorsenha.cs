using System;
using System.Linq;

class ValidadorDeSenha
{
    static string[] senhasFracas = { "123456", "senha123", "kauan123" };
    static char[] caracteresEspeciais = { '!', '@', '#', '$', '%', '^', '&', '*' };

    static bool ÉSenhaForte(string senha)
    {
        // Verifica o comprimento mínimo
        if (senha.Length < 10)
            return false;

        // Verifica se possui caracteres especiais
        if (!senha.Any(c => caracteresEspeciais.Contains(c)))
            return false;

        // Verifica se possui letras maiúsculas
        if (!senha.Any(c => char.IsUpper(c)))
            return false;

        // Verifica se possui letras minúsculas
        if (!senha.Any(c => char.IsLower(c)))
            return false;

        // Verifica se possui números
        if (!senha.Any(c => char.IsDigit(c)))
            return false;

        // Verifica se é uma senha fraca
        if (senhasFracas.Contains(senha))
            return false;

        return true;
    }

    static void Main()
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        if (ÉSenhaForte(senha))
        {
            Console.WriteLine("Senha válida.");
        }
        else
        {
            Console.WriteLine("Senha inválida. Certifique-se de seguir os critérios de senha.");
        }
    }
}
