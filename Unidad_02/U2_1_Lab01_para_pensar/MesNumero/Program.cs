//MesNum
Dictionary<string, int> mn = new Dictionary<string, int>();

mn.Add("enero", 1);
mn.Add("febrero", 2);
mn.Add("marzo", 3);
mn.Add("abril", 4);
mn.Add("mayo", 5);
mn.Add("junio", 6);
mn.Add("julio", 7);
mn.Add("agosto", 8);
mn.Add("septiembre", 9);
mn.Add("octubre", 10);
mn.Add("noviembre", 11);
mn.Add("diciembre", 12);

Console.WriteLine("Ingrese el nombre de un mes");
string nom = Console.ReadLine();

Console.WriteLine("El número del mes de " + nom + " es " + mn[nom]);
