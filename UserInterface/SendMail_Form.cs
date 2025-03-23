using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class SendMail_Form : Form
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

        public SendMail_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            txtboxSubject.Enter += OntxtboxSubject_Enter;
            txtboxSubject.Leave += OntxtboxSubject_Leave;

            txtboxMessage.Enter += OntxtboxMessage_Enter;
            txtboxMessage.Leave += OntxtboxMessage_Leave;

            DynamicScreenSize.AdjustFont(txtboxMessage);
            DynamicScreenSize.AdjustFont(txtboxSubject);
            DynamicScreenSize.AdjustFont(btnSend);
            DynamicScreenSize.AdjustFont(btnCancel);

        }

        private void OntxtboxMessage_Leave(object sender, EventArgs e)
        {
            if (txtboxMessage.Text.Equals(""))
            {
                txtboxMessage.Text = "Message";
            }
        }

        private void OntxtboxMessage_Enter(object sender, EventArgs e)
        {
            if(txtboxMessage.Text.Equals("Message"))
            {
                txtboxMessage.Text = "";
            }
        }

        private void OntxtboxSubject_Leave(object sender, EventArgs e)
        {
            if (txtboxSubject.Text.Equals(""))
            {
                txtboxSubject.Text = "Subject";
            }
        }

        private void OntxtboxSubject_Enter(object sender, EventArgs e)
        {
            if (txtboxSubject.Text.Equals("Subject"))
            {
                txtboxSubject.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string subject = txtboxSubject.Text;
            string message = txtboxMessage.Text;

            Backend.Instance().GetProfile().GetPatient().NotifyContacts(subject, message);

            this.Close();
        }
    }
}
