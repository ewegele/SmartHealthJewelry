namespace UserInterface
{
    partial class SendMail_Form
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtboxSubject = new System.Windows.Forms.TextBox();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(316, 628);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(393, 53);
            this.btnSend.TabIndex = 0;
            this.btnSend.TabStop = false;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(100, 628);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 53);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtboxSubject
            // 
            this.txtboxSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.txtboxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSubject.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.txtboxSubject.Location = new System.Drawing.Point(114, 125);
            this.txtboxSubject.Name = "txtboxSubject";
            this.txtboxSubject.Size = new System.Drawing.Size(583, 31);
            this.txtboxSubject.TabIndex = 1;
            this.txtboxSubject.TabStop = false;
            this.txtboxSubject.Text = "Subject";
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.txtboxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxMessage.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.txtboxMessage.Location = new System.Drawing.Point(113, 243);
            this.txtboxMessage.Multiline = true;
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.Size = new System.Drawing.Size(583, 311);
            this.txtboxMessage.TabIndex = 1;
            this.txtboxMessage.TabStop = false;
            this.txtboxMessage.Text = "Message";
            // 
            // SendMail_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.BackgroundImage = global::UserInterface.Properties.Resources.Design_EMail;
            this.ClientSize = new System.Drawing.Size(811, 754);
            this.Controls.Add(this.txtboxMessage);
            this.Controls.Add(this.txtboxSubject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendMail_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact All - Smart Health Desktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtboxSubject;
        private System.Windows.Forms.TextBox txtboxMessage;
    }
}