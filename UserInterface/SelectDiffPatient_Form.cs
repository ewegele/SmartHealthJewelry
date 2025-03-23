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
    public partial class SelectDiffPatient_Form : Form
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

        public SelectDiffPatient_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void btnPatient1_Click(object sender, EventArgs e)
        {
            Backend.Instance().GetProfile().SetPatient(0);
            this.Close();
        }

        private void btnPatient2_Click(object sender, EventArgs e)
        {
            Backend.Instance().GetProfile().SetPatient(1);
            this.Close();
        }

        private void btnPatient3_Click(object sender, EventArgs e)
        {
            Backend.Instance().GetProfile().SetPatient(2);
            this.Close();
        }

        private void btnPatient4_Click(object sender, EventArgs e)
        {
            Backend.Instance().GetProfile().SetPatient(3);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
