using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual; //privado..

        //public Carro() { } // construtor padrão.. chamar se nn passar o contrutor base..
        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) // somente alterado por classes que herda de carro, ou seja herança
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if(novaVelocidade < 0) {
                VelocidadeAtual = 0; // nn deixa a velocidade negativa..
            } else if(novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima; // para nn passar a max..
            } else {
                VelocidadeAtual = novaVelocidade;            
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() // virtual, diz que pode ser sobrescrito
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        { 
         //construtor base é o carro(veloMax), com a ausencia do contrutor padrão eu tenho que chamar o contrutor q esta na class pai
        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar() //sobrescrevendo a class acelerar..
        {
            return AlterarVelocidade(15);
        }

        //Ocultar o método da classe pai
        public new int Frear() // se vc pretende ocultar, o new fala que esse é o comportamento
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            //Console.WriteLine(carro1.); nn é possivel chamar o metodo de alterar a velo, pois ele esta encapsulado, privado

            Console.WriteLine("Ferrari..");
            Ferrari carro2 = new Ferrari(); //ele sobrescre pq esta chamando o msm tipo
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari.. com tipo Carro..");
            Carro carro3 = new Ferrari(); // nn sobrescreve o frear pq o tipo é mais generico, a class carro...
            Console.WriteLine(carro3.Acelerar());// metodo acelerar sobrescreve..
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());// metodo frear apenas oculta o frear padrão..
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno.. com tipo Carro..");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

        }
    }
}
