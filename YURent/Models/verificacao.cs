using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class verificacao
    {
        [Key]
        public int id_verificacao { get; set; }
        [ForeignKey("id_utilizador")]
        public int id_utilizador { get; set; }
        public string telemovel { get; set; }
        public int nif { get; set; }
        public string num_cc { get; set; }
    }
}
