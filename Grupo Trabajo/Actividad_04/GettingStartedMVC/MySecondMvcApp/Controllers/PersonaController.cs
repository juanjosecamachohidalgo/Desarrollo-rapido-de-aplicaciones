using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySecondMvcApp.Models;

namespace MySecondMvcApp.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/

        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();

            Persona per1 = new Persona();
            per1.codigo = 1;
            per1.nombre = "Antonio";
            per1.primerApellido = "Corral";
            per1.segundoApellido = "Liria";
            lista.Add(per1);

            Persona per2 = new Persona();
            per2.codigo = 2;
            per2.nombre = "Manuel";
            per2.primerApellido = "Torres";
            per2.segundoApellido = "Gil";
            lista.Add(per2);

            Persona per3 = new Persona();
            per3.codigo = 3;
            per3.nombre = "Antonio";
            per3.primerApellido = "Becerra";
            per3.segundoApellido = "Teron";
            lista.Add(per3);

            Persona per4 = new Persona();
            per4.codigo = 4;
            per4.nombre = "Rafael";
            per4.primerApellido = "Guirado";
            per4.segundoApellido = "Clavijo";
            lista.Add(per4);

            return View(lista);
        }

    }
}
