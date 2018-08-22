using CatalogoProdutos.Data.DataContexts;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

//TODO: Refatorar o código : Retirar a referência do EF
namespace CatalogoProdutos.Web
{

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /*Criar o context no inicio da requisição(Begin Request)*/
        protected void Application_BeginRequest(object send, EventArgs e)
        {
            HttpContext.Current.Items["_EntityContext"] = new CatalogoDataContext();
        }


        protected void Application_EndRequest(object send, EventArgs e)
        {
            CatalogoDataContext context = HttpContext.Current.Items["_EntityContext"] as CatalogoDataContext;
            if (context != null)
                context.Dispose();
        }


    }
}
