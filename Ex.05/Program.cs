//5. Verificação de Idade: Desenvolva um programa que solicite a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Utilize if e else para mostrar a mensagem apropriada. 

Console.Write("Informe sua idade: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade");
}
