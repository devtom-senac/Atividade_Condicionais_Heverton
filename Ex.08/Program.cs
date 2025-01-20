// 8.Verificação de Votação: Crie um programa que pergunte a idade de uma pessoa e determine se ela pode votar (idade >= 16). Utilize uma condição if para exibir a mensagem correspondente. 

Console.Write("Informe sua idade: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 16)
{
    Console.WriteLine("Você pode votar.");
}
else
{
    Console.WriteLine("Você não pode votar");
}
