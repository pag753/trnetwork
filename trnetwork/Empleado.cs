using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trnetwork
{
    public class Empleado : Persona
    {
        public float SalarioMensual { get; set; }
        public string Departamento { get; set; }
        public Vestimenta Vestimenta { get; set; }
    }
}
