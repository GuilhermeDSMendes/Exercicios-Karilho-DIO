using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio20
    {
        public static void exercicio()
        {
            //20 - Faça um algoritmo que mostre um valor aleatório entre 0 e 100.

            var aleatorio = new Random();

            Console.WriteLine("O numero aleatorio entre 0 e 100 é: " + aleatorio.Next(0, 100));
        }
    }
}
