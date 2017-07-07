using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factoria factory = new Factoria();
            Perro per = Factoria.CriarDog("Grande");
            Console.WriteLine("Creado perro.");

            Console.ReadKey();
        }
    }
}
