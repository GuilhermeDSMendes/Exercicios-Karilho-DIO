using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio03
    {
        public static void exercicio()
        {
            //3 - Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores,
            //caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
            //imprimir seu valor na tela.

            int numeroA, numeroB, operacao;

            Console.WriteLine("Digite o valor de A: ");
            int.TryParse(Console.ReadLine(), out numeroA);

            Console.WriteLine("Difite o valor de B: ");
            int.TryParse(Console.ReadLine(), out numeroB);

            if (numeroA == numeroB)
            {
                operacao = numeroA + numeroB;

                Console.WriteLine($"Os valores são iguais, a soma entre eles é: {operacao}");
            }
            else 
            {
                operacao = numeroA * numeroB;
                Console.WriteLine($"A multiplicação entre eles é: {operacao}");
            }

        }
    }
}
