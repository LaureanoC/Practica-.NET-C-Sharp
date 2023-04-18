Console.WriteLine("Ingresar texto");
String texto = Console.ReadLine();
Console.WriteLine(texto.Length);
if (texto.Length == 0)
{
    Console.WriteLine("Fin.");
}
else
{


    char op = 'x';

    while (op != '4')
    {
        Console.WriteLine("\nSeleccionar opción\n\n" +
        "1.Texto en mayúsculas\n\n" +
        "2.Texto en minusculas\n\n" +
        "3. Longitud del texto\n\n" +
        "4. Salir");
        op = Console.ReadKey().KeyChar;

        switch (op)
        {
            case '1':
                Console.WriteLine("\n\nTexto ingresado en mayúscula: " + texto.ToUpper());
                break;
            case '2':
                Console.WriteLine("\n\nTexto ingresado en minúscula: " + texto.ToLower());
                break;
            case '3':
                Console.WriteLine("\n\nLongitud del texto: " + texto.Length);
                break;

        }


    }
}
