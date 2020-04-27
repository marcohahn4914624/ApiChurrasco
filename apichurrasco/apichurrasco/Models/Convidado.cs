using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apichurrasco.Models
{
    public class Convidado
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }
        public decimal ID_FUNCIONARIO { get; set; }
        public string NOME_CONVIDADO { get; set; }
        public string CONSOME_BEBIDAS { get; set; }
        public string CANCELADO { get; set; }
    }
}
