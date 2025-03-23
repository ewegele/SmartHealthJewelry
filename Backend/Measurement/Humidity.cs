using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BackendCS.Measurement
{
    public class Humidity : ISensorSingle
    {
        private float _humidity;


        public void vProcessSingleData(string data)
        {
            _humidity = float.Parse(data, CultureInfo.InvariantCulture); //richtiger Parse mit Punkt
        }


        public float fGetSingleData()
        {
            return _humidity;
        }
    }
}
