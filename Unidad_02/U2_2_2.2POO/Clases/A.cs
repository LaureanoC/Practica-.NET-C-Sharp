namespace Clases
{
    public class A
    {
        private string NombreInstancia;

        public A() 
        {
            NombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre) 
        {
            NombreInstancia = nombre;
        }

        public void mostrarNombre()
        {
            Console.WriteLine(this.NombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("Método 1 invocado");
        }
        public void M2()
        {
            Console.WriteLine("Método 2 invocado");
        }
        public void M3()
        {
            Console.WriteLine("Método 3 invocado");
        }
    }
}