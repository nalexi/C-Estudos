using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosUm.Funcoes
{
    class Animal
    {
        string nome { get; set; }

        public void Acordar()
        {

            Console.WriteLine("acordei!");
        }
        public void Comer()
        {
            Console.WriteLine("Vou comer!");
        }
        public void Dormir()
        {
            Console.WriteLine("vou dormir");
        }
    }
}
