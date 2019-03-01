using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trnetwork
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public double Estatura { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public string NombreCompleto()
        {
            return this.Nombre + " " + this.Apaterno + " " + this.Amaterno;
        }
    }
}
