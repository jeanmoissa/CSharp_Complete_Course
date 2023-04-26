using System;

namespace Level_2_Polimorfismo
{
    public class Pessoa
    {
        public virtual void Apresentar()
        {
            Console.WriteLine("Oi, eu sou uma pessoa.");
        }
    }
}