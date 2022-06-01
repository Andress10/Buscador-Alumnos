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
        private double promedioNotas;
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

        public List<int> GetNotas()
        {
            return this.notas;
        }

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

        public int GetIdentificacion()
        {
            return this.identificacion;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public bool GetActivo()
        {
            return this.activo;
        }

        public void SetterActivo(bool nuevoActivo)
        {
            this.activo = nuevoActivo;
        }
    }
}

