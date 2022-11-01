using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaUS.datos.model
{
    class Alumno
    {
        //ATRIBUTOS
        private string nombre;
        private int calificacion;
        
        //CONSTRUCTOR
        public Alumno()
        {
            this.nombre = "";
            this.calificacion = 0;  
        }
        
        //publicos
        public string Nombre { get => nombre; set => nombre = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
    }
}
