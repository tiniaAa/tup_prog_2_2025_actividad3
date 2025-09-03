using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        
        public Persona(int dni, string nombre )
        {
            DNI = dni;
            Nombre = nombre;
        }

        public virtual string VerDatos()
        {


            return $"{Nombre}(DNI:{DNI}) ";


        }



    }
}
