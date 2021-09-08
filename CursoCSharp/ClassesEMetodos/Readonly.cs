using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        // const nn pega devido Datetime nn aceitar..
        // readonly nn é mutavel..

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

        }

        public string GetDataNascimnento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);

        }
    }
    class Readonly
    {
        // public, torna a func visivel, para q outro namespace acesse ela.
        // static, quer dizer que eu não preciso criar um obj pra executar a func.
        // void, quer dizer que essa func não retorna nada.
        public static void Executar()
        {
            var novoCliente = new Cliente("Luan", new DateTime(2000, 08, 01));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimnento());
            
        }
    }
}
