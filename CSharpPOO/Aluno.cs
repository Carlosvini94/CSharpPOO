using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharpPOO
{
    class Aluno : Pessoa
    {

        private int matricula;
        private bool presente;

        //Get / Set forma de farzer do c# (uma das)

        public int Matricula
        {
            get => matricula;
            set => matricula = value > 100 ? throw new Exception("Matricula não pode ser maior que 100") : value;
        }

        // ou tra forma
        public bool Presente{ get; set; }
        
        public void Imprimir()
        {
            WriteLine($"Nome: {this.getNome()}");
            WriteLine($"Idade: {this.getIdade()}");
            WriteLine($"Nome: {this.matricula}");
            WriteLine($"Nome: {this.presente}");
            WriteLine($"Nome: {this.ResponderPresenca()}");
            WriteLine("-----------------------------------");
        }

        public string ResponderPresenca()
        {
            if (this.Presente)
            {
                return "Presente!!!!";
            }
            else
            {
                return "Faltou";
            }
            
        }

    }
}
