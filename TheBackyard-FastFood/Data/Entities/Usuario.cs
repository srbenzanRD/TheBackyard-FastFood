using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBackyard_FastFood.Data.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
    }
}