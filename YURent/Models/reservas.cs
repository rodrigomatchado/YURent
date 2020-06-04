using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class reservas
    {
        [Key]
        public int id_reserva { get; set; }
        [ForeignKey("id_anuncio")]
        public int id_anuncio { get; set; }
        [ForeignKey("id_utilizador")]
        public int id_utilizador { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
        public float preco { get; set; }
        public bool cancelado { get; set; }
    }
}
