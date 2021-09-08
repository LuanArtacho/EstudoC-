using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    //Abordagem muito famosa dentro do Java para definir get, set..
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int    Cilindrada;
    
        public Moto(string marca, string modelo, int cilindrada)
        {
            //Marca       = marca;
            //Modelo      = modelo;
            //Cilindrada  = cilindrada;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int GetCilindradas()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            //Não deixar a cilindrada negativa..

            //if(cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}

            Cilindrada = Math.Abs(cilindrada);

            //Para usar a resolução abaixo, alterar o tipo cilindrada p uint, q ele nn aceita sinal...
            //Cilindrada = cilindrada
        }
    }


    class GetSet
    {
        public static void Executar()
        {
            var Moto1 = new Moto("kawasaki", "Ninja ZX", 636);
            Console.WriteLine(Moto1.GetMarca());
            Console.WriteLine(Moto1.GetModelo());
            Console.WriteLine(Moto1.GetCilindradas());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-150);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindradas());
        }
    }
}
