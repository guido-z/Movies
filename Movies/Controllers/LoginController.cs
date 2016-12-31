using DAL;
using DB;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class LoginController : Controller
    {
        private BaseDAO<LoginUsuario> _loginDAO;
        private BaseDAO<TipoDocumento> _idDAO;

        public LoginController()
        {
            _loginDAO = new BaseDAO<LoginUsuario>();
            _idDAO = new BaseDAO<TipoDocumento>();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            IEnumerable<SelectListItem> idTypeDropDownItems = _idDAO.ListAll().Select(i => new SelectListItem()
            {
                Text = i.Descripcion,
                Value = i.Id.ToString()
            });

            RegisterViewModel model = new RegisterViewModel();

            model.TiposDocumento = idTypeDropDownItems;

            return View(model);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}