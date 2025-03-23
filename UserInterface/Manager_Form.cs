using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using BackendCS.Measurement;
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface
{
    public partial class Manager_Form : Form
    {
        private static readonly object _lock = new object();

        private Measurement measurement;
        private LogIn_Form _loginForm;
        private Home_Form _homeForm;
        private MotionData_Form _motionDataForm;
        private RealTimeMonitoring_Form _heartrateDataForm;

        private WindowState _windowState;
        public Manager_Form()
        {
            // start invisible manager form
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            ShowInTaskbar = false;
            Visible = false;
            InitializeComponent();

            // start Log-In
            _loginForm = new LogIn_Form();
            _loginForm.OnLoginSucces += LoginScreen_OnLoginSuccess;
            _loginForm.Show();

            // create Home- and HealthData-Form in background
            _homeForm = new Home_Form(true);
            _homeForm.btnViewMotionData.Click += show_MotionDataForm;
            _homeForm.btnRealTimeMonitoring.Click += show_HeartDataForm;


            _windowState = HomeWindow.getHomeWindow();


            measurement = GlobalMeasurement.measurement;
            measurement.vStartMeasurement();
            measurement.PrintData += vPrintMeasurements;


            //komplette App schließen
            _homeForm.FormClosed += HomeForm_OnFormClosed;


            _motionDataForm = new MotionData_Form(true);
            _motionDataForm.btnExit.Click += hideHeartRateDataForm;


            _heartrateDataForm = new RealTimeMonitoring_Form(true);
            _heartrateDataForm.btnExit.Click += hideHeartRateDataForm;
            _heartrateDataForm.KeyDown += new KeyEventHandler(KeyDownEvent);
            _heartrateDataForm.KeyPreview = true;

            /*
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Fonts\Red_Hat_Display\RedHatDisplay-VariableFont_wght.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
            */
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            // Überprüfen Sie, welche Taste gedrückt wurde
            if (e.KeyCode == Keys.J)
            {
                _heartrateDataForm.SetBrooch_Good();
            }
            else if (e.KeyCode == Keys.K)
            {
                _heartrateDataForm.SetBrooch_Ok();
            }
            else if (e.KeyCode == Keys.L)
            {
                _heartrateDataForm.SetBrooch_Danger();
                Task emailTask = Task.Run(() =>
                {
                    BackendCS.Email.Send(Backend.Instance().GetProfile().sGetLoginname(), "Warning", "Your Patient's Life is in danger");
                });
            }
        }
        private void vPrintMeasurements(PrintDataEventArgs printDataEventArgs)
        {
            lock (_lock)
            {
                if (_windowState is MotionWindow)
                {
                    _motionDataForm.vPrintMeasurements();
                }
                if (_windowState is EnvironmentWindow)
                {
                    //_environmentDataForm.vPrintMeasurements();
                }
                if (_windowState is HeartWindow)
                {
                    _heartrateDataForm.vPrintMeasurements();
                }
            }
        }


        private void LoginScreen_OnLoginSuccess(object sender, EventArgs e)
        {
            _homeForm.Update_lblLoggingName();
            _homeForm.Update_lblCurPatientName();

            var splashScreen = new SplashScreen_Form(false);
            _loginForm.Hide();
            splashScreen.Show();
            splashScreen.VisibleChanged += SplashScreen_OnFormHiding;

        }

        private void SplashScreen_OnFormHiding(object sender, EventArgs e)
        {
            _homeForm.Show();
            _loginForm.Close();
        }

        private void show_MotionDataForm(object sender, EventArgs e)
        {
            _windowState = MotionWindow.getMotionWindow();
            _motionDataForm.Show();
        }

        private void hideMotionDataForm(object sender, EventArgs e)
        {
            _motionDataForm.Hide();
            showHomeForm(sender, e);
        }

        private void show_HeartDataForm(object sender, EventArgs e)
        {
            lock (_lock)
            {
                _windowState = HeartWindow.getHeartWindow();
                _heartrateDataForm.Show();
            }
        }

        private void hideHeartRateDataForm(object sender, EventArgs e)
        {
            _heartrateDataForm.Hide();
            showHomeForm(sender, e);
        }

        // is needed because SplashScreen is still open  ---- maybe fixxed later
        private void showHomeForm(object sender, EventArgs e)
        {
            lock (_lock)
            {
                if (!_homeForm.Visible)
                {
                    _homeForm.Show();
                    _windowState = HomeWindow.getHomeWindow();
                }
            }
        }

        // is needed because SplashScreen is still open   ---- maybe fixxed later
        private void HomeForm_OnFormClosed(object sender, FormClosedEventArgs e)
        {
            _motionDataForm.Close();
            _heartrateDataForm.Close();
            //_environmentDataForm.Close();
            this.Close();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
