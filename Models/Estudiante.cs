﻿namespace APINUMERO2.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public List<CursoEstudiante> CursosEstudiantes { get; set; }
    }
}
