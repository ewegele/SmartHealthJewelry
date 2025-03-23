using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendCS.Event;

namespace BackendCS.Measurement
{
    public class HeartRate : ISensorSingle
    {
        private int[] _last10heartRate = new int[10];
        private int _avgHeartRate;
        private int _idx;
        
        private int _bpm;

        const int delayMsec = 60;
        static int maxValue = 0;
        static bool isPeak = false;

        // Heartrate Event
        private CriticalHeartRateEvent criticalHeartRate = CriticalHeartRateEvent.Instance();

        public void vProcessSingleData(string data)
        {
            if (int.TryParse(data, out int result)) //format checken
            {
                _last10heartRate[_idx] = int.Parse(data);
                _idx = (_idx > 9) ? 0 : _idx;
            }
        }


        public float fGetSingleData()
        {
            vCalcBPM();
            return (float)_bpm;
        }


        public int iGetHeartRate()
        {
            vCalcAverage();

            return _avgHeartRate;
        }

        private void vCalcAverage()
        {
            _avgHeartRate = 0;
            for(int i = 0; i < 10; i++)
            {
                _avgHeartRate += _last10heartRate[_idx];
            }
            _avgHeartRate /= 10;
        }


        private void vCalcBPM()
        {
            if (bHeartbeatDetected(delayMsec, _avgHeartRate))
            {
                if (_avgHeartRate != 0)
                {
                    _bpm = 60000 / _avgHeartRate;
                }
                _avgHeartRate = 0;
            }
            _avgHeartRate += delayMsec;
        }


        private bool bHeartbeatDetected(int delay, int rawValue)
        {

            bool result = false;

            // Here the current voltage value at the photo transistor is read out and stored temporarily in the rawValue variable
            rawValue *= (1000 / delay);

            // Should the current value deviate too far from the last maximum value
            // (e.g. because the finger was put on again or taken away)
            // So the MaxValue is reset to get a new base.
            if (rawValue * 4L < maxValue)
            {
                maxValue = (int)(rawValue * 0.8);
            } // Detect new peak
            if (rawValue > maxValue - (1000 / delay))
            {
                // The actual peak is detected here. Should a new RawValue be bigger
                // as the last maximum value, it will be recognized as the top of the recorded data.
                if (rawValue > maxValue)
                {
                    maxValue = rawValue;
                }
                // Only one heartbeat should be assigned to the recognized peak
                if (isPeak == false)
                {
                    result = true;
                }
                isPeak = true;
            }
            else if (rawValue < maxValue - (3000 / delay))
            {
                isPeak = false;
                // This is the maximum value for each pass
                // slightly reduced again. The reason for this is that
                // not only the value is otherwise always stable with every stroke
                // would be the same or smaller, but also,
                // if the finger should move minimally and thus
                // the signal would generally become weaker.
                maxValue -= (1000 / delay);
            }
            return result;
        }
    }
}
