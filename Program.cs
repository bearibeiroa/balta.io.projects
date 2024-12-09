// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Soma();

static void Soma()
{
    Console.Clear();    

    Console.WriteLine("Digite o primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;
    Console.WriteLine($"O resultado da soma é {resultado}");

    Console.ReadKey();
}