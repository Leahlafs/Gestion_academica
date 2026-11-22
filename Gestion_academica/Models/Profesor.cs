using System;

namespace SistemaAcademico.Models
{
    public class Profesor : Persona
    {
        public string Especialidad { get; set; }
        public decimal Salario { get; set; }
    }
}