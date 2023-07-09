namespace ClassLibrary1
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string localidad;
        private static int Contador = 0;

        public Persona(string n, string l)
        {
            this.id = Contador++;
            this.nombre = n;
            this.localidad = l;
        }

        public int Id { get { return id; } }
        public string Nombre { get {  return nombre; } set { nombre = value; } }
        public string Localidad { get {  return localidad; } set { localidad = value; } }
        
    }
}