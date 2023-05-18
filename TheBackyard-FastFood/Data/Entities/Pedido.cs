using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBackyard_FastFood.Data.Entities
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente {get; set;}

        public string DireccionDeEntrega { get; set; }

        public int TipoEntregaId { get; set; }

        [ForeignKey("TipoEntregaId")]
        public TipoEntrega TipoEntrega { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public ICollection<PedidoDetalle> PedidoDetalles { get; set; }
    }
    public class PedidoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ServicioId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; }
        
        [ForeignKey("ServicioId")]
        public Servicio Servicio { get; set; }
    }

    public class TipoEntrega
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
    }
}
