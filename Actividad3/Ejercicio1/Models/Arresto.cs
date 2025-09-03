using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public  class Arresto : Incidente
    {
        public Arresto(Persona sujeto, Policia policia ): base (policia,sujeto) { }
        public override string VerDescripcion()
        {
            string descripcion =
$@"Arresto Policial, Emitido a las {Hora}:{Minuto} 
Motivo: {Motivo}
Agente policial interviniente: {OficialACargo.VerDatos()}
Sujeto Arrestado:{Sujeto.VerDatos()}
";
            return descripcion;
        }
    }
}
