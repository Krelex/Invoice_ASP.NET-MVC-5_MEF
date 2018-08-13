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
    public class MEFControllerFactory : DefaultControllerFactory
    {
        static CompositionContainer _container;

        static MEFControllerFactory()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog("C:\\Users\\andre\\Desktop\\Project\\ASP.NET_MVC_Filip_Cogelja\\Aplikacija\\EnterwellFakture.MVC\\Enterwell_Fakture\\Extensions"));   
            

            _container = new CompositionContainer(catalog);
            
        }


        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            var controller = base.CreateController(requestContext, controllerName);

            _container.ComposeParts(controller);

            return controller;
        }
    }
}