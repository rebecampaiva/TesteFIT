using System;

namespace Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; int c = 0; int divisor = 0;
            Console.Write("Informe um número:");

            n = Convert.ToInt32(Console.ReadLine());

            for (int a = 1; a <= n; a++ )
            {
                if (n % a == 0)
                    divisor++;
                
            }
            if (divisor == 2)
                Console.WriteLine("O número " + n + " é primo. Número de iterações necessárias: 2 - ele mesmo e 1.");
            

            else
                Console.WriteLine("O número " + n + " não é primo. Número de iterações necessárias: " + divisor);
        }
    }
}
