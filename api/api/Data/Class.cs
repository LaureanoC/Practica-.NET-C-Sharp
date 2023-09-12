using Microsoft.EntityFrameworkCore;
using DominioAlumno;

namespace api.Data
{
    public class UniversidadContext : DbContext
    {

        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseSqlServer(
                    @"Server=localhost;Database=Universidad ;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");
    
        public UniversidadContext()
        {
            this.Database.EnsureCreated();
        }



    }
}
