using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Converter
{
    public static class BrightnessConverter
    {
        //gets Value between 0 and 3000 and gives back the percent of the brightness
        public static float convert(float value)
        {
            return (float)(value/4095.0f);
        }
    }
}
