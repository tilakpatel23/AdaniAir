using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc.Presentation;
using AdaniAir.Feature.Hero.Models;

namespace AdaniAir.Feature.Hero.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            var datasourceId = RenderingContext.Current.Rendering.DataSource;
            var item = Sitecore.Context.Database.GetItem(datasourceId);
                
            if (item != null)
            {
                var model = new DemoModel
                {
                    Heading = item.Fields["Heading"].Value,
                    Heading2 = item.Fields["Heading2"].Value.ToString(),
                    Disc = item.Fields["Disc"].Value.ToString(),
                    Image = item.Fields["Image"].Value
                };

                return View("/Views/Demo/Demo.cshtml",model);
            }
            return View("/Views/Demo/Demo.cshtml");
        }
    }
}