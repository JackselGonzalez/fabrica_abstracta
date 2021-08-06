using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDPAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica_coche Fabrica;
            Crear_motor Cmotor;
            Crear_color CColor;
            Crear_carroceria CCarroceria;

            string coche, Color, Carroceria;
            Console.WriteLine("Seleccionar el coche (Hiu/Kia)");
            coche = Console.ReadLine().ToUpper();

            Console.WriteLine("Seleccione el color (Blue/Green)");
            Color = Console.ReadLine().ToUpper();

            Console.WriteLine("Seleccione la carroceria (Ref/Bli)");
            Carroceria = Console.ReadLine().ToUpper();

            if (Carroceria.Equals("")
        }
    }
}
