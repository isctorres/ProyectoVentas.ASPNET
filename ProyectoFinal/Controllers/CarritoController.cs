using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class CarritoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarritoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Carrito
        public IActionResult Index()
        {
            //var applicationDbContext = _context.Carrito.Include(c => c.Producto);
            //return View(await applicationDbContext.ToListAsync());

            IPHostEntry heserver = Dns.GetHostEntry(Dns.GetHostName());
            var ip = heserver.AddressList[1].ToString();

            var carrito = (from n in _context.Carrito.Include("Producto")
                           where n.Sesion == ip
                          select n);

            return View(carrito.ToList());
        }

        [Authorize]
        public async Task<IActionResult> Comprar()
        {
            IPHostEntry heserver = Dns.GetHostEntry(Dns.GetHostName());
            var ip = heserver.AddressList[1].ToString();

            var carrito = (from n in _context.Carrito.Include("Producto")
                           where n.Sesion == ip
                           select n).ToList();

            var cliente = (from n in _context.Clientes
                           where n.EmailCliente == User.Identity.Name
                           select n).ToList();

            var pedido = new Pedidos
            {
                ClienteID = cliente[0].ClienteID,
                EstatusID = 1,
            };
            _context.Add(pedido);
            await _context.SaveChangesAsync();

            foreach (var item in carrito)
            {
                var detPedido = new DetallePedido
                {
                    PedidoID = pedido.PedidoID,
                    ProductoID = item.ProductoID,
                    PrecioVenta = item.Precio,
                    CantidadVendida = item.Cantidad,
                    DescuentoVenta = item.Descuento,
                };

                _context.Add(detPedido);
                await _context.SaveChangesAsync();

                Productos objProducto = _context.Productos.Find(item.ProductoID);
                objProducto.Existencia = objProducto.Existencia - item.Cantidad;
                _context.Carrito.Update(item);
                await _context.SaveChangesAsync();

                // Eliminamos el item que se registró 
                _context.Carrito.Remove(item);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("PedidosCliente", "Pedidos");
        }

        // POST: Carrito/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar( int idProducto, int cantidad, decimal precio, decimal descu)
        {
            IPHostEntry heserver = Dns.GetHostEntry(Dns.GetHostName());
            var ip = heserver.AddressList[1].ToString();

            var carrito = new Carrito
            {
                ProductoID = idProducto,
                Sesion = ip,
                Cantidad = cantidad,
                Precio = precio,
                Descuento = Decimal.ToInt32(descu),
            };

            _context.Add(carrito);
            await _context.SaveChangesAsync();
            
            /*ViewData["cantidadCarrito"] = (from n in _context.Carrito
                                           where n.Sesion == ip
                                           select n.ProductoID
                                           ).Count();*/

            return RedirectToAction("Index","Home");
        }
        
        
        // POST: Carrito/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var carrito = await _context.Carrito.FindAsync(id);
            _context.Carrito.Remove(carrito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarritoExists(int id)
        {
            return _context.Carrito.Any(e => e.CarritoID == id);
        }
    }
}
