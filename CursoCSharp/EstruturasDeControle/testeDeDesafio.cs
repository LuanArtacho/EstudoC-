using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class testeDeDesafio
    {
        int a = 20;
        
        //static int a = 20;

        public static void Executar()
        {
            //Acessar a varialvel 'a' dentro do método Executar
            //Console.WriteLine(a);

            //maneira não correta porem funciona, seria passar o static na var a, para ser 1 valor fixo
            //Console.WriteLine(a);
            
            testeDeDesafio desafio = new testeDeDesafio();
            Console.WriteLine(desafio.a);
        }
    }
}
