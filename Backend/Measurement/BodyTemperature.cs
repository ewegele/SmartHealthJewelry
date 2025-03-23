using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace BackendCS.Measurement
{
    public class BodyTemperature : ISensorSingle
    {
        private float _bodyTemp;


        public void vProcessSingleData(string data)
        {
            _bodyTemp = float.Parse(data, CultureInfo.InvariantCulture);    //richtiger Parse mit Punkt
        }


        public float fGetSingleData()
        {
            return _bodyTemp;
        }
    }
}
