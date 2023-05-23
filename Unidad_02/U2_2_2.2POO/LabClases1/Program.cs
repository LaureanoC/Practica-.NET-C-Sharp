using Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        A padre = new A();
        padre.M1();
        padre.M2();
        padre.M3();

        B hijo = new B();
        hijo.M1();
        hijo.M2();
        hijo.M3();
        hijo.M4();
                

    }
}