using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio05
    {
        public static void exercicio() 
        {
            //Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
            //usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.293,20).

            decimal salario;
            decimal salarioMinimo = 1293.20m;
            decimal salariosTotal;


            Console.WriteLine("Digite o valor do seu salario");
            decimal.TryParse(Console.ReadLine(), out salario);

            salariosTotal = salario / salarioMinimo;

            Console.WriteLine($"A quantidade de salarios minimo que voce ganha é: {salariosTotal:F2}");

        }
    }
}
