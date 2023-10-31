using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_AP1_P2.Shared.Models
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="Campo Obligatorio")]
        public string? Concepto { get; set; }

        public float PesoTotal { get; set; }
        public int ProductoId { get; set; }

        public float CantidadProducida { get; set; }

        [ForeignKey("EntradaId")]
        public ICollection<EntradasDetalle> EntradasDetalle { get; set; } = new List<EntradasDetalle>();

    }
}
