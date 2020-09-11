using SistemaLoja.Data;
using SistemaLoja.Models;
using SistemaLoja.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaLoja.Controllers
{
    public class OrdensController : Controller
    {
        private SistemaLojaContext db = new SistemaLojaContext();

        // GET: Ordens
        public ActionResult NovaOrdem()
        {
            var ordemView = new OrdemView();
            ordemView.Customizar = new Customizar();
            ordemView.ProdutoOrdem = new List<ProdutoOrdem>();

            //Algoritimo criado para colocar uma frase de selecao no combobox e ordenar por nome...
            var List = db.Customizars.ToList();
            //List.Add(new TipoDocumento { TipoDocumentoId = 0, Descricao = "[Selecione o documento]" });
            List = List.OrderBy(c => c.NomeCompleto).ToList();
            //...
            ViewBag.CustomizarID = new SelectList(List, "CustomizarId", "NomeCompleto");

            return View(ordemView);

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}