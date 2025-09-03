using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Guardia
    {
        public int HoraDesde{ get; set; }
        public int MinutoDesde{ get; set; }
        public int HoraHasta{ get; set; }
        public int MinutoHasta{ get; set; }
        public int CantidadMinutos{get; set;}
        
        public Policia OficialAsignado { get; set; }
        public Guardia()
        {

        }
        public void  AsignarPolicia(Policia policia, int h, int m , int cantM)
        {
            HoraDesde = h;
            MinutoDesde=m;
            MinutoHasta = cantM;
            OficialAsignado = policia;
            CalcMin();
                

        }
        public void CalcMin()
        {
            MinutoHasta = (HoraDesde * 60 + MinutoDesde + CantidadMinutos) % 60;
            HoraHasta = (HoraDesde * 60 + MinutoDesde + CantidadMinutos) / 60;
        }

    }
}
