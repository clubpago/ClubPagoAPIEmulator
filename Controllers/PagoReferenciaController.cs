using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Text;
using TesterClubPagoApi.Filters;

namespace TesterClubPagoApi.Controllers
{
    [Route("Service/[controller]")]
    [ApiController]
    [SecurityFilter]
    public class PagoReferenciaController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Post([FromBody] RequestPagoApi request)
        {

            //Procesar Pago
            //...
            //...
            //
            //Respuesta Exitosa
            return JsonConvert.SerializeObject(new ResponsePagoApi { autorizacion = new Random().Next(100000,999999).ToString(), codigo = 0, fecha = DateTime.Now, mensaje = "Transacción Exitosa", transaccion = request.transaccion });
        }
    }
}