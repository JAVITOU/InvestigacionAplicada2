using Microsoft.AspNetCore.Mvc;
using DirectorioLibros.Models;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioLibros.Controllers
{
    public class LibrosController : Controller
    {
        // Lista en memoria para almacenar libros
        private static List<Libro> libros = new List<Libro>();
        private static int siguienteId = 1;

        // Página de Inicio
        public IActionResult Index()
        {
            return View();
        }

        // Listado de Libros
        public IActionResult Listado()
        {
            return View(libros);
        }

        // Agregar libro - GET
        public IActionResult Crear()
        {
            return View();
        }

        // Agregar libro - POST
        [HttpPost]
        public IActionResult Crear(Libro libro)
        {
            libro.Id = siguienteId++;
            libros.Add(libro);
            return RedirectToAction("Listado");
        }

        // Detalles de un libro
        public IActionResult Detalles(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro == null) return NotFound();
            return View(libro);
        }

        // Eliminar un libro
        public IActionResult Eliminar(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                libros.Remove(libro);
            }
            return RedirectToAction("Listado");
        }
    }
}