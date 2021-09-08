using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso; // pod passar param p controlar a propriedade.. recebendo por herança..

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }
    }

    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso) { } // forçar a passar o peso na construção da classe
    }

    public class Arroz : Comida
    {
        //public double Peso; recebendo o Peso por herança..
    }

    public class Carne : Comida
    {
        
    }

    public class Pessoa
    {
        public double Peso;

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida) //usando Polimorfismo..
        {
            Peso += comida.Peso;
        }
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao(0.3);

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;

            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}Kg!");
        }
    }
}
