using System.ComponentModel.DataAnnotations;

namespace ResgistroDetalle.Entidades
{
    public class DetallesTel
    {
        [Key]
        public int Id { get; set; }
        public int PersonaID { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }

        public DetallesTel()
        {
            Id = 0;
            PersonaID = 0;
            TipoTelefono = string.Empty;
            Telefono = string.Empty;
        }
    }
}