using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MeteostationClient
{
    public class LoggerService
    {
        public string LogsPath { get; set; } = $@"{Directory.GetCurrentDirectory()}\{HttpService.Username}.log.txt";
        public List<string> Logs { get; set; }
        public LoggerService()
        {
            if (!File.Exists(LogsPath))
            {
                File.Create(LogsPath).Close();
            }
            Logs = File.ReadLines(LogsPath).ToList<string>();
        }

        public void OnMeasuredStats(object sender, StatisticsEventArgs args)
        {
            // Add them to log buffer
            if (Logs.Count >= Constants.LOG_LENGTH)
            {
                Logs.RemoveAt(0);
            }
            Logs.Add($"{args.Temperature} {args.Humidity} {args.MeasurementTime.ToString(new CultureInfo("ru-RU"))}");
        }

        public void OnSavingStats(object sender, EventArgs args)
        {
            File.WriteAllLines(LogsPath, Logs.ToArray());
        }
    }
}
