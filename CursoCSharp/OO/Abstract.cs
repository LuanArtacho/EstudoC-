using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular // o conceito de abstract é uma class inacabada, ela serve p ser herdada..
    {
        public abstract string Assistente();

        public string Tocar() // classe concreta..
        {
            return "Plim Plim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class iPhone : Celular
    {
        public override string Assistente() //sobrescrever pq o metodo é abstrato...
        {
            return "Olá! Meu nome é Siri!";
        }
    }

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new iPhone(),
                new Samsung()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
