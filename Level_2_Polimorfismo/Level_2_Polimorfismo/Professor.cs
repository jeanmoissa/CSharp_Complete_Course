using System;

namespace Level_2_Polimorfismo
{
    public class Professor : Pessoa
    {
        public override void Apresentar()
        {
            Console.WriteLine("Oi, eu sou um professor.");
        }
    }
}
