using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Win32;

namespace BackendCS.Measurement
{
    public class Motion : ISensorMulti
    {
        const int ciSize = 100;

        //acceleration of the axis
        private float[] _last100accX = new float[ciSize];
        private int idxAccX;
        private float _avgAccX;

        private float[] _last100accY = new float[ciSize];
        private int idxAccY;
        private float _avgAccY;

        private float[] _last100accZ = new float[ciSize];
        private int idxAccZ;
        private float _avgAccZ;

        //gyroscope of the axis
        private float[] _last100gyroX = new float[ciSize];
        private int idxGyroX;
        private float _avgGyroX;

        private float[] _last100gyroY = new float[ciSize];
        private int idxGyroY;
        private float _avgGyroY;

        private float[] _last100gyroZ = new float[ciSize];
        private int idxGyroZ;
        private float _avgGyroZ;



        public void vProcessMultiData(string[] data)
        {
            //for Schleife Schützt for Index out of Bounds
            for (int index = 5; index < data.Length; index++)
            {
                //schützt for falschen Strings bei parsen
                if (float.TryParse(data[index], NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
                {
                    switch (index)
                    {
                        case 5:
                            _last100accX[idxAccX++] = result;
                            idxAccX = (idxAccX > 99) ? 0 : idxAccX;
                            break;
                        case 6:
                            _last100accY[idxAccY++] = result;
                            idxAccY = (idxAccY > 99) ? 0 : idxAccY;
                            break;
                        case 7:
                            _last100accZ[idxAccZ++] = result;
                            idxAccZ = (idxAccZ > 99) ? 0 : idxAccZ;
                            break;
                        case 8:
                            _last100gyroX[idxGyroX++] = result;
                            idxGyroX = (idxGyroX > 99) ? 0 : idxGyroX;
                            break;
                        case 9:
                            _last100gyroY[idxGyroY++] = result;
                            idxGyroY = (idxGyroY > 99) ? 0 : idxGyroY;
                            break;
                        case 10:
                            _last100gyroZ[idxGyroZ++] = result;
                            idxGyroZ = (idxGyroZ > 99) ? 0 : idxGyroZ;
                            break;
                        default: break;
                    }
                }
            }
        }


        public float[] fGetMultiData()
        {
            vCalculateAcc();
            return new float[] 
            { _avgAccX, _avgAccY, _avgAccZ, _avgGyroX, _avgGyroY, _avgGyroZ, };
        }


         private void vCalculateAcc()
         {
            _avgAccX = 0;
            _avgAccY = 0;
            _avgAccZ = 0;
            _avgGyroX = 0;
            _avgGyroY = 0;
            _avgGyroZ = 0;

            for(int i = 0; i < _last100accY.Length; i++)
            {
                _avgAccX += _last100accX[i];
                _avgAccY += _last100accY[i];
                _avgAccZ += _last100accZ[i];

                _avgGyroX += _last100gyroX[i];
                _avgGyroY += _last100gyroY[i];
                _avgGyroZ += _last100gyroZ[i];
            }
            _avgAccX /= 100;
            _avgAccY /= 100;
            _avgAccZ /= 100;

            _avgGyroX /= 100;
            _avgGyroY /= 100;
            _avgGyroZ /= 100;
         }
    }
}
