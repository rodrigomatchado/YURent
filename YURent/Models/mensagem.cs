using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class mensagem
    {
        [Key]
        public int id_mensagem { get; set; }
        [ForeignKey("id_utilizador")]
        public int id_utilizador { get; set; }
        [ForeignKey("id_anuncio")]
        public int id_anuncio { get; set; }
        public bool fromseller { get; set; }
        public string conteudo { get; set; }
        public bool vista { get; set; }
        public DateTime data { get; set; }
    }
}
