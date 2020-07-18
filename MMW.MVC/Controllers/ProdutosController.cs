using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;

namespace MMW.MVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoServicoAplicacao _produtoServicoAplicacao;

        public ProdutosController(IProdutoServicoAplicacao produtoServicoAplicacao)
        {
            _produtoServicoAplicacao = produtoServicoAplicacao;
        }

        // GET: ProdutosController
        public ActionResult Index()
        {
            return View(_produtoServicoAplicacao.Listar());
        }

        // GET: ProdutosController/Details/5
        public ActionResult Details(int id)
        {
            return View(_produtoServicoAplicacao.DetalharId(id));
        }

        // GET: ProdutosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
            try
            {
                _produtoServicoAplicacao.Adicionar(produtoViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_produtoServicoAplicacao.DetalharId(id));
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            try
            {
                _produtoServicoAplicacao.Atualizar(produtoViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_produtoServicoAplicacao.DetalharId(id));
        }

        // POST: ProdutosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProdutoViewModel produtoViewModel)
        {
            try
            {
                _produtoServicoAplicacao.Excluir(produtoViewModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(produtoViewModel);
            }
        }
    }
}
