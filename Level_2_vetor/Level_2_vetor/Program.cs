using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        Console.WriteLine("Os números no vetor são:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}