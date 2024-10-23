using JessicaOlalla_LPE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JessicaOlalla_LPE.Controllers
{
    public class EstadioVistaController : Controller
    {
        // GET: EstadioVistaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EstadioVistaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstadioVistaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadioVistaController/Create
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

        // GET: EstadioVistaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstadioVistaController/Edit/5
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

        // GET: EstadioVistaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadioVistaController/Delete/5
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
