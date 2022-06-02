using System;
using System.Collections.Generic;

namespace Buscador_Alumnos
{
    class Alumno
    {

        //ATRIBUTOS//
        private string nombre;
        private int identificacion;
        private bool activo;
        
        private List<int> notas;

        //-----------------PARTE 1 DEL EJERCICIO-------------//           
        public Alumno() { }

        public Alumno(string nombre, int identificacion, bool activo, List<int> notas)
        {
            this.nombre = nombre;
            this.identificacion = identificacion;
            this.activo = true;
            this.notas = notas;
        }
        /// <summary>
        /// Metodo que muestra notas de un alumno
        /// </summary>
        /// <returns></returns>
        public List<int> GetNotas()
        {
            return this.notas;
        }
        /// <summary>
        /// Metodo que muestra promedio de un alumno
        /// </summary>
        /// <returns></returns>
        public double GetPromedio() 
        {
            double notasSumadas = 0;
            List<int> notasAPromediar = this.GetNotas();
            for (int i = 0; i < notasAPromediar.Count; i++)
            {
                notasSumadas += notasAPromediar[i];
            } 
            return notasSumadas / notasAPromediar.Count;
        }
        /// <summary>
        /// Metodo que muestra identificacion de un alumno
        /// </summary>
        /// <returns></returns>
        public int GetIdentificacion()
        {
            return this.identificacion;
        }
        /// <summary>
        /// Metodo que devuelve el nombre de un alumno
        /// </summary>
        /// <returns></returns>
        public string GetNombre()
        {
            return this.nombre;
        }
        /// <summary>
        /// Metodo que muestra si un alumno esta activo o no
        /// </summary>
        /// <returns></returns>
        public bool GetActivo()
        {
            return this.activo;
        }

   
    }
}

