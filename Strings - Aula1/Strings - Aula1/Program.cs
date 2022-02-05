using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings___Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            int dias;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            dias = idade * 365;

            Console.Write("Olá {0}, sua idade é {1} e você já viveu {2} dias", nome, idade, dias);
            Console.ReadLine();

        }
    }
}
