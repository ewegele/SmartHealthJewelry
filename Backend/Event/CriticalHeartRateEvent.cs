using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Bson;

namespace BackendCS.Event
{
    public class CriticalHeartRateEvent
    {
        private static CriticalHeartRateEvent _Instance;

        public delegate void CriticalHeartRateHandler(CriticalHeartRateEventArgs e);

        public event CriticalHeartRateHandler CriticialHeartRate; // callback Function

        private CriticalHeartRateEvent()
        {
            CriticialHeartRate += CriticalHeartHandler;
        }


        public static CriticalHeartRateEvent Instance()
        {
            if (_Instance == null)
            {
                _Instance = new CriticalHeartRateEvent();
            }

            return _Instance;
        }

        //check heartrate wheter is critical
        // good rates are between 60 and 120
        public void Check(int heartrate)
        {

            if (heartrate <= 60 || heartrate >= 120)
            {
                if (CriticialHeartRate != null)
                {
                    CriticialHeartRate(new CriticalHeartRateEventArgs("Achtung! Kritischer Herzschlagwert von " + heartrate + "  wurde gemessen. Bitte umgehend Patienten kontaktieren!"));
                }
            }

        }


        // Eventhandler, send a notification to all contactperson of a patient
        void CriticalHeartHandler(CriticalHeartRateEventArgs e)
        {
            Console.WriteLine("Event fired");
            Backend.Instance().GetProfile().GetPatient().NotifyContacts(e.Message);
        }
    }

    public class CriticalHeartRateEventArgs 
    {
        public string Message { get; private set; }

        public CriticalHeartRateEventArgs(string message)
        {
            Message = message;
        }
    }
}
