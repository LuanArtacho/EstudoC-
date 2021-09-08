using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5]; //Array é uma estrutura homogenea e estatica.
            alunos[0] = "luan";                // Todos os dados são do mesmo tipo, e o tamanho é fixo, a qtt.
            alunos[1] = "lucas";
            alunos[2] = "nicolas";             // O Array é uma estrutura indexada, 
            alunos[3] = "rafa";                 // acessa os elementos apartir de um indice,
            alunos[4] = "enzo";                  // o indice inicia pelo 0.

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach( var nota in notas)
            {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //} // outra maneira de percorrer o array... 

            double media = somatorio / notas.Length; // O .Length me da o tamanho de um array.
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
