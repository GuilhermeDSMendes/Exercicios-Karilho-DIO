using System;
//1 - Faça um algoritmo que leia os valores de A, B, C e em seguida imprima na tela a soma entre A e B e mostre se a soma é menor que C.

int a, b, c, soma;

Console.WriteLine("Digite o primeiro valor: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor: ");
c = Convert.ToInt32(Console.ReadLine());

soma = a + b;

Console.WriteLine($"A soma do primeiro e segundo valor é: {soma}");

if (soma > c)
{
    Console.WriteLine("a soma é maior que o terceiro valor");
}else if (soma == c)
{
    Console.WriteLine("A soma é igual ao terceiro valor");
}
else
{
    Console.WriteLine("A soma é menor que o terceiro valor");
}
