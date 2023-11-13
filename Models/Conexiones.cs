using Microsoft.EntityFrameworkCore;
namespace ApiEstudiante.Models;

public class Conexiones : DbContext
{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<Estudiantes> Estudiantes { get; set; } = null!;
    public DbSet<Tipos_sangre> Tipos_sangre { get; set; } = null!;
}