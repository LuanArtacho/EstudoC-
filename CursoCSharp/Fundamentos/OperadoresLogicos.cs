using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = false;
            var executouTrabalho2 = true;

            //operador && == E, só se os 2 der true, ele retorna true
            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            //operador || == OU, basta 1 der true ou os 2, ele retorna true
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            //operador ^ == OuExclusivo, somente se 1 for true ele retorna true
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 32? {0}", comprouTv32);

            //operador ! == Negação, ele iverte o papel, se for true vira false..
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
