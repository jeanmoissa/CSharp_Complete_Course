using System;

class _3_If_Encadeado
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else if (idade >= 14)
        {
            Console.WriteLine("Você é um adolescente.");
        }
        else
        {
            Console.WriteLine("Você é uma criança.");
        }
    }
}
