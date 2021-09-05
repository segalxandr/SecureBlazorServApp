using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Services
{
    public class TokenProvider
    {
        public string XsrfToken { get; set; }
    }

    public class InitialApplicationState
    {
        public string XsrfToken { get; set; }

    }
}
