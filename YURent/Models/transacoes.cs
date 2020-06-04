using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class transacoes
    {
        [Key]
        public int id_transacoes { get; set; }
        [ForeignKey("id_reserva")]
        public int id_reserva { get; set; }
        public DateTime data { get; set; }
    }
}
