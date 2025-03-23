using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public class Brightness : ISensorSingle
    {
        private float _brightness;


        public void vProcessSingleData(string data)
        {
            _brightness = float.Parse(data);
        }


        public float fGetSingleData()
        {
            return (float)_brightness;
        }
    }
}
