using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        
        public Produto( string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>(); // a lista só vai armazenar o tipo produto
            carrinho.Add(livro);                 // list é do tipo dinamica

            var combo = new List<Produto>
            {
                new Produto("Camisa",29.9),
                new Produto("8º TEMP Game of Thrones",99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo); // add varios elementos dentro de uma List
            Console.WriteLine(carrinho.Count); // ve o tamanhdo da List
            carrinho.RemoveAt(3); // remove o 3º elemento... o indice 3, o que for passado.
               
            foreach(var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // List é uma estrutura que aceita repetição
            Console.WriteLine(carrinho.Count);
            Console.WriteLine(carrinho.LastIndexOf(livro));

        }
    }
}
