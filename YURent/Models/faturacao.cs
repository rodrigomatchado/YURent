using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class faturacao
    {
        [Key]
        public int id_faturacao { get; set; }
        [ForeignKey("id_utilizador")]
        public int id_utilizador { get; set; }
        public string nome_completo { get; set; }
        public string morada { get; set; }
        public string codigo_postal { get; set; }
        public int nif { get; set; }
        public string iban { get; set; }
    }
}
