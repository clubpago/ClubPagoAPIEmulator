using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TesterClubPagoApi.Filters;

namespace TesterClubPagoApi.Controllers
{
    [Route("Service/[controller]")]
    [ApiController]
    [SecurityFilter]
    public class CancelaPagoController : ControllerBase
    {
        [HttpDelete]
        public ActionResult<string> Delete([FromBody] RequestCancelaApi request)
        {
            //Procesar Pago
            //...
            //...
            //Respuesta Exitosa
            return JsonConvert.SerializeObject(new ResponseCancelaApi { codigo = 0, mensaje = "Cancelación Exitosa" });
        }
    }

}