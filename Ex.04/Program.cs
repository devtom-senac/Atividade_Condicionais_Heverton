// 4.Intervalo de Valores: Crie um programa que verifique se um número digitado pelo usuário está dentro do intervalo de 1 a 100. Utilize uma condição if para verificar se o número está no intervalo e exiba uma mensagem informando o resultado.

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 1 && numero <= 100)
{
    Console.WriteLine($"O número: {numero} está dentro do intervalo de 1 a 100.");
}
else
{
    Console.WriteLine($"O número: {numero} não está dentro do intervalo de 1 a 100.");
}
