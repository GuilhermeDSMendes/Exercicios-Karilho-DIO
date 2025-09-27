using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio7
    {
        //7 - Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.

        public static void exercicio()
        {
            bool valor1, valor2;
            Console.WriteLine("Digite o primeiro valor (true/false): ");
            bool.TryParse(Console.ReadLine(), out valor1);

            Console.WriteLine("Digite o segundo valor (true/false): ");
            bool.TryParse(Console.ReadLine(), out valor2);

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos os valores são VERDADEIROS.");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos os valores são FALSOS.");
            }
            else
            {
                Console.WriteLine("Os valores são diferentes.");
            }
        }

    }
}
