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
    public class ContratoController : Controller
    {
        private readonly ContratoContext _context;

        public ContratoController(ContratoContext context)
        {
            _context = context;
        }

        // GET: Contrato
        public async Task<IActionResult> Index()
        {
          
            return View(await _context.Contrato.ToListAsync());
        }


        // GET: Contrato/Create
        public IActionResult AddOrEditC(int id=0)
        {
            if (id == 0)
            {
                return View(new Contrato());
            }
            else
            {
                return View(_context.Contrato.Find(id));
            }
        }

        // POST: Contrato/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditC([Bind("idcontrato,nombre_entidad,num_contrato,trab_vinculado,fecha_inicio,fecha_final")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                if (contrato.idcontrato == 0)
                {
                    _context.Add(contrato);
                }
                else
                {
                    _context.Update(contrato);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contrato);
        }

       

        // GET: Contrato/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            var contrato = await _context.Contrato.FindAsync(id);
            _context.Contrato.Remove(contrato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
