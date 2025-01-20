//3.Aprovação de AlunoEscreva um programa que pergunte a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso contrário, ele é "Reprovado". Exiba a situação do aluno na tela. 

Console.Write("Informe a nota do aluno: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 6)
{
    Console.WriteLine("O aluno está aprovado.");
}
else
{
    Console.WriteLine("O aluno está reprovado.");
}

