using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnviandoMultiplosModelsParaView.Models
{
    public class HomeIndexModel
    {
        public Produto Produto { get; set; }

        public IEnumerable<Categoria> Categorias { get; set; }

        public IEnumerable<Marca> Marcas { get; set; }
    }
}