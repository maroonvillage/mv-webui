using maroonvillage.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maroonvillage.webui.Interfaces
{
    public interface IDomainService
    {
        IList<CityModel> GetCities(int count);
    }
}
