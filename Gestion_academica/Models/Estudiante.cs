using System;

namespace SistemaAcademico.Models
{
    public class Estudiante : Persona
    {
        public string Matricula { get; set; }
        public string Carrera { get; set; }
    }
}