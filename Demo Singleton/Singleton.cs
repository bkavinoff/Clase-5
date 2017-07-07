using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Singleton
{
    class Singleton
    {
        private static Singleton single;
        //esto no se necesita:
        public int cantidadDeInstancias;
        //---------------------------------
        private Singleton()
        {
            this.cantidadDeInstancias++;
        }

        public static Singleton GetInstancia()
        {
            if (single == null)
            {
                single = new Singleton();
            }
            return single;
        }
    }
}
