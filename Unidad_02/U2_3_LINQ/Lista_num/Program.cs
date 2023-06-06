using System.Collections.Generic;

namespace U2_2._3_ListaNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2) Crear un programa que acepte una lista de números, los almacene en un objeto del tipo List<int>
            y luego usando LINQ muestre por Consola aquellos que son mayores a 20.
            */

            List<int> list = new List<int>();

            Console.WriteLine("Ingrese un numero - 0 para salir");
            int num = 1;

            while (num != 0)
            {

                list.Add(num);
                num = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Listado: ");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            var mayores = (from m in list where m > 20 select m);

            Console.WriteLine("Listado mayores a 20: ");

            foreach (int i in mayores)
            {
                Console.WriteLine(i);
            }

        }
    }
}