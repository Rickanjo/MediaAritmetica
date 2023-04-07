// 

Console.WriteLine("---Média Aritmética de 3 números---\n");

double numero1;
double numero2;
double numero3;
double media;

Console.WriteLine("Digite três numeros reais: ");
 
Console.Write("Número 1");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Número 1");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Número 1");
numero3 = Convert.ToDouble(Console.ReadLine());

media = (numero1 + numero2 + numero3 / 3);

Console.WriteLine($"A média aritmética é: {media:F2}");