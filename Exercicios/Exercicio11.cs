using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio11
    {
        public static void exercicio() 
        {
            /*
            11 - Faça um algoritmo que leia quatro notas obtidas por um aluno, calcule a média das nota obtidas, 
            imprima na tela o nome do aluno e se o aluno foi aprovado ou reprovado. 
            Para o aluno ser considerado aprovado sua média final deve ser maior ou igual a 7.
            */

            float[] notas = new float[4];
            string nome;
            float media;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Digite a {i + 1}ª nota: ");
                float.TryParse(Console.ReadLine(), out notas[i]);
            }

            media = notas.Average();

            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            if (media >= 7)
            {
                Console.WriteLine($"O aluno {nome} foi aprovado com média {media:F2}");
            }
            else
            {
                Console.WriteLine($"O aluno {nome} foi reprovado com média {media:F2}");
            }


        }
    }
}
