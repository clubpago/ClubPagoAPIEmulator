using System;

namespace TesterClubPagoApi.Controllers
{
    public class ResponsePagoApi
    {
        public int codigo { get; set; }
        public string mensaje { get; set; }
        public string autorizacion { get; set; }
        public string transaccion { get; set; }
        public DateTime fecha { get; set; }
        public string mensaje_ticket { get; set; }
        public string mensaje_sms { get; set; }
        public string notificacion_sms { get; set; }

    }



}