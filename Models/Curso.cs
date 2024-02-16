namespace APINUMERO2.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string NombreCurso { get; set; }
        public string Profesor { get; set; }
        public List<CursoEstudiante> CursosEstudiantes { get; set; }
    }
}
