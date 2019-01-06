using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maroonvillage.webui.Models
{
    [Serializable]
    public class WeatherMapModel
    {
        public WeatherMapModel()
        {

        }
        public int Id { get; set; }
        public string Base { get; set; }
        public string Visibility { get; set; }
        public int Dt { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public Coord Coord { get; set; }

        public Weather[] WeatherItems { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Sys Sys { get; set; }

    }
    [Serializable]
    public class Coord
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
    [Serializable]
    [JsonArray]
    public class Weather
    {
        public string Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
    [Serializable]
    public class Main
    {
        public decimal Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public decimal Temp_Min { get; set; }
        public decimal Temp_Max { get; set; }

    }
    [Serializable]
    public class Wind
    {
        public decimal Speed { get; set; }
        public decimal Deg { get; set; }

    }
    [Serializable]
    public class Clouds
    {
        public int All { get; set; }

    }

    [Serializable]
    public class Sys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public decimal Message { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }
}
