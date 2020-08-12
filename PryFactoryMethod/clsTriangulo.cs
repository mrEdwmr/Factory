using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFactoryMethod
{
    class clsTriangulo : clsFiguras
    {
        public override double Area(double a, double b)
        {
            return (a * b) / 2;
        }
        public override double Perimetro(double a, double b)
        {
            return 3 * a;
        }
        public override string descripcion_figura()
        {
            return "El triangulo es una figura imaginaria formada por 3 vertices o tres elementos que tienen una relacion";
        }
    }
}
