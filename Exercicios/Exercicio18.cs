using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio18
    {
        public static void exercicio()
        {
            //18 - Faça um algoritmo que imprima na tela a tabuada de 1 até 10.

            for (int i = 1, numero = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabuada do {numero}: {numero} X {i} = " + numero * i);

                if (i == 10 && numero != 10)
                {
                    i = 0;
                    numero++;
                    Console.WriteLine();
                    
                }
            }
            Console.ReadKey();
        }
    }
}
