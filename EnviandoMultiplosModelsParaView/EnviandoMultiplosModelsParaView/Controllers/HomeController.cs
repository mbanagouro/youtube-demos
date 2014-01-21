using EnviandoMultiplosModelsParaView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnviandoMultiplosModelsParaView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var model = new HomeIndexModel();

            model.Produto = ObterProduto();
            model.Categorias = ObterCategorias();
            model.Marcas = ObterMarcas();

            return View(model);
        }

        #region Operações

        Produto ObterProduto()
        {
            return new Produto
            {
                Id = 1,
                Nome = "Bola de futebol"
            };
        }

        IEnumerable<Marca> ObterMarcas()
        {
            for (int i = 1; i < 11; i++)
            {
                yield return new Marca
                {
                    Id = i,
                    Nome = "Marca " + i
                };
            }
        }

        IEnumerable<Categoria> ObterCategorias()
        {
            for (int i = 1; i < 11; i++)
            {
                yield return new Categoria
                {
                    Id = i,
                    Nome = "Categoria " + i
                };
            }
        }

        #endregion
    }
}