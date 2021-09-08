using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo Proximo.....");
            
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho); protected é transmitido por herança, mas a classe nn pode ser acessada msm sendo proxima..
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia); só é transmitida por herança no msm projeto
            //Console.WriteLine(amigo.UsaMuitoPhotoshop); acesso privado..
            

        }


    }
}
