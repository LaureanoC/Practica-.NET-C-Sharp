namespace LibreriaDeClases
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private string localidad;

        public static int Contador = 0;
        public Persona(string nombre, string apellido, string localidad)
        {
            this.id = Persona.Contador;
            Contador ++;
            this.nombre = nombre;
            this.apellido = apellido;
            this.localidad = localidad;
        }

        public int Id { get { return id; } }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set
            {
                localidad = value;
            }
        }
    }
}