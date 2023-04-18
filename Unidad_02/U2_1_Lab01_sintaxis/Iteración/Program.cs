Console.WriteLine("Cantidad de iteraciones: ");
int cantIteraciones = Convert.ToInt32(Console.ReadLine());

// Array de strings
string[] cadenas = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine("\n[" + i + "]" + " Ingrese una cadena: ");

    cadenas[i] = Console.ReadLine();
}

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine(cadenas[i]);
}