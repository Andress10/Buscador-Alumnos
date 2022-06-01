using System;
using System.Collections.Generic;
using System.Linq;

namespace Buscador_Alumnos
{
    class Profesor 
    {
        //NO HEREDA EN ESTE CASO ALUMNO, PORQUE PROFESOR NO NECESITA SUS METODOS, PERO PUEDE USAR LOS METODOS
        //DE ALUMNO APLICANDOSELOS A LOS "ALUMNOS", PORQUE LA CLASE DE ALUMNOS ES PUBLICA Y SUS METODOS TBM
        public static List<Alumno> Nombre(string nombreAlumno, List<Alumno> alumnos)
        {

            List<Alumno> nombresEncontrados = new List<Alumno>();
            foreach (Alumno alumnosX in alumnos)
            {
                if (nombreAlumno.ToLower() == alumnosX.GetNombre().ToLower())
                {
                    nombresEncontrados.Add(alumnosX);
                }
            }
            return nombresEncontrados;
        }

        public static void RecorrerListaDeAlumnos(List<Alumno> listaRecorrida)
        {
            foreach (var recorrer in listaRecorrida)
            {
                Console.WriteLine($"nombre Alumno: {recorrer.GetNombre()} \t ID: {recorrer.GetIdentificacion()} \t promedio: {recorrer.GetPromedio()} \t alumno activo?: {recorrer.GetActivo()}");
            }
        }
        public static void RecorrerAlumno(Alumno alumnito)
        {
            Console.WriteLine($"nombre Alumno: {alumnito.GetNombre()} \t ID: {alumnito.GetIdentificacion()} \t promedio: {alumnito.GetPromedio()} \t alumno activo?: {alumnito.GetActivo()}");

        }

        public static Alumno BuscarAlumnoPorIdentificacion(int identificacionDelAlumno, List<Alumno> alumnos)
        {
            Alumno alumnoEncontradoPorIdentificacion = new Alumno();
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.GetIdentificacion() == identificacionDelAlumno)
                {
                    alumnoEncontradoPorIdentificacion = alumno;
                }
            }
            return alumnoEncontradoPorIdentificacion;
        }

        public static List<Alumno> AlumnosInactivos(List<Alumno> alumnos)
        {
            List<Alumno> alumnosInactivos = new List<Alumno>();
            foreach (Alumno alumno in alumnos)
            {
                if (!alumno.GetActivo())
                {
                    alumnosInactivos.Add(alumno);
                }
            }
            return alumnosInactivos;
        }

        public static Alumno AlumnosConMayorPromedioASiete(List<Alumno> alumnos)
        {
            Alumno alumnosConMayorPromedioASiete = new Alumno();
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.GetPromedio() > 7)
                {
                    alumnosConMayorPromedioASiete = alumno;
                }
            }
            return alumnosConMayorPromedioASiete;
        }

        public static List<Alumno> AlumnosDesaprobado(List<Alumno> alumnos)
        {
            List<Alumno> alumnosDesaprovado = new List<Alumno>();
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.GetPromedio() <= 5)
                {
                    alumnosDesaprovado.Add(alumno);
                }
            }
            return alumnosDesaprovado;
        }

        public static Alumno AlumnoConMayorPromedio(List<Alumno> alumnos)
        {
            Alumno alumnoMejorPromedio = alumnos[0];

            foreach (Alumno alumno in alumnos)
            {
                if (alumnoMejorPromedio.GetPromedio() < alumno.GetPromedio())
                {
                    alumnoMejorPromedio = alumno;
                }
            }

            return alumnoMejorPromedio;
        }
    }
}
