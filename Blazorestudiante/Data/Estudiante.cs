namespace BlazorApp.Data;
using System.Text.Json.Serialization;
public class Estudiante
    {
        [JsonPropertyName("id_estudiante")]
        public Int32 id_estudiante { get; set; }
        
        [JsonPropertyName("carne")]
        public string? Carne { get; set; }

        [JsonPropertyName("nombres")]
        public string? Nombres { get; set; }

        [JsonPropertyName("apellidos")]
        public string? Apellidos { get; set; }

        [JsonPropertyName("direccion")]
        public string? Direccion { get; set; }

        [JsonPropertyName("telefono")]
        public string? Telefono { get; set; }

        [JsonPropertyName("correo_electronico")]
        public string? correo_electronico { get; set; }

        [JsonPropertyName("id_tipo_sangre")]
        public string? id_tipo_sangre { get; set; }

        [JsonPropertyName("fecha_nacimiento")]
        
        public DateTime? Nacimiento { get; set; }

        

    }