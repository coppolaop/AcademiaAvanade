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
        public ActionResult Create(Estado estado)
        {
            try
            {
                Estado novoEstado = new Estado();
                novoEstado.Nome = estado.Nome;
                novoEstado.Sigla = estado.Sigla;
                novoEstado.Populacao = estado.Populacao;
                _vacinaContext.Add<Estado>(novoEstado);
                _vacinaContext.SaveChanges();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(estado);
            }
        }

        // GET: /Estados/Edit/5
        public ActionResult Edit(int id)
        {
            var _estado = _vacinaContext.Estados.Find(id);

            if (_estado == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(_estado);

        }

        // POST: /Estados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Estado estado)
        {
            try
            {
                var _estado = _vacinaContext.Estados.Find(id);

                if(_estado != null)
                {
                    _estado.Populacao = estado.Populacao;
                    _estado.Fundacao = estado.Fundacao;

                    _vacinaContext.Estados.Update(_estado);
                    _vacinaContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Estado não cadastrado");
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(estado);
            }
        }

        // GET: /Estados/Delete/5
        public ActionResult Delete(int id)
        {
            var estado = _vacinaContext.Estados.Find(id);

            return View(estado);
        }

        // POST: /Estados/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Estado estado)
        {
            try
            {
                var _estado = _vacinaContext.Estados.Find(id);

                if (_estado != null)
                {
                    _vacinaContext.Remove<Estado>(_estado);
                    _vacinaContext.SaveChanges();

                }
                else
                {
                    throw new Exception("Estado não cadastrado");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(estado);
            }
        }

    }
}
