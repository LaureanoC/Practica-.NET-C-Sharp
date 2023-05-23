namespace Clases
{
    public class Persona
    {
        private string dni;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento; // YYYY-MM-DD

        public Persona(string d, string n, string a, string e)
        {
            dni = d;
            nombre = n;
            apellido = a;
            fechaNacimiento = DateTime.Parse(e);
            Console.WriteLine("Instancia creada");
        }

        public string Id
        {
            get { return dni; }
            set { dni = value; }
        }
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

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        
        public string getFullName()
        {
            return nombre + apellido;
        }

        public int getEdad()
        {
            // Diferencia de años entre hoy y su nacimiento
            // 2000-10-03      edad = 23      
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            // Compruebo si cumplió los años
            //  2000-10-03      >       2000-05-23
            // Aún no cumplió años, le resto 1
            if( fechaNacimiento > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
    
    }
}