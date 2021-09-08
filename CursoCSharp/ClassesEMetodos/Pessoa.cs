using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Sexo;

        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome} e sou {Sexo} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Sexo = "";
            Idade = 0;
        }

    }
}
