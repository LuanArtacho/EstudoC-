using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        //Trapaciando seria apenas colocar um static, pois seria um atributo de classe e um metodo de classe
        // static int a = 5;
        //na vdd não seria a solução correta.... nn trapaceando

        public static void Executar()
        {
            //DESAFIO: Acessar a variável 'a' dentro do método Executar!
            //Console.WriteLine(a); nn funciona, apenas se deixar o metodo statico pois seria o atributo da class

            //Solução
            //criar uma nova instacia, para a intacia 'desafio' apontar para a instancia da class 'DesafioAtributo'
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
