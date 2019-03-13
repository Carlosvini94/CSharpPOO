using static System.Console;
using System;

namespace CSharpPOO
{
    class Pessoa
    {
        private string nome;
        private int idade;


        // Forma tradicional de GET / SET. - A outras formas do unicas do C#
        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string _nome)
        {
            this.nome = _nome;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int _idade)
        {
            this.idade = _idade;
        }

        public string ResponderPresenca()
        {
            return "Esta Presente";
        }
    }
}
