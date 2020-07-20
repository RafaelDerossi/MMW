using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;

namespace MMW.MVC.Controllers
{
    public class ItensEntradaController : Controller
    {
        private readonly IItemEntradaServicoAplicacao _itemEntradaServicoAplicacao;
        private readonly IEntradaServicoAplicacao _entradaServicoAplicacao;
        private readonly IProdutoServicoAplicacao _produtoServicoAplicacao;

        public ItensEntradaController(IItemEntradaServicoAplicacao itemEntradaServicoAplicacao, IEntradaServicoAplicacao entradaServicoAplicacao, IProdutoServicoAplicacao produtoServicoAplicacao)
        {
            _itemEntradaServicoAplicacao = itemEntradaServicoAplicacao;
            _entradaServicoAplicacao = entradaServicoAplicacao;
            _produtoServicoAplicacao = produtoServicoAplicacao;
        }
        
        // GET: LojasController/Details/5
        public ActionResult Details(int id)
        {
            return View(_itemEntradaServicoAplicacao.DetalharId(id));
        }

        // GET: LojasController/Create
        public ActionResult Create(int entradaId)
        {
            var itemEntrada = new ItemEntradaViewModel();
            itemEntrada.EntradaId = entradaId;
            itemEntrada.Entrada = _entradaServicoAplicacao.DetalharId(entradaId);
            
            ViewBag.produtoId = new SelectList(_produtoServicoAplicacao.Listar(), "Id", "Descricao");

            return View(itemEntrada);
        }

        // POST: LojasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemEntradaViewModel itemEntradaViewModel)
        {
            try
            {
                _itemEntradaServicoAplicacao.Adicionar(itemEntradaViewModel);
                return RedirectToAction("Details","Entradas", new { id = itemEntradaViewModel.EntradaId });
            }
            catch
            {
                return View();
            }
        }

        // GET: LojasController/Edit/5
        public ActionResult Edit(int id)
        {
            var itemEntrada = _itemEntradaServicoAplicacao.DetalharId(id);            
            ViewBag.produtoId = new SelectList(_produtoServicoAplicacao.Listar(), "Id", "Descricao", itemEntrada.ProdutoId);
            return View(_itemEntradaServicoAplicacao.DetalharId(id));
        }

        // POST: LojasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemEntradaViewModel itemEntradaViewModel, int entradaId)
        {
            try
            {
                _itemEntradaServicoAplicacao.Atualizar(itemEntradaViewModel);
                return RedirectToAction("Details", "Entradas", new { id = entradaId });              
            }
            catch
            {
                return View();
            }
        }

        // GET: LojasController/Delete/5
        public ActionResult Delete(int id)
        {
            var itemEntrada = _itemEntradaServicoAplicacao.DetalharId(id);
            return View(itemEntrada);
        }

        // POST: LojasController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ItemEntradaViewModel itemEntradaViewModel, int entradaId)
        {
            try
            {                
                _itemEntradaServicoAplicacao.Excluir(itemEntradaViewModel.Id);
                return RedirectToAction("Details", "Entradas", new { id = entradaId });
            }
            catch
            {
                return View(itemEntradaViewModel);
            }
        }
    }
}
