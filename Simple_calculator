using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");

        Console.Write("Escolha a operação (1-4): ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        switch (escolha)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Opção inválida");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}
