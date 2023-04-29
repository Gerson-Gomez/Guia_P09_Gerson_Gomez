using Guia_P09_Gerson_Gomez.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Guia_P09_Gerson_Gomez.Controllers
{
    public class EquiposController : Controller
    {
        //SE AGREGA EL ENLAACE DEL CONTROLADOR PARA USARLO EN LAS VISTAS.
        private readonly EquipoContext _equiposContext;
        public EquiposController(EquipoContext  equiposContext)
        {
            _equiposContext = equiposContext;    
        }

        public IActionResult Index()
        {
            var listaMarcas = (from marcas in _equiposContext.Marcas select marcas).ToList();
            ViewData["ListadoDeMarcas"] = new SelectList(listaMarcas,"id_marcas","nombre_marca");

            var listadoEquipos = (from e in _equiposContext.Equipos
                                  join m in _equiposContext.Marcas on e.marca_id equals m.id_marcas
                                  select new 
                                  {
                                      nombre = e.nombre,
                                      descripcion = e.descripcion,
                                      marca_id = e.marca_id,
                                      marca_nombre = m.nombre_marca
                                  }).ToList();
            ViewData["listadoEquipo"] = listadoEquipos;
            return View();
        }
        public IActionResult CrearEquipos(Equipo nuevoEquipo)
        {
            _equiposContext.Add(nuevoEquipo);
            _equiposContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
