using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    // Aproveitei o code da List p fazer esse!
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9); // como esta no msm namespace, eu consigo usar a class Produto

            var carrinho = new HashSet<Produto>(); 
            carrinho.Add(livro);                 

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa",29.9),
                new Produto("8º TEMP Game of Thrones",99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count); 
            //carrinho.RemoveAt(3); p ver q é != da List

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item)); como o set nn é indexada nn pega o parametro..
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // ela nn aceita duplicação/repetição
            Console.WriteLine(carrinho.Count);

        }
    }
}
