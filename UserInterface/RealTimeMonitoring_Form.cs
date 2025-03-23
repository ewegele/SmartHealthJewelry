using BackendCS.Measurement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface
{
    public partial class RealTimeMonitoring_Form : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        HeartRate heart;
        private bool _normalRun;

        public RealTimeMonitoring_Form(bool normalRun)
        {
            _normalRun = normalRun;

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            DynamicScreenSize.AdjustFont(lblBodyTemp);
            DynamicScreenSize.AdjustFont(lblBPM);
            DynamicScreenSize.AdjustFont(lblBrightness);
            DynamicScreenSize.AdjustFont(lblEnvTemp);
            DynamicScreenSize.AdjustFont(lblHumidity);
        }

        public static int counter = 0;


        public void vPrintMeasurements()
        {
            //nicht in invoke ausführen, da der GUI Thread das berechnen sonst übernimmt
            heart = (HeartRate)GlobalMeasurement.measurement._sensorsSingle[0];
            float brightnessValue = GlobalMeasurement.measurement._sensorsSingle[4].fGetSingleData();
            float BrightnessPercentage = (float)Math.Round(BackendCS.Converter.BrightnessConverter.convert(brightnessValue) * 100, 1);
            float environmentTemperature = GlobalMeasurement.measurement._sensorsSingle[1].fGetSingleData();
            float environmentHumidity = GlobalMeasurement.measurement._sensorsSingle[2].fGetSingleData();
            float bodyTemperature = GlobalMeasurement.measurement._sensorsSingle[3].fGetSingleData();

            BeginInvoke((Action)(() => //switch back to main thread
            {
                fillSeries();
                redrawCharts();
            }));

            if (counter == 0)
            {
                BeginInvoke((Action)(() => //switch back to main thread
                {
                 
                        lblBPM.Text = "" + heart.fGetSingleData();
                        lblEnvTemp.Text = environmentTemperature.ToString("F1") + " °";
                        lblHumidity.Text = environmentHumidity.ToString("F1") + " %";
                        lblBodyTemp.Text = bodyTemperature.ToString("F1") + " °";
                        lblBrightness.Text = BrightnessPercentage + " %";
                   
                }));
            }
            counter = (counter + 1) % 50;
        }

        private void fillSeries()
        {
            Series heartBeat = chartHeartbeat.Series["Series1"];
            if (heartBeat.Points.Count > 500)
            {
                heartBeat.Points.RemoveAt(0); // Keep the number of points reasonable
            }

            heartBeat.Points.AddY(heart.iGetHeartRate());
        }

        private void redrawCharts()
        {
            chartHeartbeat.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_normalRun)
            {
                this.Hide();
            }
            else { this.Close(); }
        }


        public void SetBrooch_Good()
        {
            pctboxBrooch.Image = global::UserInterface.Properties.Resources.Good;
        }

        public void SetBrooch_Ok()
        {
            pctboxBrooch.Image = global::UserInterface.Properties.Resources.Ok1;
        }

        public void SetBrooch_Danger()
        {
            pctboxBrooch.Image = global::UserInterface.Properties.Resources.Danger;
        }
    }
}

