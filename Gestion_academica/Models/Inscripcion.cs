using System;

using System;

namespace SistemaAcademico.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }

        public Estudiante? Estudiante { get; set; }
        public Asignatura? Asignatura { get; set; }
    }
}