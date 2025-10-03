using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio08
    {
        public static void exercicio() 
        {
            //8 - Faça um algoritmo que leia três valores inteiros diferentes e imprima na tela os valores em ordem decrescente.

            int[] valores = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor: ");
                int.TryParse(Console.ReadLine(), out valores[i]);
            }

            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine("Os valores em ordem decrescente são: ");
            foreach (int valor in valores)
            {
                Console.Write($"{valor} ");
            }

        }
    }
}
