using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;


namespace MMW.MVC.Controllers
{
    public class EstoquesController : Controller
    {
        private readonly IEstoqueServicoAplicacao _estoqueServicoAplicacao;

        public EstoquesController(IEstoqueServicoAplicacao estoqueServicoAplicacao)
        {
            _estoqueServicoAplicacao = estoqueServicoAplicacao;
        }
        // GET: EstoquesController
     
        public ActionResult Index(int produtoId)
        {
            return View(_estoqueServicoAplicacao.Listar(produtoId));
        }
        
        // GET: EstoquesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_estoqueServicoAplicacao.DetalharId(id));
        }

        // POST: EstoquesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstoqueViewModel estoqueViewModel)
        {
            try
            {
                _estoqueServicoAplicacao.Atualizar(estoqueViewModel);
                return RedirectToAction("Index", "Estoques", new { produtoId = estoqueViewModel.ProdutoId });
            }
            catch
            {
                return View();
            }
        }

       
    }
}
