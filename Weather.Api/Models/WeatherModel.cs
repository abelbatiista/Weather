using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Api.Models.WeatherModelTypes;
using Weather.Api.Models;

namespace Weather.Api.Models
{
    public class WeatherModel
    {
        public List<WeatherModelTypes.Weather> Weather { get; set; }
        public Main Main { get; set; }
    }
}
