using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio06
    {
        public static void exercicio()
        {
            //6 - Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.

            decimal valor, valorAjustado;
            

            Console.WriteLine("Digite o valor a ser reajustado: ");
            decimal.TryParse(Console.ReadLine(), out valor);

            valorAjustado = valor + (valor * 0.05m);
            Console.WriteLine($"O valor reajustado para mais é: {valorAjustado:F2}");

            valorAjustado = valor - (valor * 0.05m);
            Console.WriteLine($"O valor reajustado para menos é: {valorAjustado:F2}");

        }
    }
}
