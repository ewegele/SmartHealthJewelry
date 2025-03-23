using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public class DesignColors
    {
        public DesignColors() { }

        public static Color Background = Color.FromArgb(17,18,27);
        public static Color Text = Color.FromArgb(221, 223, 233);

        public static Color Error = Color.FromArgb(223, 41, 53);        
    }


    public class DynamicScreenSize
    {
        public static void AdjustFont(Control control)
        {
            float baseFontSize = control.Font.Size;

            using (Graphics g = control.CreateGraphics())
            {
                float dpi = g.DpiX;
                float scaleFactor = dpi / 125.0f; // 96 ist die Standard-DPI in Windows
                control.Font = new Font(control.Font.FontFamily,
                    baseFontSize / scaleFactor, control.Font.Style);
            }
        }

    }
}
