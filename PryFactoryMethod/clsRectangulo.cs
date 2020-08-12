using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFactoryMethod
{
    class clsRectangulo : clsFiguras
    {
        public override double Area(double a, double b)
        {
            return a * b;
        }
        public override double Perimetro(double a, double b)
        {
            return (2*a)+ (2*b);
        }
        public override string descripcion_figura()
        {
            return "El rectangulo es una figura geometrica que se encuentra compuesta por 4 lados, de los cuales 2 tienen una longitud y los dos restantes otras, que ademas forman 4 angulos rectos de 90 grados.";
        }
    }
}
