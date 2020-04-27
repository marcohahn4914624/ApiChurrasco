using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apichurrasco.Models
{
    public class Gasto
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }
        public decimal GASTO_COMIDA { get; set; }
        public decimal GASTO_BEBIDA { get; set; }
    }
}
