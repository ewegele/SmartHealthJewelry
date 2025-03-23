using System;
using System.Reflection;

namespace UserInterface
{
    partial class SplashScreen_Form
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
            timer1.Dispose();

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen_Form));
            this.circProgressBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitelTop = new System.Windows.Forms.Label();
            this.lblTitleBottom = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circProgressBar
            // 
            this.circProgressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circProgressBar.AnimationFunction")));
            this.circProgressBar.AnimationSpeed = 22;
            this.circProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.circProgressBar.Font = new System.Drawing.Font("Red Hat Display SemiBold", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circProgressBar.ForeColor = System.Drawing.Color.White;
            this.circProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(49)))));
            this.circProgressBar.InnerMargin = 0;
            this.circProgressBar.InnerWidth = 0;
            this.circProgressBar.Location = new System.Drawing.Point(70, 202);
            this.circProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.circProgressBar.MarqueeAnimationSpeed = 250;
            this.circProgressBar.Name = "circProgressBar";
            this.circProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.circProgressBar.OuterMargin = -25;
            this.circProgressBar.OuterWidth = 26;
            this.circProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.circProgressBar.ProgressWidth = 7;
            this.circProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circProgressBar.Size = new System.Drawing.Size(235, 225);
            this.circProgressBar.StartAngle = 270;
            this.circProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circProgressBar.SubscriptText = "";
            this.circProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circProgressBar.SuperscriptText = "";
            this.circProgressBar.TabIndex = 0;
            this.circProgressBar.Text = "77 %";
            this.circProgressBar.TextMargin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.circProgressBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitelTop
            // 
            this.lblTitelTop.Font = new System.Drawing.Font("Red Hat Display SemiBold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelTop.ForeColor = System.Drawing.Color.White;
            this.lblTitelTop.Location = new System.Drawing.Point(20, 27);
            this.lblTitelTop.Name = "lblTitelTop";
            this.lblTitelTop.Size = new System.Drawing.Size(348, 69);
            this.lblTitelTop.TabIndex = 1;
            this.lblTitelTop.Text = "Smarth Health";
            this.lblTitelTop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTitelTop.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitleBottom
            // 
            this.lblTitleBottom.Font = new System.Drawing.Font("Red Hat Display SemiBold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBottom.ForeColor = System.Drawing.Color.White;
            this.lblTitleBottom.Location = new System.Drawing.Point(28, 104);
            this.lblTitleBottom.Name = "lblTitleBottom";
            this.lblTitleBottom.Size = new System.Drawing.Size(340, 75);
            this.lblTitleBottom.TabIndex = 1;
            this.lblTitleBottom.Text = "Desktop";
            this.lblTitleBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitleBottom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.Font = new System.Drawing.Font("Red Hat Display SemiBold", 17.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(118, 470);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(157, 40);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading ...";
            this.lblLoading.Click += new System.EventHandler(this.label1_Click);
            // 
            // SplashScreen_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(380, 563);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblTitleBottom);
            this.Controls.Add(this.lblTitelTop);
            this.Controls.Add(this.circProgressBar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SplashScreen_Form";
            this.Opacity = 0.88D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading - Smart Health Desktop";
            this.Load += new System.EventHandler(this.SplashScreen_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitelTop;
        private System.Windows.Forms.Label lblTitleBottom;
        private System.Windows.Forms.Label lblLoading;
        protected CircularProgressBar.CircularProgressBar circProgressBar;
        protected System.Windows.Forms.Timer timer1;
    }
}

