using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMirror.Feature.Weather
{
    public class Conditions
    {
        public Temperature Temperature { get; set; }
        public string Description { get; set; }
        public string DescriptionIconLocation { get; set; }
        public DateTime DateTime { get; set; }
        public string RelativeHumidity { get; set; }
        public Wind Wind { get; set; }
        public Uv Uv { get; set; }
        public Visibility Visibility { get; set; }
    }
}
