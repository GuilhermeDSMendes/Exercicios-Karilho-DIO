using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio14
    {
        public static void exercicio()
        {
            /*
            14 - Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, 
            meses e dias essa pessoa ja viveu. Leve em 
            consideração o ano com 365 dias e o mês com 30 dias.
            (Ex: 5 anos, 2 meses e 15 dias de vida)
            */

            DateTime ano = DateTime.Now;
            int anos, anoNascimento, meses, dias;

            Console.WriteLine("Digite o ano em que você nasceu: ");
            int.TryParse(Console.ReadLine(), out anoNascimento);

            anos = ano.Year - anoNascimento;
            meses = anos * 12;
            dias = anos * 365;

            Console.WriteLine($"Voce tem {anos} anos, {meses} meses e {dias} dias de vida");


        }
    }
}
