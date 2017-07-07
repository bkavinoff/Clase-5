using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerador, denominador;
            string resultado = "";

            try
            {
                Console.WriteLine("Ingrese el numero a dividir:");
                numerador = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero por el cual quiere dividir:");
                denominador = int.Parse(Console.ReadLine());

                resultado = "El resultado es: " + numerador / denominador;

                comprobarRango(numerador, denominador);
            }
            catch (DivideByZeroException /*e*/)
            {
                //resultado = e.Message;
                resultado = "No se puede dividir por 0.";

            }

            catch (rangoException mensaje) {
                Console.WriteLine(mensaje.Message);
            }

            finally { Console.WriteLine(resultado); }

            Console.ReadKey();
        }

        static void comprobarRango(int numerador, int denominador) {
            if (numerador>100||denominador<0)
            {
                throw new rangoException("Estas fuera del rango permitido.");
            }
        }
    }
}
