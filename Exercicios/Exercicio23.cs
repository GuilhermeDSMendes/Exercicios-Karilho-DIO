using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio23
    {
        public static void exercicio()
        {
            /*
            23 - Faça um algoritmo que calcule a quantidade de litros de combustível gastos em uma viagem, 
            sabendo que o carro faz 12km com um litro. 
            Deve - se fornecer ao usuário o tempo que será gasto na 
            viagem a sua velocidade média, distância percorrida e a quantidade de litros utilizados para fazer a viagem.
            
            Fórmula: distância = tempo x velocidade.


            litros usados = distância / 12.
            */


            // x = 50 * x 

            int tempo,velocidade,distancia,litrosUsados;

            Console.WriteLine("Digite a valociade media: ");
            int.TryParse(Console.ReadLine(),out velocidade);

            Console.WriteLine("Digite o tempo da viagem: ");
            int.TryParse(Console.ReadLine(), out tempo);

            distancia = tempo * velocidade;
            litrosUsados = distancia / 12;

            Console.WriteLine($"O tempo da viagem foi: {tempo}");
            Console.WriteLine($"A velocidade media foi: {velocidade}");
            Console.WriteLine($"A distancia percorrida foi: {distancia}");
            Console.WriteLine($"A quantidade de combustivel gasto foi: {litrosUsados}");

        }
    }
}
