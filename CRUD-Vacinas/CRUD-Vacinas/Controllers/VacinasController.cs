using CRUD_Vacinas.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Controllers
{
    public class VacinasController : Controller
    {
        public IActionResult Index()
        {
            List<VacinaViewModel> vacinas = new List<VacinaViewModel>();

            var vacina = new VacinaViewModel();
            vacina.ID = 1;
            vacina.NOME = "CoronaVac";
            vacina.FABRICANTE = "Butantan";
            vacina.NUMDOSES = 2;
            vacina.INTERVALODOSE = 14;

            vacinas.Add(vacina);

            var vacina2 = new VacinaViewModel();
            vacina2.ID = 2;
            vacina2.NOME = "AstraZeneca";
            vacina2.FABRICANTE = "Oxford";
            vacina2.NUMDOSES = 2;
            vacina2.INTERVALODOSE = 90;

            vacinas.Add(vacina2);

            return View(vacinas);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(VacinaViewModel model)
        {
            return Redirect("/Vacinas/Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var vacina2 = new VacinaViewModel();
            vacina2.ID = 2;
            vacina2.NOME = "AstraZeneca";
            vacina2.FABRICANTE = "Oxford";
            vacina2.NUMDOSES = 2;
            vacina2.INTERVALODOSE = 90;

            return View(vacina2);
        }


        [HttpPost]
        public IActionResult Editar(VacinaViewModel model)
        {
            return Redirect("/Vacinas/Index");
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            return Redirect("/Vacinas/Index");
        }
    }
}
