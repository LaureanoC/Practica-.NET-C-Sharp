/*
Dado un ArrayList que incluya al menos 10 Ciudades de Argentina incluyendo Nombre y Código
Postal usar LINQ para obtener y mostrar por Consola el Código Postal de aquellas ciudades que
incluyan dentro de su nombre una expresión de busqueda de tres caracteres, sin respetar
mayusculas o minusculas. Por ejemplo, si se ingresa “ros” y el ArrayList incluye Rosario entonces
debe mostrarse el Código Postal de Rosario.
 */

using System.Collections;
using ClassLibrary1;

ArrayList ciudades = new ArrayList
{
    new Ciudad("arrecifes", "2740"),
    new Ciudad("rosario", "2000"),
    new Ciudad("ezeiza", "1804"),
    new Ciudad("banfield", "1821"),
    new Ciudad("temperley", "1835"),
    new Ciudad("almirante brown", "1846"),
    new Ciudad("palacios", "2326"),
    new Ciudad("monigotes", "2342"),
    new Ciudad("hersilia", "2352"),
    new Ciudad("frontera", "2438")
    
};

Console.WriteLine("Ingrese los primeros caracteres de la ciudad");

string input = Console.ReadLine().ToLower();

var busqueda = from Ciudad c in ciudades where c.Nombre.Contains(input)  select c;


foreach (Ciudad c in busqueda)
{
    Console.WriteLine("El codigo postal de " + c.Nombre +" es: ");
    Console.WriteLine(c.Cod);
}

