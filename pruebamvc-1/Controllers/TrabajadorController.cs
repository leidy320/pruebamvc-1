using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pruebamvc_1.Models;

namespace pruebamvc_1.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly TrabajadorContext _context;

        public TrabajadorController(TrabajadorContext context)
        {
            _context = context;
        }

        // GET: Trabajadors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trabajador.ToListAsync());

        }

  
        // GET: Trabajadors/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
            {
                return View(new Trabajador());
            }
            else
            {
                return View(_context.Trabajador.Find(id));
            }
        }

        // POST: Trabajador/Editar
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("idtrabajador,tipoidentificacion,identificacion,pr_nombre,seg_nombre,pr_apellido,seg_apellido,fecha_nacimiento,edad")] Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                if (trabajador.idtrabajador == 0)
                {
                    _context.Add(trabajador);
                }
                else
                {
                    _context.Update(trabajador);
                }
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trabajador);
        }

       
        // GET: Trabajadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var trabajador = await _context.Trabajador.FindAsync(id);
            _context.Trabajador.Remove(trabajador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      
    }
}
