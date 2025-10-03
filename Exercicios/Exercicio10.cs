using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio10
    {
        public static void exercicio()
        {
            // 10 - Faça um algoritmo que leia três notas obtidas por um aluno, e imprima na tela a média das notas.

            float[] notas = new float[3];
            float media;

            for (int i = 0;i <3; i++)
            {
                Console.WriteLine($"Digite a {i + 1}ª nota: ");
                float.TryParse(Console.ReadLine(), out notas[i]);
            }


            media =notas.Average();
            Console.WriteLine($"A média das notas é: {media:F2}");

        }
    }
}
