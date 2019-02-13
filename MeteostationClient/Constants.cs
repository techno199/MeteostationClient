using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteostationClient
{
    static class Constants
    {
        // Length of log file evaluetad in number of lines 
        public const int LOG_LENGTH = 1000;

        public const int SAVING_WARNING = 1;
         
        public const string ApiLogin = "account/login";
        public const string ApiSendStats = "statistics/sendstats";
        public const string ApiRegister = "account/register";

        // Represents form-data key names for POST requests
        public const string FormDataKeyTemperature = "temp";
        public const string FormDataKeyHumidity = "humidity";
        public const string FormDataKeyLogin = "login";
        public const string FormDataKeyPassword = "password";
        public const string FormDataKeyMeasurementTime = "time";

        public const string ServiceDomain = "https://localhost:5001/api/";
    }
}
