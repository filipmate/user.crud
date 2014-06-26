using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using User.CRUD.Repositories;

namespace User.CRUD.Controllers
{
    public abstract class CrudController<TEntity> : Controller where TEntity : class, new()
    {
        private readonly IRepository<TEntity> _repository;

        public CrudController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual ActionResult Index()
        {
            return View(_repository.All());
        }

        public virtual ActionResult Edit(int id)
        {
            return View(_repository.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(TEntity entity)
        {
            if(ModelState.IsValid)
            {
                _repository.Update(entity);
                return RedirectToAction("Index");
            }
            return View(entity);
        }

        public virtual ActionResult Create()
        {
            return View("Edit", new TEntity());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(TEntity entity)
        {
            if (ModelState.IsValid)
            {
                _repository.Create(entity);
                return RedirectToAction("Index");
            }
            return View("Edit", entity);
        }

        public virtual ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (_repository is IDisposable)
            {
                ((IDisposable)_repository).Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
