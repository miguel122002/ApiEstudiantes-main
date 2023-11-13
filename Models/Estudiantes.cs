using System.ComponentModel.DataAnnotations;
namespace ApiEstudiante.Models;

public class Estudiantes{
    [Key]
    public Int32 id_estudiante { get; set; }
    public string? carne { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public string? correo_electronico { get; set; }
    public string? id_tipo_sangre { get; set; }
    public DateTime? fecha_nacimiento { get; set; }
    
}