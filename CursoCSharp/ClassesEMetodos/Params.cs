using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Luan", "Nicolas", "Jucelino", "Rafoso");
        }//com o params podemos passar paremetros variaveis, no caso do ex, foi os nomes, e fiz a repetição com um foreach
    }
}
