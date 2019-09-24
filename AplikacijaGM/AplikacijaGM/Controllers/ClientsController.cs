using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplikacijaGM.Models;

namespace AplikacijaGM.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientsContext _context;

        public ClientsController(ClientsContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clients.ToListAsync());
        }

    

        // GET: Clients/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Clients());
            else
                return View(_context.Clients.Find(id));
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("KlijentID,Vlasnik,Ljubimac,Vrsta,Adresa")] Clients clients)
        {
            if (ModelState.IsValid)
            {
                if (clients.KlijentID == 0)
                    _context.Add(clients);
                else
                    _context.Update(clients);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clients);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var clients = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(clients);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

     
    }
}
