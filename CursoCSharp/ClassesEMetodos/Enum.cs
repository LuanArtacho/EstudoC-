using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    public enum Semana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta }

    public class DiaSemana
    {
        public int dia;
        public Semana nomeSemana;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var FilmeRandom = new Filme();
            FilmeRandom.Titulo = "Batman The Dark Knight";
            FilmeRandom.GeneroDoFilme = Genero.Acao;

            Console.WriteLine("{0} é {1}!", FilmeRandom.Titulo, FilmeRandom.GeneroDoFilme);

            int dia = (int)Semana.Quinta;
            Console.WriteLine(dia);

            var semana = new DiaSemana();
            semana.dia = 13;
            semana.nomeSemana = Semana.Sexta;

            Console.WriteLine("{0} é {1}!", semana.nomeSemana, semana.dia);


        }
    }
}
