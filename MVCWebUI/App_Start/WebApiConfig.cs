using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;

namespace MVCWebUI {
  public static class WebApiConfig {
    public static void Register(HttpConfiguration config) {
      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
    public static string ApiUrl = ConfigurationManager.AppSettings["apiUrl"];
   
  }
}
