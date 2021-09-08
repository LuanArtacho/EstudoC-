using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) //Ref 2 direções / dentro e fora do metodo
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) // Out apenas 1 direção
        {
            numero = 0; // tirar para passar o valor fora nn pega, apenas com ref
            numero = numero + 15;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b
            //int b = 2; // nn pode inicializar no out fora do parametro
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
