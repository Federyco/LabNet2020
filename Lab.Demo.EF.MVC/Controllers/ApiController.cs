using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Lab.Demo.EF.MVC.Models;
using Newtonsoft.Json;

namespace Lab.Demo.EF.MVC.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult Index()
        {
            return View();
        }
        public async System.Threading.Tasks.Task<ActionResult> ApiViewAsync()
        {
           string html = "https://digimon-api.vercel.app/api/digimon";
           HttpClient cliente = new HttpClient();
           var webConstains = await cliente.GetStringAsync(html);
           var list = JsonConvert.DeserializeObject<List<AnimeView>>(webConstains);

            return View(list);
        }
    }
}