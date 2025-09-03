using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Policia : Persona
    {
        public int NumeroPlaca { get; set; }
        //public int DNI { get; set; }



        public Policia(int dni, string nombre, int numeroPlaca):base(dni,nombre)
        {
            
            NumeroPlaca = numeroPlaca;

        }
        public override string VerDatos()
        {
            return $"DNI {DNI} - Nombre {Nombre}(Placa: {NumeroPlaca})";
        }
    }
}
