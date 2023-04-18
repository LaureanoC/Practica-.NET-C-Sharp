Console.WriteLine("FIbonacci - Ingresar n");
int a = 0;
int s = 1;
int r = default;

int lim = Convert.ToInt32(Console.ReadLine());

// 0,1,1,2,3,5,8...
// a,s,r
Console.WriteLine("La sucesión queda: ");
Console.WriteLine("0");
for (int i = 0; i < lim; i++)
{
    r = a + s;

    a = s;

    s = r;

    Console.WriteLine(r);
}