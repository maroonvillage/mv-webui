using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maroonvillage.webui.Models
{
    public class HomeModel : DefaultModel
    {
        public IList<CityModel> Carousel { get; set; }

    }

}
