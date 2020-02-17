using lab01.Models;
using lab01.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab01.Controllers
{
    public class JugadorController : Controller
    {
        // GET: Jugador
        public ActionResult Index()
        {
            return View(Storage.Instancia.jugadorLista);
        }

        // GET: Jugador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jugador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jugador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var jugador = new JugadorModel
                {
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Posicion = int.Parse(collection["Posicion"]),
                    Salario = int.Parse(collection["Salario"]),
                    Club = collection["Salario"],


                };

                if (jugador.Save())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(jugador);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Jugador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jugador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jugador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jugador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
