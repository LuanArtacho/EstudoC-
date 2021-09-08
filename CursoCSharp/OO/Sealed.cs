using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho { // impossivel herdar de uma classe selada

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia() // vc pode ocutar o metodo ao inves de sobrescrever.. colocando new
        //{
        //    return false;
        //}
    }

    class Sealed // uma class selada nn permite herança..
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
