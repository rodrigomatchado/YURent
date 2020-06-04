using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class utilizador
    {
        [Key]
        public int id_utilizador { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string avatar_extensao { get; set; }
    }
}
