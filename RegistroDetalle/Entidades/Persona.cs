using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResgistroDetalle.Entidades
{
    public class Persona
    {
        [Key]
        public int PersonaID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacmineto { get; set; }

        public virtual List<DetallesTel> Telefonos { get; set; }
        public object DetallesTel { get; internal set; }

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

private void Limpiar()
{
    MyErrorProvider.Clear();

    IDNumericUpDown.Value = 0;
    NombreTextBox.Text = string.Empty;
    CedulamaskedTextBox.Text = string.Empty;
    DireccionTextBox.Text = string.Empty;
    FechaNacimientoDateTimePicker.Value = DateTime.Now;

    this.Detalle = new List<DetallesTel>();
    CargarGrid();
}