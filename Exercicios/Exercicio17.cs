using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio17
    {
        public static void exercicio()
        {
            /*
            17 - Francisco tem 1,50m e cresce 2 centímetros por ano, 
            enquanto Sara tem 1,10m e cresce 3 centímetros por ano. 
            Faça um algoritmo que calcule e imprima na tela em quantos anos serão 
            necessários para que Francisco seja maior que Sara.
            */

            double alturaF = 1.50, alturaS = 1.10;

            for (int i = 1; alturaF > alturaS; i++)
            {
                alturaF = alturaF + 0.02;
                alturaS = alturaS + 0.03;
                if (alturaF < alturaS)
                {
                    Console.WriteLine($"Serão necessarios {i} anos para Sara passar Francisco em altura");
                }
            }

            Console.WriteLine($"Altura Francisco: {alturaF:F2}m, Altura Sara: {alturaS:F2}m");

        }
    }
}
