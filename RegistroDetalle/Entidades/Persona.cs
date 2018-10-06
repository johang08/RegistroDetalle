using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResgistroDetalle.Entidades
{
    public class Persona
    {
        public int PersonaID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacmineto { get; set; }

        public virtual List<DetallesTel> Telefonos { get; set; }

        public Persona()
        {
            PersonaID = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacmineto = DateTime.Now;

            Telefonos = new List<DetallesTel>();
        }
    }
}