using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.ComponentModel.Composition;

namespace Enterwell_Fakture.Controllers
{
    [HandleError]
    public class MEFControllerFactory : DefaultControllerFactory
    {
        static CompositionContainer _container;

        static MEFControllerFactory()
        {
            var catalog = new AggregateCatalog();
            var path = AppDomain.CurrentDomain.BaseDirectory;
            catalog.Catalogs.Add(new DirectoryCatalog(path+"Extensions"));   
            

            _container = new CompositionContainer(catalog);
            
        }

        [HandleError]
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            
            var controller = base.CreateController(requestContext, controllerName);

            _container.ComposeParts(controller);

            return controller;
        }
    }
}