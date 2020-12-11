using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMirror.Feature.Weather
{
    public class DaysForecast
    {
        public DateTime Day { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public Temperature High { get; set; }
        public Temperature Low { get; set; }
        public string Description { get; set; }
        public string DescriptionIconLocation { get; set; }
    }
}
