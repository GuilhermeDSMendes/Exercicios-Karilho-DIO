using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio22
    {
        public static void exercicio()
        {
            /*
            22 - Faça um algoritmo que efetue o cálculo do salário líquido de um professor. 
            As informações fornecidas serão: valor da hora aula, número de aulas lecionadas no mês e percentual de 
            desconto do INSS. Imprima na tela o salário líquido final.
            */

            
            decimal valorAula, inss, aulasMes, salarioLiquido;

            Console.WriteLine("Digite o valor da hora aula: ");
            decimal.TryParse(Console.ReadLine(), out valorAula);

            Console.WriteLine("Digite a quantidade de aulas do mes: ");
            decimal.TryParse(Console.ReadLine(), out aulasMes);

            Console.WriteLine("Digite o desconto do INSS: ");
            decimal.TryParse(Console.ReadLine(), out inss);

            salarioLiquido = aulasMes * valorAula;



        }
    }
}
