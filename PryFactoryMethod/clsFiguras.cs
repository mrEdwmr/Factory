using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFactoryMethod
{
    public abstract class clsFiguras
    {
        public abstract double Perimetro(double a, double b);
        public abstract double Area(double a, double b);
        public abstract string descripcion_figura();
    }
}
