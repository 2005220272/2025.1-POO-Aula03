using aula_03;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tvSala = new Televisao(22f);
Console.WriteLine($"O tamanho da tv é: {tvSala.Tamanho}");

Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();

Console.WriteLine($"O tamanho da tv é: {tvSala.Tamanho}");


tvSala.AumentarVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();

//Deveria imprimir mudo
tvSala.AlternarModoMudo();

//Deveria imprimir 01
tvSala.AumentarVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");

//Deveria imprimir mudo
tvSala.AlternarModoMudo();

//Deveria imprimir volume 01
tvSala.AlternarModoMudo();

tvSala.DiminuirVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");

//Deveria imprimir volume 01
tvSala.AlternarModoMudo();

tvSala.AumentarCanal();
Console.WriteLine($"O canal da tv é: {tvSala.Canal}");

tvSala.DiminuirCanal();
Console.WriteLine($"O canal da tv é: {tvSala.Canal}");
