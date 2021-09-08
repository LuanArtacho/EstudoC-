using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //herança
        protected string CorDoOlho = "Verde";

        // msm projeto (Assembly)
        internal ulong NumeroCelular = 551199999999;

        // herança ou msm projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //msm classe ou herança no msm projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade......");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);

        }
    }
}
