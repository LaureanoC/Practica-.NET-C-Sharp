namespace Clases
{
    public class B : A
    {
        public B()
        {
            
        }

        public B(string nombre): base("Instancia de B") 
        {
            
        }

        public void M4()
        {
            Console.WriteLine("Método del hijo invocado");
        }
    }
}
