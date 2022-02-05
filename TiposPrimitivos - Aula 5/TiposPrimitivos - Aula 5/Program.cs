using System;


namespace TiposPrimitivos___Aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tipos Primitivos ");

            string nome = "José";
            short numeroMenor = 100;
            int numero = 20;
            long numeroGrande = 125014851515;

            double commissao = 32.45;
            decimal valor = Convert.ToDecimal(1000.56);
            decimal valor1 = 100.55m;

            DateTime data = DateTime.Now;
            DateTime dataExemplo = new DateTime(2022, 12, 11);


            //formatar data
            Console.WriteLine("{0:d}", dataExemplo);


            //data por extenso
            Console.WriteLine("{0:D}", dataExemplo);


            //dia da semana por extenso
            Console.WriteLine("{0:ddddddd}", dataExemplo);


            //formatar em moeda
            Console.WriteLine("{0:c}", valor);


            //data hoje
            Console.WriteLine("{0:d}", data);


            Console.ReadLine();

        
        }
    }
}
