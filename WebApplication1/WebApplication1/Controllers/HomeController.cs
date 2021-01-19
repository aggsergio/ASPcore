using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Array arreglo;
            List<ClienteModel> clientes = new List<ClienteModel>();
            var a = new ClienteModel();

            clientes.Add(new ClienteModel
            {
                Clave_Cliente = 123,
                Nombre_Cliente = "Sergio",
                Direccion_Cliente = "Av Francisco I Madero",
                Pedido_Cliente = "Cerveza Indio"
            });

            clientes.Add(new ClienteModel
            {
                Clave_Cliente = 432,
                Nombre_Cliente = "Fernando",
                Direccion_Cliente = "Av Corregidora",
                Pedido_Cliente = "Cerveza XX"
            });
            clientes.Add(new ClienteModel
            {
                Clave_Cliente = 567,
                Nombre_Cliente = "Gerardo",
                Direccion_Cliente = "Av 30 de Febrero",
                Pedido_Cliente = "Cerveza Modelo"
            });

            arreglo = clientes.ToArray();
            ViewBag.ClienteModel = arreglo;
            return View();
        }
    }
}
