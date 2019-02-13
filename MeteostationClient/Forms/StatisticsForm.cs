using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteostationClient
{
    
    public partial class StatisticsForm : Form
    {
        public int MeasurementInterval { get; set; } = 1000;
        public string CurrentTemperature { get; set; } = "";
        public string CurrentHumidity { get; set; } = "";
        public LoggerService _loggerService { get; set; } = new LoggerService();
        public HttpService _httpService { get; set; } = new HttpService();
        public event EventHandler<StatisticsEventArgs> MeasuredStats;
        public event EventHandler SavingStats;
        private bool isClosePending { get; set; } = false;
        public StatisticsForm()
        {
            InitializeComponent();

            MeasuredStats += _httpService.OnMeasuredStats;
            MeasuredStats += _loggerService.OnMeasuredStats;
            SavingStats += _loggerService.OnSavingStats;

            measureIndicatorsBackgroundWorker.RunWorkerAsync();

            labelHint.Text = "";
        }

        private void measureIndicatorsBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var measuredTemperature = randomWithinRange(0, 30);
            var measuredHumidity = randomWithinRange(0, 100);
 
            while (true)
            {
                // Generate numbers
                measuredTemperature += randomWithinRange(-0.5, 0.5);
                measuredHumidity += randomWithinRange(-0.5, 0.5);

                MeasuredStats(this, new StatisticsEventArgs()
                {
                    Humidity = measuredHumidity.ToString(),
                    Temperature = measuredTemperature.ToString(),
                    MeasurementTime = DateTime.Now
                });

                // Save results to log file when cancellation required
                if (measureIndicatorsBackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    measureIndicatorsBackgroundWorker.ReportProgress(Constants.SAVING_WARNING);
                    SavingStats(this, new EventArgs());
                    isClosePending = true;
                    return;
                }

                measureIndicatorsBackgroundWorker.ReportProgress(0,
                    new MeasurementResult
                    {
                        measuredTemperature = measuredTemperature.ToString(),
                        measuredHumidity = measuredHumidity.ToString()
                    });
                Thread.Sleep(MeasurementInterval);
            }

        }

        private void measureIndicatorsBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case Constants.SAVING_WARNING:
                    labelHint.Text = "Saving..";
                    break;
                default:
                    CurrentTemperature = ((MeasurementResult)e.UserState).measuredTemperature.ToString();
                    CurrentHumidity = ((MeasurementResult)e.UserState).measuredHumidity.ToString();

                    labelTemperatureNumber.Text = CurrentTemperature;
                    labelHumidityNumber.Text = CurrentHumidity;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            labelHint.Text = "Closing..";
            if (measureIndicatorsBackgroundWorker.IsBusy)
            {
                measureIndicatorsBackgroundWorker.CancelAsync();
                e.Cancel = true;
                Thread.Sleep(MeasurementInterval);
                return;
            }
            e.Cancel = false;
        }

        private double randomWithinRange(double min, double max)
        {
            var random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

        private void measureIndicatorsBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isClosePending) this.Close();
            isClosePending = false;
        }

        private void StatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var a = 1;
        }
    }
    public class MeasurementResult
    {
        public string measuredTemperature;
        public string measuredHumidity;

    }
}


