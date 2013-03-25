using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Web.Http;

namespace MVCWebUI.Controllers {
  public class ResourceController : Controller {

    public void Index(string resource) {
      Call(string.Format("{0}/{1}?resource", WebApiConfig.ApiUrl, resource));
    }

    public void Get(string resource) {
      Call(string.Format("{0}/{1}", WebApiConfig.ApiUrl, resource));
    }

    public void Call(string _apiUrl) {
      // Send a request asynchronously continue when complete 
      //string name = Page.RouteData.Values["Name"] as string;
      var client = new HttpClient();
      var result = String.Empty;
      try {
        HttpResponseMessage response = client.GetAsync(_apiUrl).Result;
        result = response.Content.ReadAsStringAsync().Result;
      } catch (Exception ex) {
        result = ex.Message;
      }

      //return Json(result, JsonRequestBehavior.AllowGet);
      Response.Clear();
      Response.ContentType = "application/json; charset=utf-8";
      Response.Write(result);
      Response.End();
    }
  }
}
