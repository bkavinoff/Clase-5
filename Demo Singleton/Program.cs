using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton single1 = Singleton.GetInstancia();
            Singleton single2 = Singleton.GetInstancia();
            Singleton single3 = Singleton.GetInstancia();
            Singleton single4 = Singleton.GetInstancia();


        }
    }
}
