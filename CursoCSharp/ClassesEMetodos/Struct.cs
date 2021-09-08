using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int Delta); // se nn coloca o nivel de visibilidade por padrão é public
    }

    struct Coordenada: Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int Delta)
        {
            X += Delta; // Acrescentando o valor de x ao delta
            Y += Delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("X = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(9, 2);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("X = {0}", coordenadaFinal.Y);

            //Struct é muito similar a uma class
        }
    }
}
