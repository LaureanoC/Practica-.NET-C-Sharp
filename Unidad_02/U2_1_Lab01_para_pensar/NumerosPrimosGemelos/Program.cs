internal class PrimoGemelo
{
    private static void Main(string[] args)
    {
        // Los números primos son aquellos que solo son divisibles entre ellos mismos y el 1
        // Los números primos gemelos son dos números primos que difieren en dos unidades.

        // Calcular los n numeros primeros gemelos.

        Console.WriteLine("Ingresar limite de busqueda de numeros primos gemelos");
        int lim = Convert.ToInt32(Console.ReadLine());
     
        BuscarGemelos(lim);

    }

    private static void BuscarGemelos(int num)
    {
        List<int> primos = new List<int>();

        for(int i = 1; i <= num; i++)
        {
            if (PrimoGemelo.EsPrimo(i))
            {
                primos.Add(i);
            }
        }

        Console.WriteLine("Números primos gemelos: ");
    
        if (primos.Count != 0 && primos.Count != 1)
        {
            for(int i = 0; i<primos.Count; i++)
            {
                //Console.WriteLine(i + " -> " + primos[i]);
                if(i <= (primos.Count - 2))
                {
                    //Console.WriteLine("Anteultimo es el " + i);
                    if (primos[i+1] - primos[i] == 2)
                    {
                        Console.WriteLine(primos[i] + " y " + primos[i + 1]);
                    }
                }

               
            }
        } 
       
    }



    private static Boolean EsPrimo(int num)
    {
        int contador = 0;
        for(int i = 1; i <= num; i++)
        {
            if(num % i == 0)
            {
                contador++;
            }

        }

        if(contador == 2) 
        {
            return true;
        }

        return false;
    }
}