int i;
double[] notas = new double[3], peso = new double[3];
double total;
for (i = 0; i <= 2; i++){
    Console.WriteLine($"digite a {i+1} nota do aluno ");
    notas[i]=double.Parse(Console.ReadLine());
    Console.WriteLine("digite o peso desta nota  ");
    peso[i] = double.Parse(Console.ReadLine());
}
total = ((notas[0] * peso[0]) + (notas[1] * peso[1]) + (notas[2] * peso[2])) /( peso[0]+peso[1]+peso[2]);
if (total < 5)
{
    Console.WriteLine($"a media ponderada do aluno e {total} e o aluno reprovou ");
}
else if (total < 7)
{
    Console.WriteLine($"a media ponderada do aluno e {total} e o aluno esta de recuperaçao  ");
}
else
{
    Console.WriteLine($"a media ponderada do aluno e {total} e o aluno esta aprovado  ");
}