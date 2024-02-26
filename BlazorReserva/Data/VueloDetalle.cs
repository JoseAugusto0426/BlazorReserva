using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorReserva.Data
{
    public class VueloDetalle
    {

        [Key]
        public int IdVuelo { get; set; }

        [ForeignKey(nameof(IdVuelo))]
        public virtual Vuelo? Vuelo { get; set; }



        public string Destino { get; set; } = "";
        public int Pasajero { get; set; }
        public decimal Precio { get; set; }

        [NotMapped]
        public decimal SubTotal => Pasajero * Precio;
    }
}
