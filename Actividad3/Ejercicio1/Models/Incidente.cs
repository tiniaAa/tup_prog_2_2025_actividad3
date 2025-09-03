using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Incidente
    {
        public string Motivo { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }

        public Policia OficialACargo ;
        public Persona Sujeto ;
        
            

        public Incidente (Policia policia , Persona sujeto )
        {
            
            OficialACargo = policia;
            Sujeto = sujeto;
            
        }

        abstract public string VerDescripcion();
        


    }
}
