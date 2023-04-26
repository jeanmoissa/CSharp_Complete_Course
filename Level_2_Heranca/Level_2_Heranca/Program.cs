using System;

namespace Level_2_Heranca;

class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Rex";

        cachorro.Comer(); // Rex está comendo.
        cachorro.Latir(); // Au au!
    }
}