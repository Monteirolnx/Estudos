// https://youtu.be/pTTFuZYgzLk

int[] arr = { 1, 2, 2, 3, 4, 5 };

var first = arr.First();
Console.WriteLine($"First: {first}");

var firstOrDefault = arr.FirstOrDefault();
Console.WriteLine($"First Or Default: {firstOrDefault}");

var firstOrDefaultComBusca = arr.FirstOrDefault(x => x == 2);
Console.WriteLine($"First Or Default com busca: {firstOrDefaultComBusca}");

var firstOrDefaultComPadrao = Array.Empty<int>().FirstOrDefault(3);
Console.WriteLine($"First Or Default com padrão: {firstOrDefaultComPadrao}");

//Invalid Operation
//var single = arr.Single(x => x == 2); 

var single = arr.Single(x => x == 3);
Console.WriteLine($"Single: {single}");

var singleOrDefault = arr.SingleOrDefault(x => x == 3);
Console.WriteLine($"SingleOrDefault: {singleOrDefault}");

Console.ReadLine();