using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int numero;

            Console.Write("Digite um número para multiplicação: ");
            numero = Convert.ToInt16(Console.ReadLine());

            for (int i =1; i <= 10; i++)
            {
                int multiplicacao = numero * i;
                Console.WriteLine("{0} x {1} = {2} ", numero, i, multiplicacao);

            }

            Console.ReadLine();
        }
    }
}
