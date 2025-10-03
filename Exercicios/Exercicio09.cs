using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio09
    {
        public static void exercicio()
        {
            /*
              9 -   Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, 
                    leia o seu peso e sua altura e imprima na tela sua condição 
                    de acordo com a tabela abaixo:
                    Fórmula do IMC = peso / (altura) ²
                    Tabela Condições IMC
                    Abaixo de 18,5   | Abaixo do peso          
                    Entre 18,6 e 24,9 | Peso ideal (parabéns)  
                    Entre 25,0 e 29,9 | Levemente acima do peso
                    Entre 30,0 e 34,9 | Obesidade grau I 
                    Entre 35,0 e 39,9 | Obesidade grau II (severa)
                    Maior ou igual a 40 | Obesidade grau III (mórbida)
            */

            float peso, altura, imc;

            Console.WriteLine("Digite seu peso (kg): ");
            float.TryParse(Console.ReadLine(), out peso);
            Console.WriteLine("Digite a sua altura (M): ");
            float.TryParse(Console.ReadLine(), out altura);

            imc = peso / (altura * altura);

            switch (imc)
            {
                case >= 0f and <= 18.5f:
                    Console.WriteLine($"Seu IMC é {imc:F1}, você está abaixo do peso.");
                    break;

                case >= 18.6f and <= 24.9f:
                    Console.WriteLine($"Seu IMC é {imc:F1}, você está com o peso ideal. Parabéns!");
                    break;

                case >= 25.0f and <= 29.9f:
                    Console.WriteLine($"Seu IMC é {imc:F1}, você está levemente acima do peso.");
                    break;

                case >= 30.0f and <= 34.9f:
                    Console.WriteLine($"Seu IMC é {imc:F1}, você está com Obesidade grau I.");
                    break;

                case >= 35.0f and <= 39.9f:
                    Console.WriteLine($"Seu IMC é {imc:F1}, você está com Obesidade grau II (severa).");
                    break;

                case >= 40.0f:
                    Console.WriteLine($"Seu IMC é {imc:F1}, você está com Obesidade grau III (mórbida).");
                    break;

                default:
                    Console.WriteLine("Valor inválido.");
                    break;

            }

        }
    }
}
