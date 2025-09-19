using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio2
    {
        public static void exercicio()
        {
            //2 - Faça um algoritmo para receber um número qualquer e imprimir na tela se o número é par ou ímpar, positivo ou negativo.

            int numero, resultado;
            string verificaSinal;

            Console.WriteLine("Digite um valor: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = numero % 2;

            if (numero >= 0)
            {
                verificaSinal = "positivo";
            }
            else
            {
                verificaSinal = "negativo";
            }

            if (resultado == 0)
            {
                Console.WriteLine($"O numero {numero} é par e tambem é {verificaSinal}");
                
            }
            else 
            {
                Console.WriteLine($"O numero {numero} é impar {verificaSinal}");

            }

        }
    }
}
