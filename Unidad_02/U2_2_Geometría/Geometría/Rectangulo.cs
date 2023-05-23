using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometría
{
    public class Rectangulo : Poligono
    {
        public double calcularSuperficie(double b, double h)
        {
            return b * h / 2;
        }


    }
}