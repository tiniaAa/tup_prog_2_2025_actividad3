using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Comisaria
    {
        public int CantidadIncidentes 
        { get 
            { 
                return Incidentes.Count; 
            } 
        }
        Guardia[] Guardias = new Guardia [2];
        ArrayList agentes = new ArrayList();
        ArrayList Incidentes = new ArrayList();



        public Comisaria()
            {

                for (int n = 0; n < Guardias.Count(); n++)
                {
                    Guardias[n] = new Guardia();
                }
                
            }

        public bool AsignarPolicia(Policia policia )
        {
            agentes.Add( policia );

            return true;
        }
        public Policia VerAgente(int NumeroPlaca)
        {

            int indice = -1;
            int contador = 0;

            while (indice==-1&& contador<agentes.Count)
            {
                Policia agente = agentes[contador] as Policia;
                if (agente.NumeroPlaca == NumeroPlaca )
                {
                    indice = contador;
                }
                contador++;
            }
            if (indice > -1)
            {
                Policia agente = agentes[contador] as Policia;
                return agente;
            }
            else { return null; }


        }
        public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int h, int m, int tipoIncidente)
        {

            Incidente incidente = null;
            
            if (tipoIncidente==0 )
            {
                incidente = new Denuncia(agente,sujeto);
            }
            else if (tipoIncidente==1)
            {
                incidente = new Arresto(sujeto,agente);
            }

            if (incidente!=null)
            {
                Incidentes.Add(incidente);

                incidente.Motivo = motivo;
                incidente.Minuto = m;
                incidente.Hora=h;
            }


        }
        public void AsignarGuardia(int numero, int h1, int m1, int tiempoMinutos, Policia Agente )
        {

            if (numero<2)
            {
                Guardia nuevGuardia = Guardias[numero];

                nuevGuardia.HoraDesde = h1;
                nuevGuardia.MinutoDesde = m1;
                nuevGuardia.CantidadMinutos = tiempoMinutos;
                nuevGuardia.OficialAsignado = Agente;

            }
        }
        public Incidente VerIncidente (int idx)
        {


            if (idx>=0 && idx<Incidentes.Count)
            {
                return Incidentes[idx] as Incidente;
            }
            return null ;
        }

    }
}
