using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDPAbstracta
{
   interface IFabrica_coche
    {
        Crear_carroceria crear_Carroceria();
        Crear_motor crear_Motor();
    }
}
