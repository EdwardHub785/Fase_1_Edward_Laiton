using System;
using System.Collections.Generic;
using System.Text;

namespace Fase_1_Edward_Laiton
{
    public class Nomina

    {
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public string genero { get; set; }
        public double dLaborados { get; set; }
        public double salarioDia { get; set; }
        DateTime fecha = DateTime.Now;
        
        
        public double CalcularSueldo(double salarioDia,double dLaborados)
        {
            return salarioDia * dLaborados;
        }

       
    }
}
