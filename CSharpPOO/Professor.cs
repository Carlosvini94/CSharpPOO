using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharpPOO
{
    class Professor : Pessoa
    {
        public void Imprimir()
        {
            WriteLine($"Nome: {this.getNome()}");
            WriteLine($"Idade: {this.getIdade()}");
            WriteLine($"Nome: {this.ResponderPresenca()}");
            WriteLine("-----------------------------------");
        }

        public string ResponderPresenca()
        {
            return "Bateu Ponto";
        }


    }
}
