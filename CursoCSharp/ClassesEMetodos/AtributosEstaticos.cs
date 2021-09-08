using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;
        //apos atribuir o static o desconto passa da classe e nao ser mais da instacia
        // agora a instacia só possui o nome e o preço da class produto
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {
        
        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 5.5, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 8.4,
                //Desconto = 0.5
            };
            Produto.Desconto = 0.5;
            //o valor de desconto esta diretamente dentro da classe, ou seja, uma unica cópia de desconto pra todos os produtos..

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
