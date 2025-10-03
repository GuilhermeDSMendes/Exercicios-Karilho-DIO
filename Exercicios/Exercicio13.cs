using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio13
    {
        public static void exercicio()
        {
            /*13 - Faça um algoritmo que receba um valor A e B, e 
            troque o valor de A por B e o valor de B por A e imprima na tela os valores.
            */

            int valorA, valorB, valorAuxiliar;

            Console.WriteLine("Digite o valor de A: ");
            int.TryParse(Console.ReadLine(), out valorA);
            Console.WriteLine("Digite o valor de B: ");
            int.TryParse(Console.ReadLine(), out valorB);

            valorAuxiliar = valorA;
            valorA = valorB;
            valorB = valorAuxiliar;

            Console.WriteLine($"O novo valor de A é: {valorA}");
            Console.WriteLine($"O novo valor de B é: {valorB}");
        }
    }
}
