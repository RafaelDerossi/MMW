using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;

namespace MMW.MVC.Controllers
{
    public class LojasController : Controller
    {
        private readonly ILojaServicoAplicacao _lojaServicoAplicacao;

        public LojasController(ILojaServicoAplicacao lojaServicoAplicacao)
        {
            _lojaServicoAplicacao = lojaServicoAplicacao;
        }

        // GET: LojasController
        public ActionResult Index()
        {
            return View(_lojaServicoAplicacao.Listar());
        }

        // GET: LojasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LojasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LojasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LojaViewModel lojaViewModel)
        {
            try
            {
                _lojaServicoAplicacao.Adicionar(lojaViewModel);
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
            return View(_lojaServicoAplicacao.DetalharId(id));
        }

        // POST: LojasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LojaViewModel lojaViewModel)
        {
            try
            {
                _lojaServicoAplicacao.Atualizar(lojaViewModel);
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
            return View(_lojaServicoAplicacao.DetalharId(id));
        }

        // POST: LojasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(LojaViewModel lojaViewModel)
        {
            try
            {
                _lojaServicoAplicacao.Excluir(lojaViewModel.Id);                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
