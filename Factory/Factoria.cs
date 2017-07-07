using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Factoria
    {
        public static Perro CriarDog(string tamano)
        {
            Perro per;
            switch (tamano)
            {
                case "Grande":
                    per = new Pitbull();
                    break;
                case "Mediano":
                    per = new Labrador();
                    break;
                case "Chico":
                    per = new Caniche();
                    break;
                default:
                    per = null;
                    break;
            }
            return per;
        }
    }
}
