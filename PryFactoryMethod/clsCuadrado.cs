using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFactoryMethod
{
    class clsCuadrado : clsFiguras
    {
        public override double Area(double a, double b)
        {
            return a * a;
        }
        public override double Perimetro(double a, double b)
        {
            return 4 * a;
        }
        public override string descripcion_figura()
        {
            return "El cuadrado es un poligono regular de 4 lados iguales, asi mismo sus agulos son todos de 90 grados.";
        }
    }
}
