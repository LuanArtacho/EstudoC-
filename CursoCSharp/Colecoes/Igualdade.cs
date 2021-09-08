using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // false, locais de memory !=.
            Console.WriteLine(p3 == p2); // true, msm local de memory.

            Console.WriteLine(p1.Equals(p2)); //false, equals compara o end memory.
        }
    }
}
