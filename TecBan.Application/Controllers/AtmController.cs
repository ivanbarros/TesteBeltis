using TecBan.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TecBan.Domain.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TecBan.Application.Controllers
{
    public class AtmController : Controller
    {
        private readonly IAtmService _atmService;
        public AtmController(IAtmService atmService)
        {
            _atmService = atmService;
        }

        // GET: AtmController
        public  ActionResult<IEnumerable<ATM>> Index()
        {
            var listaAtms =   _atmService.GetAtm();

            return View(listaAtms);
        }

        // GET: AtmController/Details/5
        public ActionResult Details(int id)
        {
            _atmService.DeleteAtm(id);
            return View();
        }

        // GET: AtmController/Create
        

        // POST: AtmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ATM atm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _atmService.InsertAtm(atm);
                    return RedirectToAction("Sucesso");

                }
                return View();
            }
            catch
            {
                return  RedirectToAction("Falha ao cadastrar");
            }
        }

        // GET: AtmController/Edit/5
        public ActionResult Edit()
        {
            
            return View();
        }

        // POST: AtmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ATM collection)
        {
            try
            {
                _atmService.UpdateAtm(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AtmController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View();
        }

        // POST: AtmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            { 

                _atmService.DeleteAtm(id);
            return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
