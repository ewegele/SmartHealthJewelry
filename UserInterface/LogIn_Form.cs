using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendCS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UserInterface
{
    public partial class LogIn_Form : Form
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

        ProfileChangements _profileChangements;

        public event EventHandler OnLoginSucces;



        public LogIn_Form()
        {
            InitializeComponent();
            DynamicScreenSize.AdjustFont(lblDontHaveAccount);
            DynamicScreenSize.AdjustFont(lblForgotPW);
            DynamicScreenSize.AdjustFont(lblRegister);
            DynamicScreenSize.AdjustFont(btnLogin);
            DynamicScreenSize.AdjustFont(txtboxUsername);
            DynamicScreenSize.AdjustFont(txtboxPassword);
            DynamicScreenSize.AdjustFont(checkboxRememberMe);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            _profileChangements = new ProfileChangements();
        }


        //check if textboxes are empty
        private bool checkTextBoxes()
        {
            bool isFine = true;

            //"email" == empty
            if (txtboxUsername.Text == "Username"
                   || txtboxUsername.Text == ""
                   || txtboxUsername.Text == "Fill Field"
                   || txtboxUsername.Text == "Username already used"
                   || txtboxUsername.Text == "No User with this Username"
                   || txtboxUsername.Text == "not an email")
            {
                txtboxUsername.ForeColor = DesignColors.Error;
                txtboxUsername.Text = "Fill Field";
                isFine = false;
            }

            if (!IsValidEmail(txtboxUsername.Text))
            {
                txtboxUsername.ForeColor = DesignColors.Error;
                txtboxUsername.Text = "not an email";
                isFine = false;
            }

            //"password" == empty
            if (txtboxPassword.Text == "Password"
                   || txtboxPassword.Text == ""
                   || txtboxPassword.Text == "Fill Field"
                   || txtboxPassword.Text == "Wrong Password")
            {
                txtboxPassword.ForeColor = DesignColors.Error;
                txtboxPassword.Text = "Fill Field";
                isFine = false;
            }
            return isFine;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                string email = txtboxUsername.Text;
                string password = txtboxPassword.Text;

                int erfolgreich = _profileChangements.LogIn(email, password);

                if (erfolgreich == 0)   // log in erfolgreich
                {
                    if (OnLoginSucces != null)
                    {
                        OnLoginSucces(this, EventArgs.Empty);
                    }
                }
                else if (erfolgreich == 1)      //password falsch
                {
                    txtboxPassword.ForeColor = DesignColors.Error;
                    txtboxPassword.Text = "Wrong Password";
                }
                else       //email nicht vorhanden
                {
                    txtboxUsername.ForeColor = DesignColors.Error;
                    txtboxUsername.Text = "No User with this Username";
                }
            }
        }


        static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                string loginname = txtboxUsername.Text;
                string password = txtboxPassword.Text;

                if (_profileChangements.SignIn(loginname, password))     //sign in erfolgreich
                {
                    OnLoginSucces?.Invoke(this, EventArgs.Empty);
                }
                else     //email wird schon genutzt
                {
                    txtboxUsername.ForeColor = DesignColors.Error;
                    txtboxUsername.Text = "Username already used";
                }
            }
        }



        //events
        private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            txtboxPassword.ForeColor = DesignColors.Text;
            txtboxPassword.Text = "";
        }

        private void emailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            txtboxUsername.ForeColor = DesignColors.Text;
            txtboxUsername.Text = "";
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "")
            {
                txtboxUsername.ForeColor = DesignColors.Text;
                txtboxUsername.Text = "Username";
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "")
            {
                txtboxPassword.ForeColor = DesignColors.Text;
                txtboxPassword.Text = "Password";
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
