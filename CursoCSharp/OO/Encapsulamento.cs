using System;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Não Reconhecido......");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular); internal, so acessa qm esta no msm projeto
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia); transmitido por herança apenas dentro do projeto..
            //Console.WriteLine(UsaMuitoPhotoshop); ninguem acessa..
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo Distante......");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); nn é recebido por herança, nn tem acesso
            //Console.WriteLine(amiga.NumeroCelular); nn tem acesso pq é interno
            //Console.WriteLine(amiga.JeitoDeFalar); ou é interno ou é protected, ou ta no msm projeto ou é transmitido por herança
            //Console.WriteLine(amiga.SegredoFamilia); nn tem acesso
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); ...
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
