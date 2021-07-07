using CRUD_Vacinas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Controllers
{
    public class EstadosController : Controller
    {
        private VacinasContext _vacinaContext;

        public EstadosController()
        {
            _vacinaContext = new VacinasContext();
        }

        // GET: /Estados
        // GET: /Estados/Index
        public ActionResult Index()
        {
            var resultado = _vacinaContext.Estados.ToList<Estado>();

            return View(resultado);
        }

        // GET: /Estados/Details/5
        public ActionResult Details(int id)
        {
            var estado = _vacinaContext.Estados.Find(id);

            return View(estado);
        }

        // GET: /Estados/Create
        public ActionResult Create()
        {
            Estado novoEstado = new Estado();
            novoEstado.Nome = "Rio de Janeiro";
            novoEstado.Sigla = "RJ";
            novoEstado.Populacao = 10000000;

            _vacinaContext.Add<Estado>(novoEstado);

            _vacinaContext.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST: /Estados/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: /Estados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Estados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: /Estados/Delete/5
        public ActionResult Delete(int id)
        {
            var estado = _vacinaContext.Estados.Find(id);

            _vacinaContext.Remove<Estado>(estado);

            _vacinaContext.SaveChanges();

            return View();
        }

        // POST: /Estados/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
