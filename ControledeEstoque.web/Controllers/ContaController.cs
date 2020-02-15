using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControledeEstoque.web.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Models.LoginViewModel Login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(Login);
            }

            var achou = (Login.Usuario == "leandro" && Login.Senha == "123");
            if (achou)
            {
                FormsAuthentication.SetAuthCookie(Login.Usuario, Login.LembrarMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login Inválido.");
            }
            return View(Login);
        }
    }
}