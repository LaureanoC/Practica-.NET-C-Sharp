internal class Program
{
    private static void Main(string[] args)
    {
        /*                                 0  +  0 = 0col                                         
                                           0  + f1 = 1col             --*-- f(1) = 2|*|2  vacioizq = filaTot-fila1 = 2
                * 1 col 1 fila             f1 + f2 = 3colf2           -***- f(2) = 1|*|1  vizq = 3 - 2 = 1
               *** 3 col 2 fila            f2 + f3 = 5colf3           ***** f(3) = 0|*|0
              ***** 5 col 3 fila           f3 + f4 = 7colf4                  
             ******* 7 col 4 fila          f4 + f5 = 9colf5                  
            ********* 9 col 5 fila         f5 + f6 = 11colf6                 
           *********** 11 col 6 fila                                                    
                                                                            
                                  
         */


        Console.WriteLine("Ingresar número de filas");
        int filas = Convert.ToInt32(Console.ReadLine());



        //numfila         
        for(int i = 1; i <= filas; i++)
        {
            //rellenomitad izq
            for(int j = 1; j <= filas-i; j++)
            {
                Console.Write(" ");
            }

            // imprimo          2 * numfila - 1
            for(int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }




}

    




