using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_AP1_P2.Shared.Models
{
    public class EntradasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int EntradaId { get; set; }
        public int ProductoId { get; set; }
        public float CantidadUtilizada { get; set; }
    }
}
