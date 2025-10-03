using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio04
    {
        public static void exercicio()
        {
            //4 - Faça um algoritmo que receba um número inteiro e imprima na tela o seu antecessor e o seu sucessor.

            int numero;

            Console.WriteLine("Digite um valor qualquer: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"O antecessor de {numero} é {numero - 1} e o sucessor é {numero + 1}");

        }
    }
}
