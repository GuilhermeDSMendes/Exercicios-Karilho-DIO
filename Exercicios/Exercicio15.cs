using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio15
    {
        public static void exercicio()
        {
            /*
            15 - Faça um algoritmo que leia três valores que representam os três lados de um triângulo e 
            verifique se são válidos, determine se o triângulo é 
            equilátero, isósceles ou escaleno.
            */

            int ladoA, ladoB, ladoC;

            Console.WriteLine("Digite o valor do lado A: ");
            int.TryParse(Console.ReadLine(), out ladoA);
            Console.WriteLine("Digite o valor do lado B: ");
            int.TryParse(Console.ReadLine(), out ladoB);
            Console.WriteLine("Digite o valor do lado C: ");
            int.TryParse(Console.ReadLine(), out ladoC);

            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");    
            }

        }
    }
}
