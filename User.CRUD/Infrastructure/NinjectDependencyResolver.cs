using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Configuration;
using System.Web;

using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using Ninject.Modules;

using User.CRUD.Repositories;
using Model = User.CRUD.Models;

namespace User.CRUD.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver()
        {
            var settings = new NinjectSettings { LoadExtensions = false };
            kernel = new StandardKernel(settings);
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IRepository<Model.User>>().To<Repository<Model.User>>();
        }
    }
}