using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            int xI = 0; int yI = 0; int xF = 0; int yF = 0;
           
            
            Console.Write("x inicial ");
            xI = Convert.ToInt16(Console.ReadLine());
            Console.Write("y inicial ");
            yI = Convert.ToInt16(Console.ReadLine());

            Console.Write("x final ");
            xF = Convert.ToInt16(Console.ReadLine());
            Console.Write("y final ");
            yF = Convert.ToInt16(Console.ReadLine());



             Console.WriteLine("O caminho é válido? {0} ", CaminhoBot(xI, yI, xF, yF));



        }

        static bool CaminhoBot(int a, int b, int c, int d)
        {
            // char[] carac = texto.ToCharArray();
            //string caminhoX; string caminhoY;

            int sum = a + b;
            string posicao1 = sum + "," + a;
            string posicao2 = a + "," + sum;

            string posicaofinal = c + "," +  d;


            if (posicaofinal == posicao1 || posicaofinal == posicao2 )
                return true;
                
           else
                return false;
        }
    }
}
