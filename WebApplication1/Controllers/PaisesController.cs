using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PaisesController : Controller
    {

        public ActionResult EntradaDatos()
        {
            return View();
        }

        public async Task<ActionResult> SalidaDatos (FormCollection form)
        {
            List<Paises> paisInfo = new List<Paises>();

            string Baseurl = "https://restcountries.eu/rest/v2/";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = null;
                switch (form["optradio"])
                {
                    case "Region":
                       Res = await client.GetAsync("region/"+ form["buscar"]);
                        break;
                    case "Nombre":
                       Res = await client.GetAsync("name/" + form["buscar"]);
                        break;
                    case "Lenguaje":
                       Res = await client.GetAsync("lang/" + form["buscar"]);
                        break;
                    default:
                        break;
                }

                if (Res.IsSuccessStatusCode)
                {
                    var respuesta = Res.Content.ReadAsStringAsync().Result;
                    try
                    {             
                        paisInfo = (List<Paises>)JsonConvert.DeserializeObject(respuesta, typeof(List<Paises>));
                    }
                    catch (Exception e)
                    {
                        return View();
                    }
                }
                return View(paisInfo);
            }
        }


        public ActionResult Beneficios()
        {
            return View();
        }


        public ActionResult Diferencias()
        {
            return View();
        }

        public ActionResult Informacion()
        {
            return View();
        }

}
}
