int voto = 1 ,a=0,b=0,c=0,nulo=0;
while (voto != 0)
{
    Console.WriteLine("para acabar o probrama digite 0 ");
    Console.WriteLine("candidato a : 1");
    Console.WriteLine("candidato b : 2");
    Console.WriteLine("candidato c : 3");
    Console.WriteLine("candidato nulo  : 9");
    voto = int.Parse(Console.ReadLine());
    switch (voto)
    {
        case 1:
            a++;
            break;
        case 2:
            b++;
            break;
        case 3:
            c++;
            break;
        case 9: 
            nulo++; 
            break;
    }

}
Console.WriteLine("---------------------------------------------------------------------------------------------------------");
Console.WriteLine($"votos do candidato a : {a}");
Console.WriteLine($"votos do candidato a : {b}");
Console.WriteLine($"votos do candidato a : {c}");
Console.WriteLine($"votos do candidato a : {nulo}");