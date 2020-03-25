using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
    public class ConsultaReferenciaController : ControllerBase
    {

        // GET: api/ConsultaReferencia
        [HttpGet]
        public ActionResult<string> Get(string r)
        {
            //Emulador
            if (r.EndsWith("3"))
            {
                return JsonConvert.SerializeObject(new { codigo = 3, monto = 0, transaccion = 0, mensaje = "Referencia Desconocida", referencia = r });
            }

            //Emulador
            if (r.EndsWith("4"))
            {
                return JsonConvert.SerializeObject(new { codigo = 4, monto = 0, transaccion = 0, mensaje = "Monto Incorrecto", referencia = r });
            }

            //Procesar Transacción
            //...
            //...
            //Respuesta Exitosa
            return JsonConvert.SerializeObject(new { codigo = 0, monto = new Random().Next(100000, 999999), transaccion = 65432583, mensaje = "Transaccion Exitosa", referencia = r });
        }
    }
}
