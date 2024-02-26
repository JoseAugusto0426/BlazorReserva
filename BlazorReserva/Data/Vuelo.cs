using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorReserva.Data
{
    public class Vuelo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = "";

        public string Airport { get; set; } = "";
        public DateTime Fecha { get; set; }
        public ICollection<VueloDetalle> Detalles { get; set; }
        = new HashSet<VueloDetalle>();
        [NotMapped]
        public decimal Total => (Detalles != null && Detalles.Any()) ? Detalles.Sum(d => d.SubTotal) : 0;
    }
}
