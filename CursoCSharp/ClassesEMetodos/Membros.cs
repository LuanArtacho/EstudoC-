using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Luan";
            sicrano.Idade = 21;
            sicrano.Sexo = "Male";

            //Console.WriteLine($"Olá! Me chamo {sicrano.Nome} e sou {sicrano.Sexo} e tenho {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Nicolas";
            fulano.Idade = 3;
            fulano.Sexo = "Male";

            var apresentarFulano = fulano.Apresentar();
            Console.WriteLine(apresentarFulano.Length);
            Console.WriteLine(apresentarFulano);

        }
    }
}
