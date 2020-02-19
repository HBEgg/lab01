using lab01.Models; 
using System;
using System.Collections.Generic;
//using System.Linq;
using System.IO; 
using System.Web;
using System.Web.Mvc;

namespace lab01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new List<JugadorModel>());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase datafile)
        {
            List<JugadorModel> jugadores = new List<JugadorModel>();
            string Rutaarchivo = string.Empty;
            if (Rutaarchivo != null)
            {
                string direccion = Server.MapPath("~/Datos/");
                if (!Directory.Exists(direccion))
                {
                    Directory.CreateDirectory(direccion);
                }
                Rutaarchivo = direccion + Path.GetFileName(datafile.FileName);
                string extensionarchivo = Path.GetExtension(datafile.FileName);
                datafile.SaveAs(Rutaarchivo);
                string lectura_archivo = System.IO.File.ReadAllText(Rutaarchivo);
                foreach (string fila in lectura_archivo.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(fila))
                    {
                        jugadores.Add(new JugadorModel
                        {
                            Nombre = fila.Split(',')[0],
                            Apellido = fila.Split(',')[1],
                            Posicion = fila.Split(',')[2],
                            Club = fila.Split(',')[3],
                            Salario = Convert.ToInt32(fila.Split(',')[4])
                        });
                    }
                }
            }
            return View(jugadores);
        }
    }
}