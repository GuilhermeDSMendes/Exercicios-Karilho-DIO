using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio21
    {
        public static void exercicio()
        {
            /*
            21 - Faça um algoritmo que leia dois valores inteiros A e B, imprima na tela o 
            quociente e o resto da divisão inteira entre eles.
            */

            float numeroA, numeroB, calcular;

            Console.WriteLine("Digite o primeiro valor: ");
            float.TryParse(Console.ReadLine(), out numeroA);

            Console.WriteLine("Digite o segundo valor: ");
            float.TryParse(Console.ReadLine(),out numeroB);


            calcular = numeroA / numeroB;
            Console.WriteLine($"O quociente é: {calcular}");

            calcular = numeroA % numeroB;
            Console.WriteLine($"O resto da divisão é: {calcular}");


        }
    }
}
