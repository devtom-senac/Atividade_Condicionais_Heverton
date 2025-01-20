// 6.Classificação de Notas: Crie um programa que peça a nota de um aluno e classifique a nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" (5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela. 

Console.Write("Informe a nota do aluno: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 9)
{
    Console.WriteLine("A nota do aluno é: excelente");
}
else if (numero >= 7)
{
    Console.WriteLine("A nota do aluno é: boa");
}
else if (numero >= 5)
{
    Console.WriteLine("A nota do aluno é: regular");
}
else 
{
    Console.WriteLine("A nota do aluno é: baixa");
}


