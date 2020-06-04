using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class guardado
    {
        [Key]
        public int id_guardado { get; set; }
        [ForeignKey("id_guardado")]
        public int id_anuncio { get; set; }
        [ForeignKey("id_utilizador")]
        public int id_utilizador { get; set; }
    }
}
