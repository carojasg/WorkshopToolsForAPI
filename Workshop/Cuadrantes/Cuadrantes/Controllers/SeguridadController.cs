﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cuadrantes.Controllers
{
    [Route("api/[controller]")]
    public class SeguridadController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        [HttpPost]
        public string IniciarSesion(string usuario, string clave)
        {
            return string.Empty;
        }
        [HttpPost]
        public string Registro(string cedula, DateTime fechaExpedicion,
            string telefono, string correo)
        {
            return string.Empty;
        }
    }
}