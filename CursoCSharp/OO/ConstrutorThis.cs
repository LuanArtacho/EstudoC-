using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializando");
        }

        public Cachorro(string nome, double altura) : this(nome) //ao inves de passar o base, passa o this..
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var nina = new Cachorro("nina");
            var nani = new Cachorro("Nani", 40.0);

            Console.WriteLine(nina);
            Console.WriteLine(nani.ToString());
        }
    }
}
