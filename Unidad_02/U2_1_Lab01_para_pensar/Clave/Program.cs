internal class Program
{
    private static void Main(string[] args)
    {
        int intentos = 0;
        string password = "laureano";
        string entrada = ""; // Cambié el scope

        while(intentos < 4)
        {
            intentos++;
            Console.WriteLine("Introduzca clave");
            entrada = Console.ReadLine();

            if( entrada == password)
            {
                break;
            }
            else
            {
                Console.WriteLine("Clave incorrecta");
            }

        }
        
        if(entrada == password)
        {
            Console.WriteLine("Clave correcta al intento número "+ intentos);
        }



        
        
    }
}