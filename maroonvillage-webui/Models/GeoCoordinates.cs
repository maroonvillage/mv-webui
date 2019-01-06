using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace maroonvillage.webui.Models
{
    [Serializable]
    public class GeoCoordinates
    {
        public GeoCoordinates()
        {
            Lattitude = 0.0D;
            Longitude = 0.0D;
        }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
    }
}
