using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;
            Console.Write("Escreva uma palavra/frase:");

            texto  = Console.ReadLine();
            Console.WriteLine("É palíndromo? {0} = {1} ", texto, EPalindromo(texto));

            }

        static bool EPalindromo(string texto)
        {
            char[] carac = texto.ToCharArray();

            for (int i = 0, j = carac.Length - 1; i < j; i++, j--)
            {
                if (carac[i] != carac[j])
                    return false;

            }
            return true;
        }
    }
}
