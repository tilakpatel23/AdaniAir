using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore.Mvc;
using AdaniAir.Project.AdaniAir.Models;
using Sitecore.Mvc.Presentation;

namespace AdaniAir.Project.AdaniAir.Controllers
{
    public class Demo2Controller : Controller
    {
        
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

                return View("/Views/Demo/Demo.cshtml", model);
            }
            return View();
        }

        public ActionResult Intro()
        {
            var datasourceId2 = RenderingContext.Current.Rendering.DataSource;
            var item2 = Sitecore.Context.Database.GetItem(datasourceId2);

            if (item2 != null)
            {
                var model = new IntroModel
                {
                    Head = item2.Fields["Head"].Value,
                    Discri = item2.Fields["Discri"].Value.ToString(),
                    Discri2 = item2.Fields["Discri2"].Value.ToString(),
                };

                return View("/Views/Intro/Intro.cshtml", model);
            }
            return View();
        }
    }
}