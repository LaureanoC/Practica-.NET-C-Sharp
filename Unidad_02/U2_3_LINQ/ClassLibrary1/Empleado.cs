namespace ClassLibrary1
{
    //Empleado tiene las propiedades Id (int), Nombre (string),Sueldo(decimal)
    public class Empleado
    {
        private int id;
        private string nombre;
        private decimal sueldo;

        public Empleado(int id, string nombre, decimal sueldo)
        {
            this.id = id;
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public int Id { get { return id; } }
        public string Nombre { get {  return nombre; } }
        public decimal Sueldo { get {  return sueldo; } }

    }
}
