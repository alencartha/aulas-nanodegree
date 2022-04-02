using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;
            numeros[5] = 60;


            //percorrer
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
            
            //ordenar
            Array.Sort(numeros);

            //pesquisar
            int indice = Array.IndexOf(numeros, 20);
            if(indice == -1)
            {
                Console.WriteLine("Não existe no array numeros");
            }
            else
            {
                Console.WriteLine("Encontrado:{0} a posicao {1}", numeros[indice], indice);
            }

    
            //tamanho
            int tamanhoArray = numeros.Length;
            Console.WriteLine("Tamanho Array Numeros:{0}", tamanhoArray );

            Console.WriteLine("----");

            Console.ReadLine();
        }
    }
}
