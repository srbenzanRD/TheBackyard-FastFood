﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBackyard_FastFood.Data.Entities
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public ICollection<PedidoDetalle> PedidoDetalles { get; set; }
    }
}
