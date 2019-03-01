using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trnetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Método que se ejecuta cuando se hace clic.
         */
        private void generar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear al nuevo gerente.
                Gerente g = new Gerente();
                g.Nombre = tnombre.Text;
                g.Apaterno = tapaterno.Text;
                g.Amaterno = tamaterno.Text;
                g.Direccion = tdireccion.Text;
                g.Estatura = Convert.ToDouble(testatura.Text);
                g.SalarioMensual = 50000;
                g.Telefono = ttelefono.Text;
                Saco s = new Saco();
                s.botones = 3;
                s.color = "Negro";
                g.Vestimenta = s;
                g.Departamento = "Sistemas";
                g.Entrevista = new List<string> {
                "¿Qué edad tienes?",
                "¿Estado civil?",
                "¿Hijos?",
                "¿Por qué te interesa el trabajo?",
                "¿Último nivel de estudios?",
                "¿Contratación inmediata?"
            };

                // Crear a la persona entrevistada.
                Persona p = new Persona();
                p.Amaterno = tamaterno2.Text;
                p.Apaterno = tapaterno2.Text;
                p.Direccion = tdireccion2.Text;
                p.Estatura = Convert.ToDouble(testatura2.Text);
                p.Nombre = tnombre2.Text;
                p.Telefono = ttelefono.Text;

                //Generar la respuesta.
                string r = "El gerente de la empresaes un empleado que mide" + g.Estatura +
                    ", se llama " + g.NombreCompleto() + " y tiene puesto un saco con " + ((Saco)(g.Vestimenta)).botones +
                    " botones. En este momento el gerente está entrevistando a una persona para su contratación." +
                    " La persona a la que entrevista se llama " + p.NombreCompleto() + ", tiene una estatura de " + p.Estatura +
                    "m. Su teléfono es " + p.Telefono + " y su dirección es " + p.Direccion + ". la entrevista que le está aplicando es la siguiente:\r" +
                    String.Join(" ", g.Entrevista.ToArray());
                trespuesta.Text = r;
            }
            catch (Exception)
            {
                trespuesta.Text = "Ocurrió un error en el momento de ejecución, favor de revisar los datos.";
                throw;
            }
        }
    }
}
