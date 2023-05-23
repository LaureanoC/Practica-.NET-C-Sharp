using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometría
{
    public class TrianguloRectangulo
    {
        public double calcularPerimetro(double b, double altura, double hipotenusa)
        {
            return b + altura + hipotenusa;
        }

        public double calcularSuperficie(double b, double altura, double hipotenusa)
        {
            return b * altura / 2;
        }
    }
}