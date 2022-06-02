using System;
using System.Collections.Generic;
using System.Linq;

namespace Buscador_Alumnos
{
    class Profesor 
    {
        //NO HEREDA EN ESTE CASO ALUMNO, PORQUE PROFESOR NO NECESITA SUS METODOS, PERO PUEDE USAR LOS METODOS
        //DE ALUMNO APLICANDOSELOS A LOS "ALUMNOS", PORQUE LA CLASE DE ALUMNOS ES PUBLICA Y SUS METODOS TBM


       
       /// <summary>
       /// Recorre una lista de alumnos
       /// </summary>
       /// <param name="listaRecorrida"></param>
        #region RecorrerAlumno&Alumnos
        public static void RecorrerListaDeAlumnos(List<Alumno> listaRecorrida)
        {
            foreach (var recorrer in listaRecorrida)
            {
                Console.WriteLine($"nombre Alumno: {recorrer.GetNombre()} \t ID: {recorrer.GetIdentificacion()} \t promedio: {recorrer.GetPromedio()} \t alumno activo?: {recorrer.GetActivo()}");
            }
        }
        /// <summary>
        /// recorre un alumno
        /// </summary>
        /// <param name="alumnito"></param>
        public static void RecorrerAlumno(Alumno alumnito)
        {
            Console.WriteLine($"nombre Alumno: {alumnito.GetNombre()} \t ID: {alumnito.GetIdentificacion()} \t promedio: {alumnito.GetPromedio()} \t alumno activo?: {alumnito.GetActivo()}");

        }
        #endregion

        /// <summary>
        /// Nombre de un alumno
        /// </summary>
        /// <param name="nombreAlumno"></param>
        /// <param name="alumnos"></param>
        /// <returns>devuelve el nombre de un alumno</returns>
        public static Alumno Nombre(string nombreAlumno, List<Alumno> alumnos)
        {

            Alumno nombresEncontrados = new Alumno();
            foreach (Alumno alumnosX in alumnos)
            {
                if (nombreAlumno.ToLower() == alumnosX.GetNombre().ToLower())
                {
                    nombresEncontrados = alumnosX;
                }
            }
            return nombresEncontrados;
        }
        
        /// <summary>
        /// Metodo para buscar un Alumno segun Identificacion
        /// </summary>
        /// <param name="identificacionDelAlumno"></param>
        /// <param name="alumnos"></param>
        /// <returns>devuelve datos del alumno identificado</returns>
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

        /// <summary>
        /// Metodo para encontrar alumnos inactivos
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns>devuelve alumnos inactivos</returns>
        public static List<Alumno> AlumnosInactivos(List<Alumno> alumnos)
        {
            List<Alumno> alumnosInactivos = new List<Alumno>();
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.GetActivo() == false)
                {
                    alumnosInactivos.Add(alumno);
                }
            }
            return alumnosInactivos;
        }

        /// <summary>
        /// Metodo para buscar algun alumno con promedio mayor a 7
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns>devuelve el primer alumno encontrado con mayor promedio a 7</returns>
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

        /// <summary>
        /// Metodo para buscar alumnos desaprobados
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns>devuelve alumno/s desaprobados</returns>
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

        /// <summary>
        /// Metodo que busca el alumno con mayor promedio
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns></returns>
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
