using System.IO;
escribir();
leer();

static void leer()
{
    StreamReader lector = File.OpenText("agenda.txt");
    string linea;
    Console.WriteLine("Nombre\tApellido\tEmail\t\t\tTelefono");
    do
    {
        linea = lector.ReadLine();
        if (linea != null)
        {
            string[] valores = linea.Split(";");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
        }
    } while (linea != null);

    lector.Close();
}

static void escribir()
{
    StreamWriter escritor = File.AppendText("agenda.txt");
    Console.WriteLine("Ingresar nuevos datos de contacto - N para salir");
    string rta = "s";

    while (rta != "n")
    {
        Console.WriteLine("Ingresar nombre");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingresar apellido");
        string apellido = Console.ReadLine();

        Console.WriteLine("Ingresar email");
        string email = Console.ReadLine();

        Console.WriteLine("Ingresar telefono");
        string tel = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();

        escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + tel);

        Console.WriteLine("Desea agregar otro contacto? S/N");
        rta = Console.ReadLine();
    }

    escritor.Close();


}