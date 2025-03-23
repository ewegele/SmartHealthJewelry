using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace BackendCS.Measurement
{
    public class EnvironmentTemperature : ISensorSingle
    {
        private float _envTemp;


        public void vProcessSingleData(string data)
        {
            _envTemp = float.Parse(data, CultureInfo.InvariantCulture); //richtiger Parse mit Punkt
        }


        public float fGetSingleData()
        {
            return _envTemp;
        }
    }
}
