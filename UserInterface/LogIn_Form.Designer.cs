using System.Windows.Forms;
using System.Drawing;


namespace UserInterface
{
    partial class LogIn_Form
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
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblDontHaveAccount = new System.Windows.Forms.Label();
            this.checkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.lblForgotPW = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictboxBackground = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxUsername.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.txtboxUsername.Location = new System.Drawing.Point(94, 269);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(295, 31);
            this.txtboxUsername.TabIndex = 0;
            this.txtboxUsername.TabStop = false;
            this.txtboxUsername.Text = "Username";
            this.txtboxUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.emailTextBox_MouseClick);
            this.txtboxUsername.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.txtboxUsername.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPassword.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.txtboxPassword.Location = new System.Drawing.Point(94, 361);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(295, 31);
            this.txtboxPassword.TabIndex = 1;
            this.txtboxPassword.TabStop = false;
            this.txtboxPassword.Text = "Password";
            this.txtboxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
            this.txtboxPassword.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // lblDontHaveAccount
            // 
            this.lblDontHaveAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblDontHaveAccount.Font = new System.Drawing.Font("Red Hat Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblDontHaveAccount.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDontHaveAccount.Location = new System.Drawing.Point(55, 590);
            this.lblDontHaveAccount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDontHaveAccount.Name = "lblDontHaveAccount";
            this.lblDontHaveAccount.Size = new System.Drawing.Size(260, 50);
            this.lblDontHaveAccount.TabIndex = 5;
            this.lblDontHaveAccount.Text = "Don\'t have an account?";
            this.lblDontHaveAccount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkboxRememberMe
            // 
            this.checkboxRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.checkboxRememberMe.Font = new System.Drawing.Font("Red Hat Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.checkboxRememberMe.Location = new System.Drawing.Point(72, 425);
            this.checkboxRememberMe.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxRememberMe.Name = "checkboxRememberMe";
            this.checkboxRememberMe.Size = new System.Drawing.Size(178, 30);
            this.checkboxRememberMe.TabIndex = 6;
            this.checkboxRememberMe.TabStop = false;
            this.checkboxRememberMe.Text = "Remember me";
            this.checkboxRememberMe.UseVisualStyleBackColor = false;
            // 
            // lblForgotPW
            // 
            this.lblForgotPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblForgotPW.Font = new System.Drawing.Font("Red Hat Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblForgotPW.Location = new System.Drawing.Point(254, 425);
            this.lblForgotPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPW.Name = "lblForgotPW";
            this.lblForgotPW.Size = new System.Drawing.Size(216, 49);
            this.lblForgotPW.TabIndex = 7;
            this.lblForgotPW.Text = "Forgot password?";
            this.lblForgotPW.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Red Hat Display Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.lblRegister.Location = new System.Drawing.Point(320, 583);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(96, 40);
            this.lblRegister.TabIndex = 8;
            this.lblRegister.Text = "Register";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegister.Click += new System.EventHandler(this.labelSignIn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Red Hat Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = global::UserInterface.Properties.Resources.Login_Template___LoginButton;
            this.btnLogin.Location = new System.Drawing.Point(60, 487);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.MaximumSize = new System.Drawing.Size(410, 69);
            this.btnLogin.MinimumSize = new System.Drawing.Size(410, 69);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(410, 69);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pictboxBackground
            // 
            this.pictboxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictboxBackground.Image = global::UserInterface.Properties.Resources.Login_Template___Background1;
            this.pictboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictboxBackground.MaximumSize = new System.Drawing.Size(528, 673);
            this.pictboxBackground.MinimumSize = new System.Drawing.Size(528, 673);
            this.pictboxBackground.Name = "pictboxBackground";
            this.pictboxBackground.Size = new System.Drawing.Size(528, 673);
            this.pictboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictboxBackground.TabIndex = 9;
            this.pictboxBackground.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Red Hat Display Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.btnExit.Location = new System.Drawing.Point(449, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 59);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LogIn_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 673);
            this.Controls.Add(this.lblDontHaveAccount);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.checkboxRememberMe);
            this.Controls.Add(this.lblForgotPW);
            this.Controls.Add(this.pictboxBackground);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(528, 673);
            this.MinimumSize = new System.Drawing.Size(528, 663);
            this.Name = "LogIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Smart Health Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.pictboxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private Label lblDontHaveAccount;
        private CheckBox checkboxRememberMe;
        private Label lblForgotPW;
      private Label lblRegister;
        private PictureBox pictboxBackground;
        private Button btnExit;
    }
}