using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas/Aleatorias
        public ActionResult Aleatorias()
        {
            Pelicula pelicula = new Pelicula() {id = 1, nombre = "Shrek", Genero = "Comedia", AnioLanzamiento = "2001", Clasificacion = "Familiar" };

            //pelicula.nombre = "Shrek"; Otra forma en que se puede añadir

            return View(pelicula);
        }
    }
}