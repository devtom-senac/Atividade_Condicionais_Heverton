
// 2. Verificação de Paridade: Desenvolva um programa que solicita ao usuário um número. O programa deve determinar se o número é positivo, negativo ou zero, utilizando if, else if, e else para as três possibilidades. Exiba a mensagem correspondente.  

using System.ComponentModel.Design;

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("O número é ZERO");
}
else if (numero % 2 == 0)
{
    Console.WriteLine($"O número: {numero} é par");
}
else
{
    Console.WriteLine($"O número: {numero} é ímpar");
}
