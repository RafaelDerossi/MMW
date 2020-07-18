using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;

namespace MMW.MVC.Controllers
{
    public class FornecedoresController : Controller
    {

        private readonly IFornecedorServicoAplicacao _fornecedorServicoAplicacao;

        public FornecedoresController(IFornecedorServicoAplicacao fornecedorServicoAplicacao)
        {
            _fornecedorServicoAplicacao = fornecedorServicoAplicacao;
        }

        // GET: LojasController
        public ActionResult Index()
        {
            return View(_fornecedorServicoAplicacao.Listar());
        }

        // GET: LojasController/Details/5
        public ActionResult Details(int id)
        {
            return View(_fornecedorServicoAplicacao.DetalharId(id));
        }

        // GET: LojasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LojasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                _fornecedorServicoAplicacao.Adicionar(fornecedorViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LojasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_fornecedorServicoAplicacao.DetalharId(id));
        }

        // POST: LojasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                _fornecedorServicoAplicacao.Atualizar(fornecedorViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LojasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_fornecedorServicoAplicacao.DetalharId(id));
        }

        // POST: LojasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                _fornecedorServicoAplicacao.Excluir(fornecedorViewModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
