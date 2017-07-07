using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    class rangoException : Exception
    {
        private string miMensaje;

        public rangoException(string mensaje)
        {
            this.miMensaje = mensaje;
        }

        public override string Message
        {
            get
            {
                return this.miMensaje;
            }

            
        }
    }
}
