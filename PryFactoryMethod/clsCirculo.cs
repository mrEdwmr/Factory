using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFactoryMethod
{
    class clsCirculo : clsFiguras
    {
        public override double Area(double a, double b)
        {
            return Math.PI * (a * a);
        }
        public override double Perimetro(double a, double b)
        {
            return 2 * Math.PI * a;
        }
        public override string descripcion_figura()
        {
            return "El circulo es una figura geometrica delimitada por una circunferencia.";
        }
    }
}
