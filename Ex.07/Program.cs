// 7. Comparação de Números: Escreva um programa que solicita dois números ao usuário e determina qual deles é maior. Utilize if, else if e else para exibir a mensagem adequada. 

Console.Write("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"O número: {num1} é maior que o número: {num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"O número: {num1} é maior que o número: {num2}");
}
else
{
    Console.WriteLine("Os números digitados são iguais");
}
