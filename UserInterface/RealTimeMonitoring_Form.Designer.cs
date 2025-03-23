using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface
{
    partial class RealTimeMonitoring_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartHeartbeat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBPM = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblEnvTemp = new System.Windows.Forms.Label();
            this.lblBodyTemp = new System.Windows.Forms.Label();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.pctboxBrooch = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeartbeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxBrooch)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHeartbeat
            // 
            this.chartHeartbeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.chartHeartbeat.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            this.chartHeartbeat.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.chartHeartbeat.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartHeartbeat.BorderlineWidth = 2;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 760D;
            chartArea1.AxisY.Minimum = 680D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartHeartbeat.ChartAreas.Add(chartArea1);
            this.chartHeartbeat.Location = new System.Drawing.Point(46, 95);
            this.chartHeartbeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartHeartbeat.Name = "chartHeartbeat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.White;
            series1.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHeartbeat.Series.Add(series1);
            this.chartHeartbeat.Size = new System.Drawing.Size(1173, 326);
            this.chartHeartbeat.TabIndex = 11;
            this.chartHeartbeat.Text = "chartHeartRate";
            // 
            // lblBPM
            // 
            this.lblBPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblBPM.Font = new System.Drawing.Font("Red Hat Display", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPM.Location = new System.Drawing.Point(1050, 543);
            this.lblBPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.Size = new System.Drawing.Size(169, 120);
            this.lblBPM.TabIndex = 12;
            this.lblBPM.Text = "322";
            this.lblBPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHumidity
            // 
            this.lblHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblHumidity.Font = new System.Drawing.Font("Red Hat Display", 16F);
            this.lblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblHumidity.Location = new System.Drawing.Point(137, 665);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(122, 55);
            this.lblHumidity.TabIndex = 15;
            this.lblHumidity.Text = "322";
            // 
            // lblEnvTemp
            // 
            this.lblEnvTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblEnvTemp.Font = new System.Drawing.Font("Red Hat Display", 16F);
            this.lblEnvTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblEnvTemp.Location = new System.Drawing.Point(137, 520);
            this.lblEnvTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvTemp.Name = "lblEnvTemp";
            this.lblEnvTemp.Size = new System.Drawing.Size(122, 56);
            this.lblEnvTemp.TabIndex = 14;
            this.lblEnvTemp.Text = "322";
            // 
            // lblBodyTemp
            // 
            this.lblBodyTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblBodyTemp.Font = new System.Drawing.Font("Red Hat Display", 16F);
            this.lblBodyTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblBodyTemp.Location = new System.Drawing.Point(334, 520);
            this.lblBodyTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBodyTemp.Name = "lblBodyTemp";
            this.lblBodyTemp.Size = new System.Drawing.Size(98, 50);
            this.lblBodyTemp.TabIndex = 13;
            this.lblBodyTemp.Text = "322";
            // 
            // lblBrightness
            // 
            this.lblBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblBrightness.Font = new System.Drawing.Font("Red Hat Display", 16F);
            this.lblBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblBrightness.Location = new System.Drawing.Point(334, 665);
            this.lblBrightness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(107, 55);
            this.lblBrightness.TabIndex = 16;
            this.lblBrightness.Text = "322";
            // 
            // pctboxBrooch
            // 
            this.pctboxBrooch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.pctboxBrooch.Image = global::UserInterface.Properties.Resources.Ok1;
            this.pctboxBrooch.Location = new System.Drawing.Point(508, 498);
            this.pctboxBrooch.Name = "pctboxBrooch";
            this.pctboxBrooch.Size = new System.Drawing.Size(245, 215);
            this.pctboxBrooch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctboxBrooch.TabIndex = 17;
            this.pctboxBrooch.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1208, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 37);
            this.btnExit.TabIndex = 18;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RealTimeMonitoring_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.BackgroundImage = global::UserInterface.Properties.Resources.Design___RealTimeMonitoring;
            this.ClientSize = new System.Drawing.Size(1272, 830);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pctboxBrooch);
            this.Controls.Add(this.lblEnvTemp);
            this.Controls.Add(this.lblBodyTemp);
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblBPM);
            this.Controls.Add(this.chartHeartbeat);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RealTimeMonitoring_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real-Time Monitoring - Smart Health Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.chartHeartbeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxBrooch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHeartbeat;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblEnvTemp;
        private System.Windows.Forms.Label lblBodyTemp;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.PictureBox pctboxBrooch;
        public System.Windows.Forms.Button btnExit;
    }
}