﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControledeEstoque.web.Controllers
{
    public class GraficosController : Controller
    {
        [Authorize]
        public ActionResult PerdasMes()
        {
            return View();
        }
        [Authorize]
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}