using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio19
    {
        public static void exercicio()
        {
            //19 - Faça um algoritmo que receba um valor inteiro e imprima na tela a sua tabuada.

            int numero;

            Console.WriteLine("Digite o numero que voce gostaria de ver a sua tabuada: ");
            int.TryParse(Console.ReadLine(),out numero);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = " + numero * i);
            }
        }
    }
}
