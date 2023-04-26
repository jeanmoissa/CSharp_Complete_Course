using System;

namespace Level_2_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Aluno();
            Pessoa pessoa3 = new Professor();

            pessoa1.Apresentar(); // Oi, eu sou uma pessoa.
            pessoa2.Apresentar(); // Oi, eu sou um aluno.
            pessoa3.Apresentar(); // Oi, eu sou um professor.
        }
    }
}
