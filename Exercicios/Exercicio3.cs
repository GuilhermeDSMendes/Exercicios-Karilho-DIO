using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio3
    {
        public static void exercicio()
        {
            //3 - Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores,

            int numeroA, numeroB, soma;

            Console.WriteLine("Digite o valor de A: ");
            int.TryParse(Console.ReadLine(), out numeroA);

            Console.WriteLine("Difite o valor de B: ");
            int.TryParse(Console.ReadLine(), out numeroB);

            if (numeroA == numeroB)
            {
                soma = numeroA + numeroB;

                Console.WriteLine($"Os valores são iguais, a soma entre eles é: {soma}");
            }
            else 
            {
                Console.WriteLine("Os valores são diferentes");
            }

        }
    }
}
