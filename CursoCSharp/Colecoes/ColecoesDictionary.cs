using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador"); // .add adiociona no dictionary
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Tuque");
            filmes.Add(2008, "Batman The Dark Knight");

            if (filmes.ContainsKey(2004)) //p ver se o valor esta contido ou nn, na coluna das chaves
            {
                Console.WriteLine("2004: " + filmes[2004]); //a key nn precisar ser um num, pode ser uma string..
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004)); // vai pegar o valor encima do param q vc passar ou default..

            }

            Console.WriteLine(filmes.ContainsValue("Amnésia")); //verifica se contem o valor..

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // remove encima do param passado

            filmes.TryGetValue(2006, out string filmes2006); // vai passar o valor da chave, no metodo assosiado..
            Console.WriteLine($"Filme {filmes2006}!");

            foreach(var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach(var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach(var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
