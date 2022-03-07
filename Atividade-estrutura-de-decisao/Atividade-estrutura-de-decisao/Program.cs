using System;


namespace Atividade_estrutura_de_decisao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //formas de pagamento
            // Se o valor da compra for maior do que R$ 1.000, pode parcelar em 3 vezes
            // se não, apenas a vista

            decimal valorCompra;
            int parcelas = 3;
            decimal valorParcelas;
            decimal valorMinimoParaParcelar = 1000.01m; 

            Console.Write("Digite o valor da compra: ");
            valorCompra = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Valor à vista {0:c}", valorCompra);

            if (valorCompra >= valorMinimoParaParcelar)
            {
                valorParcelas = valorCompra / parcelas;
                Console.WriteLine("Você pode parcelar em {0} vezes de: {1:c} ", parcelas, valorParcelas);


            }
            

            Console.ReadLine();


        }
    }
}
