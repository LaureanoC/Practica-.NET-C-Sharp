/*Dada una List&lt;Empleado&gt; donde Empleado tiene las propiedades Id (int), Nombre (string),
Sueldo (decimal). 

Crear un programa que acepte dar de alta Empleados en esta lista y luego
muestre por Consola esta misma Lista ordenada por la propiedad Sueldo, tanto de manera
ascendente como descendente.*/

using ClassLibrary1;
Console.WriteLine("1. Dar de alta a empleados");

List<Empleado> list = new List<Empleado>();
string op = "z";
while(op!= "n")
{
    Console.WriteLine("Ingresar ID");
    int id = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Ingresar Nombre");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingresar Sueldo");
    decimal sueldo = decimal.Parse(Console.ReadLine());

    list.Add(new Empleado(id, nombre, sueldo)); 

    Console.WriteLine("Seguir dando de alta? S/N");
    op = Console.ReadLine().ToLower();
}

var linqAsc = from e in list orderby e.Sueldo ascending select e;
var linqDes = from e in list orderby e.Sueldo descending select e;

Console.WriteLine("Sueldo de forma ascendente\n");
foreach (Empleado empleado in linqAsc)
{   
    Console.WriteLine(empleado.Id +" "+ empleado.Nombre + " " + empleado.Sueldo);
}

Console.WriteLine("Sueldo de forma descendente\n");

foreach (Empleado empleado in linqDes)
{
    Console.WriteLine(empleado.Id + " " + empleado.Nombre + " " + empleado.Sueldo);
}

