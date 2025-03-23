using System.Windows.Forms;
using System.Drawing;
using BackendCS;

namespace UserInterface
{
    partial class Home_Form
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
            this.lblLoginName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRealTimeMonitoring = new System.Windows.Forms.Button();
            this.btnMssgAllContacts = new System.Windows.Forms.Button();
            this.btnSelectDiffPatient = new System.Windows.Forms.Button();
            this.btnViewMotionData = new System.Windows.Forms.Button();
            this.btnOpenUserSettings = new System.Windows.Forms.Button();
            this.lblCurPatientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginName
            // 
            this.lblLoginName.Font = new System.Drawing.Font("Red Hat Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.lblLoginName.Location = new System.Drawing.Point(831, 21);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(737, 29);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "You are logged in as Name";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1857, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRealTimeMonitoring
            // 
            this.btnRealTimeMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btnRealTimeMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealTimeMonitoring.FlatAppearance.BorderSize = 0;
            this.btnRealTimeMonitoring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRealTimeMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRealTimeMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealTimeMonitoring.ForeColor = System.Drawing.Color.Transparent;
            this.btnRealTimeMonitoring.Location = new System.Drawing.Point(992, 582);
            this.btnRealTimeMonitoring.Name = "btnRealTimeMonitoring";
            this.btnRealTimeMonitoring.Size = new System.Drawing.Size(865, 450);
            this.btnRealTimeMonitoring.TabIndex = 1;
            this.btnRealTimeMonitoring.TabStop = false;
            this.btnRealTimeMonitoring.UseVisualStyleBackColor = false;
            this.btnRealTimeMonitoring.Click += new System.EventHandler(this.btnRealTimeMonitoring_Click);
            // 
            // btnMssgAllContacts
            // 
            this.btnMssgAllContacts.BackColor = System.Drawing.Color.Transparent;
            this.btnMssgAllContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMssgAllContacts.FlatAppearance.BorderSize = 0;
            this.btnMssgAllContacts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMssgAllContacts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMssgAllContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMssgAllContacts.ForeColor = System.Drawing.Color.Transparent;
            this.btnMssgAllContacts.Location = new System.Drawing.Point(114, 330);
            this.btnMssgAllContacts.Name = "btnMssgAllContacts";
            this.btnMssgAllContacts.Size = new System.Drawing.Size(298, 24);
            this.btnMssgAllContacts.TabIndex = 1;
            this.btnMssgAllContacts.TabStop = false;
            this.btnMssgAllContacts.UseVisualStyleBackColor = false;
            this.btnMssgAllContacts.Click += new System.EventHandler(this.btnMssgAllContacts_Click);
            // 
            // btnSelectDiffPatient
            // 
            this.btnSelectDiffPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectDiffPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDiffPatient.FlatAppearance.BorderSize = 0;
            this.btnSelectDiffPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectDiffPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectDiffPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDiffPatient.ForeColor = System.Drawing.Color.Transparent;
            this.btnSelectDiffPatient.Location = new System.Drawing.Point(114, 369);
            this.btnSelectDiffPatient.Name = "btnSelectDiffPatient";
            this.btnSelectDiffPatient.Size = new System.Drawing.Size(320, 22);
            this.btnSelectDiffPatient.TabIndex = 1;
            this.btnSelectDiffPatient.TabStop = false;
            this.btnSelectDiffPatient.UseVisualStyleBackColor = false;
            this.btnSelectDiffPatient.Click += new System.EventHandler(this.btnSelectDiffPatient_Click);
            // 
            // btnViewMotionData
            // 
            this.btnViewMotionData.BackColor = System.Drawing.Color.Transparent;
            this.btnViewMotionData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMotionData.FlatAppearance.BorderSize = 0;
            this.btnViewMotionData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewMotionData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewMotionData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMotionData.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewMotionData.Location = new System.Drawing.Point(114, 399);
            this.btnViewMotionData.Name = "btnViewMotionData";
            this.btnViewMotionData.Size = new System.Drawing.Size(320, 24);
            this.btnViewMotionData.TabIndex = 1;
            this.btnViewMotionData.TabStop = false;
            this.btnViewMotionData.UseVisualStyleBackColor = false;
            this.btnViewMotionData.Click += new System.EventHandler(this.btnViewMotionData_Click);
            // 
            // btnOpenUserSettings
            // 
            this.btnOpenUserSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenUserSettings.Enabled = false;
            this.btnOpenUserSettings.FlatAppearance.BorderSize = 0;
            this.btnOpenUserSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpenUserSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpenUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenUserSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenUserSettings.Location = new System.Drawing.Point(114, 433);
            this.btnOpenUserSettings.Name = "btnOpenUserSettings";
            this.btnOpenUserSettings.Size = new System.Drawing.Size(320, 25);
            this.btnOpenUserSettings.TabIndex = 1;
            this.btnOpenUserSettings.TabStop = false;
            this.btnOpenUserSettings.UseVisualStyleBackColor = false;
            // 
            // lblCurPatientName
            // 
            this.lblCurPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(49)))));
            this.lblCurPatientName.Font = new System.Drawing.Font("Red Hat Display SemiBold", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblCurPatientName.Location = new System.Drawing.Point(102, 177);
            this.lblCurPatientName.Name = "lblCurPatientName";
            this.lblCurPatientName.Size = new System.Drawing.Size(666, 51);
            this.lblCurPatientName.TabIndex = 0;
            this.lblCurPatientName.Text = "Name\'s Health Data";
            // 
            // Home_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.BackgroundImage = global::UserInterface.Properties.Resources.Home_Design1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1622, 922);
            this.Controls.Add(this.btnOpenUserSettings);
            this.Controls.Add(this.btnViewMotionData);
            this.Controls.Add(this.btnSelectDiffPatient);
            this.Controls.Add(this.btnMssgAllContacts);
            this.Controls.Add(this.btnRealTimeMonitoring);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.lblCurPatientName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Smart Health Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblLoginName;
        private Button btnClose;
        private Button btnMssgAllContacts;
        private Button btnSelectDiffPatient;
        private Button btnOpenUserSettings;
        private Label lblCurPatientName;
        public Button btnViewMotionData;
        public Button btnRealTimeMonitoring;
    }
}