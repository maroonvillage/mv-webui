using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maroonvillage.webui.Models
{
    public class DefaultModel
    {
        public string PageTitle { get; set; }
        public System.Security.Claims.ClaimsPrincipal User { get; set; }
    }
}
