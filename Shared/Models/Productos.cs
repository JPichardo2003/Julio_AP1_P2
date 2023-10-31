﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_AP1_P2.Shared.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string? Descripción { get; set; }
        public int Tipo { get; set; }
        public float Existencia { get; set; }

    }
}
