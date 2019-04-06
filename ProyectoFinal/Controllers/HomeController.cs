using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        //private IHttpContextAccessor _accessor;
        // Agregamos el contexto al controlador para poder hacer consultas
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _manager;

        public HomeController(ApplicationDbContext context, IHttpContextAccessor accessor, SignInManager<ApplicationUser> manager)
        {
            _context = context;
            _manager = manager;
            //_accessor = accessor;
        }

        public IActionResult Index()
        {
            /*IPHostEntry heserver = Dns.GetHostEntry(Dns.GetHostName());
            var ip = heserver.AddressList[1].ToString();*/

            ViewData["Categorias"] = (from c in _context.Categorias select c);

            var promos = (from n in _context.Promociones.Include("Productos")
                            //where n.FechaInicio >= DateTime.Now && DateTime.Now <= n.FechaFin
                            select n);

            return View(promos.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewData["Categorias"] = (from c in _context.Categorias select c);
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
