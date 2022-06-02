using System;
using System.Collections.Generic;

namespace Buscador_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("andres", 4, true, new List<int> { 4, 1,-5, 2 });
            Alumno alumno2 = new Alumno("jose", 8, false, new List<int> { 10, 9, 4, 6 });
            Alumno alumno3 = new Alumno("andres", 5, false, new List<int> { 10, 5, 4, 6 });
            Alumno alumno4 = new Alumno("sofia", 20, true, new List<int> { 0, 2, 4, 5 });
            Alumno alumno5 = new Alumno("andres", 8, false, new List<int> { 10, 9, 4, 6 });

            foreach (int nota in alumno1.GetNotas())
            {
                Console.WriteLine("Notas alumno: " + nota);
            }

            Console.WriteLine($"El promedio del alumno es: {alumno1.GetPromedio()}");

            Console.WriteLine($"La identificacion es: {alumno1.GetIdentificacion()}");

            Console.WriteLine($"La identificacion es: {alumno1.GetNombre()}");

            Console.WriteLine($"El humano activo?: {alumno1.GetActivo()}");

            Console.WriteLine();
      
            List<Alumno> alumnos = new List<Alumno> ();
            alumnos.Add(alumno1);
            alumnos.Add(alumno2);
            alumnos.Add(alumno3);
            alumnos.Add(alumno4);
            alumnos.Add(alumno5);

            Profesor.RecorrerAlumno(Profesor.Nombre("ANDRES", alumnos));
            Console.WriteLine();
            Profesor.RecorrerAlumno(Profesor.Nombre("SOFIA", alumnos));
            Console.WriteLine();

            Profesor.RecorrerAlumno(Profesor.BuscarAlumnoPorIdentificacion(20, alumnos));
            Console.WriteLine();

            Console.WriteLine();
            Profesor.RecorrerListaDeAlumnos(Profesor.AlumnosInactivos(alumnos));
            Console.WriteLine();

            Profesor.RecorrerAlumno(Profesor.AlumnosConMayorPromedioASiete(alumnos));
            Console.WriteLine();

            Console.WriteLine("Alumnos Desaprobados:");
            Profesor.RecorrerListaDeAlumnos(Profesor.AlumnosDesaprobado(alumnos));

            Console.WriteLine();
            Profesor.RecorrerAlumno(Profesor.AlumnoConMayorPromedio(alumnos));


        }
    }
}




