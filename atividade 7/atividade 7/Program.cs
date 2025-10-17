using System.ComponentModel.Design;

int a1, a2,i,a4;
Console.WriteLine("Digite  o numero que sera multiplicado ");
a1 =int.Parse(Console.ReadLine());
Console.WriteLine("Digite ate que  numero ele sera multiplicado ");
a2 = int.Parse(Console.ReadLine());
for (i = 1; i <= a2; i++) 
{
 a4=   a1* i;
    Console.WriteLine($"{a1}*{i}={a4}");
   
}
