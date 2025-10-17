string[] nomes = new string [5] {"mateus","adriana","diego","maria","madson"};
string busca;

Console.WriteLine("digite o nome da pessoa que deseja buscar");
busca = Console.ReadLine();
for (int i = 0; i <= nomes.Length; i++) {
  
    if (nomes[i] == busca)
    {
        Console.WriteLine($"o nome : {busca} foi encontrado , ele estava na casa {i} do vetor   ");
        i = 1000000;
    }
   

}; 

Console.WriteLine($"o nome : {busca} foi encontrado , ele estava na casa {i} do vetor   ");