using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaValorParcela___Aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorProduto;
            int quantasParcelas;

            Console.Write("Digite o valor do produto: ");
            valorProduto = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas: ");
            quantasParcelas = Convert.ToInt32(Console.ReadLine());

            decimal valorDaParcela = CalculaValorParcela(valorProduto, quantasParcelas);

            Console.Write("O valor de cada parcela será de {0:c}", valorDaParcela);
            Console.ReadLine();
        }

        public static decimal CalculaValorParcela(decimal valor, int parcela)
        {
            return valor / parcela;
        }
    }
}
