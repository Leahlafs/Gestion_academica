using SistemaAcademico.Data;
using SistemaAcademico.Services;

namespace SistemaAcademico;

class Program
{
    static void Main()
    {
        using var context = new AcademicoContext();
        var registro = new RegistroService(context);
        var consulta = new ConsultaService(context);

        while (true)
        {
            Console.WriteLine("\n=== SISTEMA DE GESTIÓN ACADÉMICA ===");
            Console.WriteLine("1. Registrar estudiante");
            Console.WriteLine("2. Registrar profesor");
            Console.WriteLine("3. Registrar asignatura");
            Console.WriteLine("4. Inscribir estudiante en asignatura");
            Console.WriteLine("5. Listar estudiantes con sus asignaturas");
            Console.WriteLine("6. Listar asignaturas con sus estudiantes");
            Console.WriteLine("7. Consulta adicional");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            switch (Console.ReadLine())
            {
                case "1": registro.RegistrarEstudiante(); break;
                case "2": registro.RegistrarProfesor(); break;
                case "3": registro.RegistrarAsignatura(); break;
                case "4": registro.InscribirEstudiante(); break;
                case "5": consulta.ListarEstudiantesConAsignaturas(); break;
                case "6": consulta.ListarAsignaturasConEstudiantes(); break;
                case "7": consulta.ConsultaAdicional(); break;
                case "0": return;
                default: Console.WriteLine("Opción inválida."); break;
            }
        }
    }
}