using System;
using static System.Console;

namespace CSharpPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno carlos = new Aluno();
            carlos.setNome("Carlos");
            carlos.setIdade(15);
            carlos.Matricula = 23;
            
            carlos.Presente = false;
            carlos.Imprimir();

            Aluno eduarda = new Aluno
            {
                Matricula = 53
            };
            eduarda.setNome("Eduarda");
            eduarda.setIdade(15);
            
            eduarda.Presente = true;
            eduarda.Imprimir();

            Professor jose = new Professor();
            jose.setNome("Jose");
            jose.setIdade(45);
            
            jose.Imprimir();

            WriteLine("");
            ReadLine();

        }
    }
}
