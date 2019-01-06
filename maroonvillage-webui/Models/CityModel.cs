using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace maroonvillage.webui.Models
{
    [Serializable]
    public class CityModel
    {
        private string _censusApiKey;
        public CityModel()
        {
            CityCoords = new GeoCoordinates();
        }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string PhotoUrl { get; set; }
        [DataMember]
        public string OpenDataRequestUrl { get; set; }
        [DataMember]
        public FlickrNet.PhotoInfo CityPhotoInfo { get; set; }
        [DataMember]
        public IList<FlickrNet.GalleryPhoto> PhotoGallery { get; set; }
        [DataMember]
        public GeoCoordinates CityCoords { get; set; }
        [DataMember]
        public WeatherMapModel WeatherMap { get; set; }
        [DataMember]
        public decimal TotalPopulation { get; set; }
        [DataMember]
        public string CensusKey { get { return _censusApiKey; } set { _censusApiKey = value; } }
    }
}
