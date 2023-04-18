public class Romano
{
    private static void Main(string[] args)
    {
     // Millar(9)       Centena(9)       Decena(9)       Unidad(9) 

        Console.WriteLine("Solo funciona hasta 3999");
        string numero = Console.ReadLine();

        Console.WriteLine("Longitud: " + numero.Length);

       
        string romano = "";

        if (numero.Length == 1)
        {
            romano = Romano.Unidad(numero);
        }

        if (numero.Length == 2)
        {
            Console.WriteLine("tostring  " + numero[1].ToString());
            romano = Romano.Decena(numero[0].ToString()) 
                   + Romano.Unidad(numero[1].ToString());
            
        }

        if (numero.Length == 3)
        {
            romano = Romano.Centena(numero[0].ToString())
                   + Romano.Decena(numero[1].ToString())
                   + Romano.Unidad(numero[2].ToString()); 
        }

        if (numero.Length == 4)
        {
            romano = Romano.Millar(numero[0].ToString())
                   + Romano.Centena(numero[1].ToString())
                   + Romano.Decena(numero[2].ToString())
                   + Romano.Unidad(numero[3].ToString());

        }

        Console.WriteLine(romano);

        // Decena


    } // fin del main



    public static string Millar(string numero)
    {
        string millar = "";
        switch (numero)
        {
            case "1":
                millar = "M";
                break;
            case "2":
                millar = "MM";
                break;
            case "3":
                millar = "MMM";
                break;
        }
        return millar;
    }





    public static string Centena(string numero)
    {
        string centena = "";
        switch (numero)
        {
            case "1":
                centena = "C";
                break;
            case "2":
                centena = "CC";
                break;
            case "3":
                centena = "CCC";
                break;
            case "4":
                centena = "CD";
                break;
            case "5":
                centena = "D";
                break;
            case "6":
                centena = "DC";
                break;
            case "7":
                centena = "DCC";
                break;
            case "8":
                centena = "DCCC";
                break;
            case "9":
                centena = "CM";
                break;

        }
        return centena;
    }

    public static string Decena(string numero)
    {
        string decena = "";
        switch (numero)
        {
            case "1":
                decena = "X";
                break;
            case "2":
                decena = "XX";
                break;
            case "3":
                decena = "XXX";
                break;
            case "4":
                decena = "XL";
                break;
            case "5":
                decena = "L";
                break;
            case "6":
                decena = "LX";
                break;
            case "7":
                decena = "LXX";
                break;
            case "8":
                decena = "LXXX";
                break;
            case "9":
                decena = "XC";
                break;

        }
        return decena;

    }

    static string Unidad(string numero)
    {
        string unidad = "";
        switch (numero)
        {
            case "1":
                unidad = "I";
                break;
            case "2":
                unidad = "II";
                break;
            case "3":
                unidad = "III";
                break;
            case "4":
                unidad = "IV";
                break;
            case "5":
                unidad = "V";
                break;
            case "6":
                unidad = "VI";
                break;
            case "7":
                unidad = "VII";
                break;
            case "8":
                unidad = "VIII";
                break;
            case "9":
                unidad = "IX";
                break;

        }

        return unidad;
    }
}

