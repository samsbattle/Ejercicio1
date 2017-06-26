using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionUsuarios.Models;

namespace GestionUsuarios.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (var db = new EFUsuarioContext()) {

                usuarios = (from u in db.Usuario select u).ToList();
            }


            return View(usuarios);
        }

        public ActionResult Alta()
        {
            ViewBag.Message = "Ingrese todos los datos";

            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(Usuario usuario)
        {
            using (var db = new EFUsuarioContext())
            {
                int aux = (from a in db.Usuario
                          orderby a.Id descending
                          select a.Id).First();


                db.Usuario.Add(new Usuario() {
                    Id = aux+1,
                    Nombre = usuario.Nombre,
                    ApellidoPaterno = usuario.ApellidoPaterno,
                    ApellidoMaterno = usuario.ApellidoMaterno,
                    Direccion = usuario.Direccion,
                    Telefono = usuario.Telefono
                });
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
