using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendCS.Measurement;
using BackendCS.Event;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;


namespace UserInterface
{
   public partial class MotionData_Form : Form
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

        Motion motion;

      private bool _normalRun;

      public MotionData_Form(bool normalRun)
      {
         _normalRun = normalRun;

         InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

        }


      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         GlobalMeasurement.measurement.vStopMeasurement();
      }



      //func gets only called, when measurement is finished receiving data
      public void vPrintMeasurements()
      {
            BeginInvoke((Action)(() => //switch back to main thread
                  {
 
                     //fillSeries
                     fillSeries();
                     //redraw charts
                     redrawCharts();
                  }));
      }

      private void radioButtonX_CheckedChanged(object sender, EventArgs e)
      {

         if (radioButtonX.Checked)
         {
            chartHeight.Series["SeriesXAcc"].Enabled = true;
            chartDistance.Series["SeriesXGyro"].Enabled = true;
         }
         else
         {
            chartHeight.Series["SeriesXAcc"].Enabled = false;
            chartDistance.Series["SeriesXGyro"].Enabled = false;
         }
      }

      private void radioButtonY_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButtonY.Checked)
         {
            chartHeight.Series["SeriesYAcc"].Enabled = true;
            chartDistance.Series["SeriesYGyro"].Enabled = true;
         }
         else
         {
            chartHeight.Series["SeriesYAcc"].Enabled = false;
            chartDistance.Series["SeriesYGyro"].Enabled = false;
         }
      }

      private void radioButtonZ_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButtonZ.Checked)
         {
            chartHeight.Series["SeriesZAcc"].Enabled = true;
            chartDistance.Series["SeriesZGyro"].Enabled = true;
         }
         else
         {
            chartHeight.Series["SeriesZAcc"].Enabled = false;
            chartDistance.Series["SeriesZGyro"].Enabled = false;
         }
      }



      private void fillSeries()
      { 
         fillXAxis();
         fillYAxis();
         fillZAxis();
      }

      private void fillXAxis()
      {
         motion = (Motion)GlobalMeasurement.measurement._sensorsMulti[0];
         float[] motionValues = motion.fGetMultiData();
         Series XAcc = chartHeight.Series["SeriesXAcc"];
         if (XAcc.Points.Count > 500)
         {
            XAcc.Points.RemoveAt(0); // Keep the number of points reasonable
         }
         XAcc.Points.AddY(motionValues[0]);


         Series XGyro = chartDistance.Series["SeriesXGyro"];
         if (XGyro.Points.Count > 500)
         {
            XGyro.Points.RemoveAt(0); // Keep the number of points reasonable
         }
         XGyro.Points.AddY(motionValues[3]);
      }
      private void fillYAxis()
      {
         motion = (Motion)GlobalMeasurement.measurement._sensorsMulti[0];
         float[] motionValues = motion.fGetMultiData();
         Series YAcc = chartHeight.Series["SeriesYAcc"];
         if (YAcc.Points.Count > 500)
         {
            YAcc.Points.RemoveAt(0); // Keep the number of points reasonable
         }
         YAcc.Points.AddY(motionValues[1]);


         Series YGyro = chartDistance.Series["SeriesYGyro"];
         if (YGyro.Points.Count > 500)
         {
            YGyro.Points.RemoveAt(0); // Keep the number of points reasonable
         }
         YGyro.Points.AddY(motionValues[4]);
      }
      private void fillZAxis()
      {
         motion = (Motion)GlobalMeasurement.measurement._sensorsMulti[0];
         float[] motionValues = motion.fGetMultiData();
         Series ZAcc = chartHeight.Series["SeriesZAcc"];
         if (ZAcc.Points.Count > 500)
         {
            ZAcc.Points.RemoveAt(0); // Keep the number of points reasonable
         }
         ZAcc.Points.AddY(motionValues[2]);


         Series ZGyro = chartDistance.Series["SeriesZGyro"];
         if (ZGyro.Points.Count > 500)
         {
            ZGyro.Points.RemoveAt(0); // Keep the number of points reasonable
         }
         ZGyro.Points.AddY(motionValues[5]);
      }


      private void redrawCharts()
      {
         chartHeight.Invalidate();
         chartDistance.Invalidate();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (_normalRun)
         {
            this.Hide();
         }
         else { this.Close(); }
      }

      private void chartHeartbeat_Click(object sender, EventArgs e)
      {

      }
   }
}
