using System;

class _4_Switch_case
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número de 1 a 5:");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Você digitou o número 1.");
                break;
            case 2:
                Console.WriteLine("Você digitou o número 2.");
                break;
            case 3:
                Console.WriteLine("Você digitou o número 3.");
                break;
            case 4:
                Console.WriteLine("Você digitou o número 4.");
                break;
            case 5:
                Console.WriteLine("Você digitou o número 5.");
                break;
            default:
                Console.WriteLine("Número inválido.");
                break;
        }
    }
}

