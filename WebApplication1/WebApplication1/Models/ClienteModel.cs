using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Models
{
	public class ClienteModel
	{
		public int Clave_Cliente { get; set; }
		public string Nombre_Cliente { get; set; }
		public string Direccion_Cliente { get; set; }
		public string Pedido_Cliente { get; set; }

	}
}
