﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    [Authorize]
    public class PedidosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public PedidosController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Pedidos
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            ViewBag.isAdmin = await _userManager.IsInRoleAsync(user, "Administrador");

            var applicationDbContext = _context.Pedidos.Include(p => p.Clientes).Include(p => p.EstatusPedido);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> PedidosCliente()
        {
            var cliente = (from n in _context.Clientes
                           where n.EmailCliente == User.Identity.Name
                           select n).ToList();

            //var applicationDbContext = _context.Pedidos.Include(p => p.Clientes).Include(p => p.EstatusPedido);
            var pedidos = (from n in _context.Pedidos.Include("EstatusPedido")
                           where n.ClienteID == cliente[0].ClienteID
                           select n).ToListAsync();
            return View(await pedidos);
        }

        // GET: Pedidos/Details/5
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos
                .Include(p => p.Clientes)
                .Include(p => p.EstatusPedido)
                .FirstOrDefaultAsync(m => m.PedidoID == id);
            if (pedidos == null)
            {
                return NotFound();
            }

            return View(pedidos);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ClienteID", "ApellidoMaterno");
            ViewData["EstatusID"] = new SelectList(_context.EstatusPedido, "EstatusID", "DescEstatus");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("PedidoID,FechaPedido,FechaEmbarque,ReferenciaBanco,ClienteID,EstatusID")] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ClienteID", "ApellidoMaterno", pedidos.ClienteID);
            ViewData["EstatusID"] = new SelectList(_context.EstatusPedido, "EstatusID", "DescEstatus", pedidos.EstatusID);
            return View(pedidos);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos.FindAsync(id);
            if (pedidos == null)
            {
                return NotFound();
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ClienteID", "ApellidoMaterno", pedidos.ClienteID);
            ViewData["EstatusID"] = new SelectList(_context.EstatusPedido, "EstatusID", "DescEstatus", pedidos.EstatusID);
            return View(pedidos);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PedidoID,FechaPedido,FechaEmbarque,ReferenciaBanco,ClienteID,EstatusID")] Pedidos pedidos)
        {
            if (id != pedidos.PedidoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidosExists(pedidos.PedidoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ClienteID", "ApellidoMaterno", pedidos.ClienteID);
            ViewData["EstatusID"] = new SelectList(_context.EstatusPedido, "EstatusID", "DescEstatus", pedidos.EstatusID);
            return View(pedidos);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos
                .Include(p => p.Clientes)
                .Include(p => p.EstatusPedido)
                .FirstOrDefaultAsync(m => m.PedidoID == id);
            if (pedidos == null)
            {
                return NotFound();
            }

            return View(pedidos);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedidos = await _context.Pedidos.FindAsync(id);
            _context.Pedidos.Remove(pedidos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidosExists(int id)
        {
            return _context.Pedidos.Any(e => e.PedidoID == id);
        }
    }
}
