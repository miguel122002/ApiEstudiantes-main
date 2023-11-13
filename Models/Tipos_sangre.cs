using System.ComponentModel.DataAnnotations;
namespace ApiEstudiante.Models;
public class Tipos_sangre{
     [Key]
    public Int32 id_tipos_sangre { get; set; }
    public string? sangre { get; set; }
}