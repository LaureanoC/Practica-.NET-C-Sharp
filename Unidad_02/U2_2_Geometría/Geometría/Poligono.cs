using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometría
{
    public class Poligono
    {
        public double calcularPerimetro(params double[] lados)
        {
            double suma = 0;
            foreach (double lado in lados)
            {
                suma += lado;
            }

            return suma;
        }

        public virtual double calcularSuperficie()
        {
            Console.WriteLine("Superficie calculada");
            return 0;
        }
        
    }
}