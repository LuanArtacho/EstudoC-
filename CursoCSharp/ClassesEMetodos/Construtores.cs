using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {   //padrão
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //outra forma, para passar direto
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {   //construtor padrão abaixo
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            //outra forma, passando direto no construtor
            var carro2 = new Carro("Ká", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            //outra forma
            var carro3 = new Carro()
            {
                Fabricante = "Nissan",
                Modelo = "GRT - R34",
                Ano = 2000
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
