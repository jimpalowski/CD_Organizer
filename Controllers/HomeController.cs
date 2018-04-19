using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace CDOrg
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
    
      }
    }
}
