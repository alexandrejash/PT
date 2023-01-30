using Prueba.Usuarios.Web.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Usuarios.Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public async  Task< ActionResult> Index()


        {
            using(var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri("http:/localhost");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("/UsuarioService.svc/rest/ListarUsuarios"); //Direccion wervicio

                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<UsuarioViewModel>));
                    List<UsuarioViewModel> response = obj.ReadObject(result) as List<UsuarioViewModel>;
                    return View(response);
                }
                return View();


            }

           
        }
    }
}