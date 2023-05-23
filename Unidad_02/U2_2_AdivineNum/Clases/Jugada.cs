using System;

namespace Clases
{
    public class Jugada
    {
        private int numero;
        private int intentos;
        private bool adivino;


        public Jugada(int minNum, int maxNum)
        {
            Random rnd = new Random();
            Numero = rnd.Next(minNum,maxNum);  // Alcance
            Intentos = 0;
            
        }

        public int Numero
        {
            get { return numero; } 
            set { numero = value; }
        }

        public int Intentos
        {
            get { return intentos; }
            set { intentos = value; }
        }

        public bool Adivino
        {
            get { return adivino; }
            set { adivino = value; }
        }

        public bool comparar(int n)
        {
            return (numero == n);
        }

        public bool comparar(int n, bool ayuda)
        {
            if (ayuda)
            {
                if (numero < n)
                {
                    Console.WriteLine("\nEl número oculto es menor\n");
                }
                if(numero > n)
                {
                    Console.WriteLine("\nEl número oculto es mayor\n");
                }
            }
            return numero == n;
        }

        
    }
}
