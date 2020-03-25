using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterClubPagoApi.Utilities
{
    public class Misc
    {
        public static string GetAuthToken() => Convert.ToBase64String(Encoding.ASCII.GetBytes(Constants.CPP_TOKEN));
    }
}
