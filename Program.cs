using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pilas
{
    internal class Program
    {
        public class Test
        {

            public static void Main(string[] args)
            {
                Pila pila = new Pila();
                Console.WriteLine(pila.ConversionInToPos(Console.ReadLine()));
                Minions minions = new Minions();
            }
        }
    }
}
