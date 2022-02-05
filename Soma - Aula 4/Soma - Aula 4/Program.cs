using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma___Aula_4
{
    internal class Program
    {
        int n1;
        int n2;
        int soma;

        static void Main(string[] args)
        {
            int n1;
            int n2;
            int soma;

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = Soma(n1, n2);
            Console.Write("A soma entre {0} e {1} é {2}", n1, n2, soma);
            Console.ReadLine();
        }

        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
