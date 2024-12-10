using System.Collections;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();
        }

        static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Escolha qual operação gostaria de fazer:");
            Console.WriteLine("1 - Digite 1 para Soma");
            Console.WriteLine("2 - Digite 2 para Subtração");
            Console.WriteLine("3 - Digite 3 para Multiplicação");
            Console.WriteLine("4 - Digite 4 para Divisão");
            Console.WriteLine("5 - Digite 5 para Porcentagem");
            Console.WriteLine("0 - Digite 0 para Sair");

            short escolha = short.Parse(Console.ReadLine() ?? "");

            switch (escolha)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    Porcentagem();
                    break;
                case 0:
                    Sair();
                    break;
                default:
                    MenuInicial();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Digite o segundo valor:");
            float valor2 = float.Parse(Console.ReadLine() ?? "");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey(); // Ao clicar em qualquer tela o usuário para a execução do programa.

            MenuInicial();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Digite o segundo valor:");
            float valor2 = float.Parse(Console.ReadLine() ?? "");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey();
            MenuInicial();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Digite o segundo valor:");
            float valor2 = float.Parse(Console.ReadLine() ?? "");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultaod da multiplicação é: {resultado}");

            Console.ReadKey();
            MenuInicial();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float valor1 = float.Parse((Console.ReadLine() ?? ""));

            Console.WriteLine("Digite o segundo valor:");
            float valor2 = float.Parse((Console.ReadLine() ?? ""));

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();
            MenuInicial();
        }

        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Digite o inteiro:");
            double valor = double.Parse((Console.ReadLine() ?? ""));

            Console.WriteLine("Digite a porcentagem que gostaria de calcular:");
            double porcentagem = double.Parse((Console.ReadLine() ?? ""));

            double resultado = (valor * porcentagem) / 100;

            Console.WriteLine($"{porcentagem}% de {valor} é {resultado}");
            Console.ReadKey();
            MenuInicial();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigada por usar a calculadora.");
            System.Environment.Exit(0);
        }
    }
}
