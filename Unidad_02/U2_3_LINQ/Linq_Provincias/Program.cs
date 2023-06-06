namespace U2_Linq_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1) Dado un Array que incluya todas las Provincias de Argentina usar LINQ para obtener y mostrar
            por Consola aquellas provincias que empiezan con la letra “S” o “T”
            */

            string[] provincias = {"Buenos aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Rios",
"Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan",
"San Luis", "Santa Cruz", "Santa Fe","Santiago del Estero", "Tierra del fuego", "Tucumán"};

            var provinciaSO = (from p in provincias where p.StartsWith("T") || p.StartsWith("S") select p);

            foreach (var pro in provinciaSO)
            {
                Console.WriteLine(pro);
            }

        }
    }
}