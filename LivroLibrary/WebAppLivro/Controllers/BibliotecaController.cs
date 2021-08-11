using LivroLibrary.Models;
using LivroLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppLivro.Controllers
{
    public class BibliotecaController : BaseController<LivroBibliotecaModel ,LivroBibliotecaRepository>
    {
        public BibliotecaController()
        {

        }

    }
}