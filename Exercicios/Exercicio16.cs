using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio16
    {
        public static void exercicio()
        {
            /*
            16 - Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. 
            Imprima na tela as duas temperaturas.
            Fórmula: C = (5 * ( F-32) / 9)
            */

            int temperaturaF, temperaturaC;

            Console.WriteLine("Digite a temperaruta en Fahrenheit: ");
            int.TryParse(Console.ReadLine(), out temperaturaF);

            temperaturaC = (5 * (temperaturaF - 32) / 9);

            Console.WriteLine($"A conversão para Celsius é: {temperaturaC}");
            Console.WriteLine($"Fahrenheit: {temperaturaF} Celsius: {temperaturaC}");


        }
    }
}
