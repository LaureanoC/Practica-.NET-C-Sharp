namespace ClassLibrary1
{
    public class Ciudad
    {
        private string nombre;
        private string cod;

        public Ciudad(string nombre, string cod)
        {
            this.nombre = nombre;
            this.cod = cod;
        }
        public string Nombre { get {  return nombre; } }
        public string Cod { get {  return cod; } }
    }
}