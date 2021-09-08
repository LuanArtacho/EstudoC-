using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(2);// push add na fila
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");// ele pega de tras p frente
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); //pop remove na fila o ultimo elemento.

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); // pega o 1º da fila, mas nn remove ele..
            Console.WriteLine(pilha.Count);
        }
    }
}
