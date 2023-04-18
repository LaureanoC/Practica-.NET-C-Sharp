// Divisible por 4, si es por 100 no a no, a no ser que sea divisible por 400

using Microsoft.VisualBasic;

Console.WriteLine("Ingrese un año");
int year = Convert.ToInt32(Console.ReadLine());

if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("El año " + year + " es bisiesto");
}
else
{
    Console.WriteLine("El año " + year + " no es bisiesto");
}


