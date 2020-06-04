using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class anuncio
    {
        [Key]
        public int id_anuncio { get; set; }
        [ForeignKey("id_utilizador")]
        public int id_utilizador { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public float preco_dia { get; set; }
        public int visualizacoes { get; set; }
        public string extensao_imagem { get; set; }
        public bool ativo { get; set; }
        public float data_publicacao { get; set; }
    }
}
