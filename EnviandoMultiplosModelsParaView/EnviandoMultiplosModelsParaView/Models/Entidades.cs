using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnviandoMultiplosModelsParaView.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }

    public class Marca
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }

    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}