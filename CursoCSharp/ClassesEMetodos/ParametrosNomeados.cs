using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
            //A formatação dentro da {} apos o D ele dis a qntd que ele ira formatar, teste para entender
        }

        public static void Executar()
        {
            Formatar(mes: 2, dia: 22, ano: 2005);
        }
    }
}
