namespace DirectorioLibros.Models
{
    public class Libro
    {
        public int Id { get; set; } // Identificador único
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacion { get; set; }
    }
}