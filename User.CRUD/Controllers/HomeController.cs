using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using User.CRUD.Repositories;
using Model = User.CRUD.Models;

namespace User.CRUD.Controllers
{
    public class HomeController : CrudController<Model.User>
    {
        public HomeController(IRepository<Model.User> repository) : base(repository)
        {

        }

    }
}
