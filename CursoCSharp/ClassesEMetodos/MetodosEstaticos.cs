using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // metodo de classe ou metodo estatico
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        /*
        Metodo de instancia

        public int Somar(int a, int b)
        {
            return a + b;
        }
        */
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            Console.WriteLine(CalculadoraEstatica.Somar(2, 2));

            /*
            o metodo só é acessivel apartir da instacia, qnd tem o static ele é acessivel apartir da classe
                ...para testar abaixo basta tirar o static

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
            */
        }
    }
}
