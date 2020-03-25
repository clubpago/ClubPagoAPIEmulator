using System;

namespace TesterClubPagoApi.Controllers
{
    public class RequestPagoApi
    {
        public string transaccion { get; set; }
        public DateTime fecha { get; set; }
        public int monto { get; set; }
        public string referencia { get; set; }
    }



}