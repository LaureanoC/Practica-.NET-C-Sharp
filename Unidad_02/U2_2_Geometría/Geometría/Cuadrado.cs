using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometría
{
    public class Cuadrado : Rectangulo
    {
        public double calcularSuperficie(double l)
        {
            return l * l;
        }
    }
}