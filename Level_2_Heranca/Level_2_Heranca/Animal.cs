using System;

namespace Level_2_Heranca
{
    public class Animal
    {
        public string Nome { get; set; }

        public void Comer()
        {
            Console.WriteLine(Nome + " está comendo.");
        }
    }
}
