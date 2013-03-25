using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebUI.Controllers {
  public class StaticContentController : Controller {
    //
    // GET: /StaticContent/

    public ActionResult Page(string viewName) {
      return View(viewName);
    }

  }
}