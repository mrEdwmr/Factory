using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFactoryMethod
{
    public class clsFactory
    {
        public static clsFiguras factoryObjects(int op) {
            switch (op)
            {
                case 1:
                    return new clsTriangulo();
                case 2:
                    return new clsCuadrado();
                case 3:
                    return new clsRectangulo();
                case 4:
                    return new clsCirculo();
                default:
                    return null;
            }
        }
    }
}
