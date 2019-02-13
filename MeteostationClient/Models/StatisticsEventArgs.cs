using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteostationClient
{
    public class StatisticsEventArgs : EventArgs
    {
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public DateTime MeasurementTime { get; set; }
    }
}
