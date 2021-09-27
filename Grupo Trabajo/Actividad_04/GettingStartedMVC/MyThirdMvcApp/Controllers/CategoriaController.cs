using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyThirdMvcApp.Models;

namespace MyThirdMvcApp.Controllers
{
    public class CategoriaController : Controller
    {
        //
        // GET: /Categoria/

        ProductoModel entidad = new ProductoModel();

        public ActionResult Index()
        {
            var listaCategorias = entidad.Categorias;
            return View(listaCategorias.ToList());
        }

        public ActionResult ListadoCategorias()
        {
            var listaCategorias = entidad.Categorias;
            return View(listaCategorias.ToList());
        }

        public ActionResult ProductosCategoria(string categoria)
        {
            var listaUsuariosCategoria = from p in entidad.Productoes where p.Categorias.Nombre == categoria select p;
            return View(listaUsuariosCategoria.ToList());
        }

        public ActionResult ListadoProductosCategoria(string categoria)
        {
            var listaUsuariosCategoria = from p in entidad.Productoes where p.Categorias.Nombre == categoria select p;
            return View(listaUsuariosCategoria.ToList());
        }

        public ActionResult ListadoProductosConCategorias()
        {
            var listaUsuariosConCategorias = from p in entidad.Productoes
                                             join c in entidad.Categorias
                                             on p.CategoriaId equals c.Id
                                             select new Producto
                                             {
                                                 id = p.Id,
                                                 nombre = p.Nombre,
                                                 categoria = c.Nombre
                                             };
            return View(listaUsuariosConCategorias.ToList());
        }

    }
}
