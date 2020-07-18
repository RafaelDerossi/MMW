using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;

namespace MMW.MVC.Controllers
{
    public class EntradasController : Controller
    {
        private readonly IEntradaServicoAplicacao _entradaServicoAplicacao;
        private readonly ILojaServicoAplicacao _lojaServicoAplicacao;
        private readonly IFornecedorServicoAplicacao _fornecedorServicoAplicacao;

        public EntradasController(IEntradaServicoAplicacao entradaServicoAplicacao, ILojaServicoAplicacao lojaServicoAplicacao, IFornecedorServicoAplicacao fornecedorServicoAplicacao)
        {
            _entradaServicoAplicacao = entradaServicoAplicacao;
            _lojaServicoAplicacao = lojaServicoAplicacao;
            _fornecedorServicoAplicacao = fornecedorServicoAplicacao;
        }

        // GET: LojasController
        public ActionResult Index()
        {
            return View(_entradaServicoAplicacao.Listar());
        }

        // GET: LojasController/Details/5
        public ActionResult Details(int id)
        {
            return View(_entradaServicoAplicacao.DetalharId(id));
        }

        // GET: LojasController/Create
        public ActionResult Create()
        {
            ViewBag.lojaId = new SelectList(_lojaServicoAplicacao.Listar(), "Id", "Fantasia");
            ViewBag.fornecedorId = new SelectList(_fornecedorServicoAplicacao.Listar(), "Id", "Fantasia");
            return View();
        }

        // POST: LojasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntradaViewModel entradaViewModel)
        {
            try
            {
                entradaViewModel = _entradaServicoAplicacao.Adicionar(entradaViewModel);
                return RedirectToAction("Details", new { id = entradaViewModel.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: LojasController/Edit/5
        public ActionResult Edit(int id)
        {
            var entradaVM = _entradaServicoAplicacao.DetalharId(id);
            ViewBag.lojaId = new SelectList(_lojaServicoAplicacao.Listar(), "Id", "Fantasia", entradaVM.LojaId);
            ViewBag.fornecedorId = new SelectList(_fornecedorServicoAplicacao.Listar(), "Id", "Fantasia", entradaVM.FornecedorId);
            return View(entradaVM);
        }

        // POST: LojasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EntradaViewModel entradaViewModel)
        {
            try
            {
                _entradaServicoAplicacao.Atualizar(entradaViewModel);
                return RedirectToAction("Details", new { id=entradaViewModel.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: LojasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_entradaServicoAplicacao.DetalharId(id));
        }

        // POST: LojasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EntradaViewModel entradaViewModel)
        {
            try
            {
                _entradaServicoAplicacao.Excluir(entradaViewModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
