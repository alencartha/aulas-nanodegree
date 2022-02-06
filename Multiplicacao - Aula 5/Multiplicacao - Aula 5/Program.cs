using System;

namespace Multiplicacao___Aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //obter valores
            decimal valorProduto;
            int quantidade;

            Console.Write("Digite o valor do produto: ");
            valorProduto = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade de produtos: ");
            quantidade = Convert.ToInt32(Console.ReadLine());


            //calcula valor
            decimal total = ValorTotal(valorProduto, quantidade);


            //exibir resultado
            Console.Write("Total da compra: {0:c}", total);
            Console.ReadLine();
        }


        //método para multiplicar
        public static decimal ValorTotal(decimal valor, int quantidade)
        {
            return valor * quantidade;
        }
    }
}
