using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Repository;

namespace WeatherForecast.Models
{
    public class WeatherDomain
    {
        public IEnumerable<Weather> Weather { get; set; }            

    }
      
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public IEnumerable<Main> main { get; set; }
        public IEnumerable<Coord> coord { get; set; }
        public IEnumerable<Wind> wind { get; set; }
        public IEnumerable<Sys> sys { get; set; }
        public IEnumerable<Clouds> clouds { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timezone")]
        public int TimeZone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Cod { get; set; }        
        
    }   
    public class Main
    {        
        public double temp { get; set; }
        public double feels_like { get; set; }
        public int temp_min { get; set; }     
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }        
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class RootObject
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }        
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}


