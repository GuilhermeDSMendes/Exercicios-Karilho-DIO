using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Karilho_DIO.Exercicios
{
    internal class Exercicio12
    {
        public static void exercicio()
        {
            /*
                    12 - Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, 
                    conforme a escolha da forma de pagamentopelo comprador e imprima na tela o valor final do produto a ser pago. 
                    Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.
                    Tabela de Código de Condições de Pagamento
                    1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
                    2 - À Vista no cartão de crédito, recebe 10% de desconto
                    3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
                    4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%
            */

            string produto;
            decimal valorProduto;
            float valorFinal;
            int opcaoPagamento;

            Console.WriteLine("Digite o nome do produto: ");
            produto = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            decimal.TryParse(Console.ReadLine(), out valorProduto);

            Console.WriteLine("Escolha a forma de pagamento: ");
            Console.WriteLine("1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto");
            Console.WriteLine("2 - À Vista no cartão de crédito, recebe 10% de desconto");
            Console.WriteLine("3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros");
            Console.WriteLine("4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%");
            Console.WriteLine("Digite a opção de pagamento (1, 2, 3 ou 4): ");
            int.TryParse(Console.ReadLine(),out opcaoPagamento);

            switch (opcaoPagamento)
            {
                case 1:
                    valorFinal = (float)(valorProduto - (valorProduto * 0.15m));
                    Console.WriteLine($"O valor final do produto {produto} é: R$ {valorFinal:F2} com 15% de desconto.");
                    break;
                case 2:
                    valorFinal = (float)(valorProduto - (valorProduto * 0.10m));
                    Console.WriteLine($"O valor final do produto {produto} é: R$ {valorFinal:F2} com 10% de desconto.");
                    break;
                case 3:
                    valorFinal = (float)valorProduto;
                    Console.WriteLine($"O valor final do produto {produto} é: R$ {valorFinal:F2} sem juros.");
                    break;
                case 4:
                    valorFinal = (float)(valorProduto + (valorProduto * 0.10m));
                    Console.WriteLine($"O valor final do produto {produto} é: R$ {valorFinal:F2} com 10% de juros.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
                }

            }
    }
}
