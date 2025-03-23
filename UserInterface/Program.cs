using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    enum RunSettings
    {
        Normal = 0,
        SplashScreen_Only, SplashScreen_OnlyDesign,
        LogIn_Only, Home_Only, MotionData_Only, RealTimeMonitoring_Only,
        test,
        SendMail_Only,
        SelectDiffPatient_Only,
        Skip2Home       // todo
    };

    internal static class Program
    {
        // ---------------------------------- Start CONFIG : Free to use ----------------------------------

        static RunSettings CurRunSettings = RunSettings.Normal;

        // ---------------------------------- END CONFIG -----------------------------------------------------


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            Form StartForm = null;

            switch(CurRunSettings)
            {
                case RunSettings.Normal:
                    StartForm = new Manager_Form();
                    break;

                case RunSettings.SplashScreen_Only:
                    StartForm = new SplashScreen_Form(true);
                    break;

                case RunSettings.SplashScreen_OnlyDesign:
                    StartForm = new TestSplashScreen_Form(true);
                    break;

                case RunSettings.LogIn_Only:
                    StartForm = new LogIn_Form();
                    break;

                case RunSettings.Home_Only:
                    StartForm = new Home_Form(false);
                    break;

                case RunSettings.MotionData_Only:
                    StartForm = new MotionData_Form(false);
                    break;

                    case RunSettings.RealTimeMonitoring_Only:
                    StartForm = new RealTimeMonitoring_Form(false);
                    break;

                case RunSettings.SendMail_Only:
                    StartForm = new SendMail_Form();
                    break;

                case RunSettings.SelectDiffPatient_Only:
                    StartForm = new SelectDiffPatient_Form();
                    break;

                case RunSettings.test:
                    throw new Exception("not implemented");

                default:
                    throw new Exception("error: this shouldnt happen");
            }

            Application.Run(StartForm);

        }





    }
}
