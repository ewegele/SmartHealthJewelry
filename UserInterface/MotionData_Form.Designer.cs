using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace UserInterface
{
    partial class MotionData_Form
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartHeight
            // 
            this.chartHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.chartHeight.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            this.chartHeight.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.chartHeight.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartHeight.BorderlineWidth = 2;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 3D;
            chartArea1.AxisY.Minimum = -3D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartHeight.ChartAreas.Add(chartArea1);
            this.chartHeight.Location = new System.Drawing.Point(628, 102);
            this.chartHeight.Name = "chartHeight";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "SeriesXAcc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.Name = "SeriesYAcc";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "SeriesZAcc";
            this.chartHeight.Series.Add(series1);
            this.chartHeight.Series.Add(series2);
            this.chartHeight.Series.Add(series3);
            this.chartHeight.Size = new System.Drawing.Size(631, 598);
            this.chartHeight.TabIndex = 11;
            this.chartHeight.Text = "chartHeight";
            // 
            // chartDistance
            // 
            this.chartDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.chartDistance.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            this.chartDistance.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.chartDistance.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartDistance.BorderlineWidth = 2;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = -100D;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartDistance.ChartAreas.Add(chartArea2);
            this.chartDistance.Location = new System.Drawing.Point(12, 102);
            this.chartDistance.Name = "chartDistance";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Legend = "Legend1";
            series4.Name = "SeriesXGyro";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Enabled = false;
            series5.Legend = "Legend1";
            series5.Name = "SeriesYGyro";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Enabled = false;
            series6.Legend = "Legend1";
            series6.Name = "SeriesZGyro";
            this.chartDistance.Series.Add(series4);
            this.chartDistance.Series.Add(series5);
            this.chartDistance.Series.Add(series6);
            this.chartDistance.Size = new System.Drawing.Size(592, 598);
            this.chartDistance.TabIndex = 12;
            this.chartDistance.Text = "chartDistance";
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonX.Checked = true;
            this.radioButtonX.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.radioButtonX.Location = new System.Drawing.Point(3, 3);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(83, 29);
            this.radioButtonX.TabIndex = 13;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "X-Axis";
            this.radioButtonX.UseVisualStyleBackColor = true;
            this.radioButtonX.CheckedChanged += new System.EventHandler(this.radioButtonX_CheckedChanged);
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonY.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.radioButtonY.Location = new System.Drawing.Point(200, 3);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.Size = new System.Drawing.Size(83, 29);
            this.radioButtonY.TabIndex = 14;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "Y-Axis";
            this.radioButtonY.UseVisualStyleBackColor = true;
            this.radioButtonY.CheckedChanged += new System.EventHandler(this.radioButtonY_CheckedChanged);
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonZ.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.radioButtonZ.Location = new System.Drawing.Point(397, 3);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(82, 29);
            this.radioButtonZ.TabIndex = 15;
            this.radioButtonZ.TabStop = true;
            this.radioButtonZ.Text = "Z-Axis";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            this.radioButtonZ.CheckedChanged += new System.EventHandler(this.radioButtonZ_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButtonX);
            this.panel1.Controls.Add(this.radioButtonZ);
            this.panel1.Controls.Add(this.radioButtonY);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(378, 731);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 43);
            this.panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1209, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // MotionData_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.BackgroundImage = global::UserInterface.Properties.Resources.Design_MotionData;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 823);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartDistance);
            this.Controls.Add(this.chartHeight);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotionData_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motion Data - Smart Health Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private Series series1;
        private Chart chartHeight;
        private Chart chartDistance;
        private RadioButton radioButtonX;
        private RadioButton radioButtonY;
        private RadioButton radioButtonZ;
        private Panel panel1;
        public Button btnExit;
   }
}