namespace Clases
{
    public class Juego
    {
        public void Menu()
        {
            string op = "";
            while (!op.Equals("3"))
            {
                Console.WriteLine("Bienvenido al menú de Adivina el numero\n");
                Console.WriteLine("1. Jugar sin ayuda\n2. Jugar con Ayuda\n3. Salir");
                op = Console.ReadLine();

                switch(op)
                {
                    case "1": this.comenzarJuego(false); break;
                    case "2": this.comenzarJuego(true); break;
                }

            }

        }

        private void comenzarJuego(bool ayuda)
        {
            // Pedir limites
            Console.WriteLine("\nIngrese el numero minimo");
            int inf = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el numero máx");
            int sup = Int32.Parse(Console.ReadLine());

            Jugada j = new Jugada(inf, sup);
           

            Console.WriteLine("\nSe ha creado una nueva jugada " + inf + " - " + sup);

            Console.WriteLine("\nEs hora de adivinar el numero!\n");

            while (j.Intentos < 3)
            {
                Console.WriteLine("Intento " + (1+j.Intentos) + ": ");
                int num = Int32.Parse(Console.ReadLine());
                if (j.comparar(num,ayuda))
                {
                    Console.WriteLine("Muy bien! Has adivinado el numero\n\n");
                    break;
                }

                j.Intentos++;
            }

            if(j.Intentos == 3){
                Console.WriteLine("El número era: " + j.Numero + "\n");
            }

        }

      


    }

}