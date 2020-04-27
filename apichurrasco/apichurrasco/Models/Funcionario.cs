using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace apichurrasco.Models
{
    public class Funcionario
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }
        public string FUNCIONARIO { get; set; }
        public string CONSOME_BEBIDA { get; set; }
        public string CANCELADO { get; set; }

    }
}
