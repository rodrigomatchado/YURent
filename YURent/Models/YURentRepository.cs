using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YURent.Data;

namespace YURent.Models
{
    public class YURentRepository
    {
        private List<anuncio> DataSource()
        {
            return new List<anuncio>()
            {
                new anuncio(){ id_anuncio=1, id_utilizador=1, nome="Roberto Flores", descricao="Esta camera é fantastica até te passas o mano", categoria="Cameras", preco_dia=10, visualizacoes=10, extensao_imagem=".png", ativo=false, data_publicacao=DateTime.Now },
            };
        }
    }
}
