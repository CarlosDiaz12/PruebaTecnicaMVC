using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.BusinessLogic.Service;
using PruebaTecnica.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.UI.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly EstudianteService _service;
        public EstudianteController(EstudianteService service)
        {
            _service = service;
        }
        // GET: EstudianteController
        public ActionResult Index()
        {
            return View(_service.GetEstudianteList());
        }

        // GET: EstudianteController/Details/5
        public ActionResult Details(int id)
        {
           
            return View(_service.GetSingleEstudiante(id));
        }

        // GET: EstudianteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudianteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estudiante estudiante)
        {
            try
            {
                _service.SaveEstudiante(estudiante);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudianteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Estudiante estudiante)
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

        // GET: EstudianteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudianteController/Delete/5
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
