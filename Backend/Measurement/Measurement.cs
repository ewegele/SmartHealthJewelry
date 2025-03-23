using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Threading;
using BackendCS.Event;

namespace BackendCS.Measurement
{
    public interface ISensorSingle
    {
        void vProcessSingleData(string data);
        float fGetSingleData();
    }

    public interface ISensorMulti
    {
        void vProcessMultiData(string[] data);
        float[] fGetMultiData();
    }

    public class PrintDataEventArgs
    {
        public string Message { get; private set; }

        public PrintDataEventArgs()
        {
        }
    }

    public class Measurement
    {

        private IPort _port;
        private static readonly object _lock = new object();

        public readonly List<ISensorSingle> _sensorsSingle;
        public readonly List<ISensorMulti> _sensorsMulti;

        public delegate void PrintDataHandler(PrintDataEventArgs e);
        public event PrintDataHandler PrintData;

        /*
        * Constructor overgive the port
        * create all sensor objects
        */
        public Measurement()
        {
            _sensorsSingle = new List<ISensorSingle>
            {
                new HeartRate(),
                new EnvironmentTemperature(),
                new Humidity(),
                new BodyTemperature(),
                new Brightness(),
            };
            _sensorsMulti = new List<ISensorMulti> 
            {
                new Motion(),
            };
        }


        public void vStartMeasurement()
        {
            _port = new Hardware();
            _port.vConnectHardware(DataReceivedHandler);
        }


        public void vStopMeasurement()
        {
            _port.vDisconnectHardware();
        }


        /*
        * Handler who collect all Sensor Datas
        */
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            lock (_lock)
            {
                Thread workerThread = new Thread(() =>
                {
                    SerialPort serialPort = (SerialPort)sender;
                    if (serialPort.IsOpen)
                    {
                         //read Datas into string
                         string data = serialPort.ReadLine().Trim();

                         //seperate values
                         string[] aData = data.Split(',');

                         vOrganizeSingleData(aData);
                         vOrganizeMultiData(aData);
                    }
                });
                workerThread.Start();
                workerThread.Join();
            }

            if (PrintData != null) //check if UI is subscribed
            {
                PrintData(new PrintDataEventArgs()); //Throw new event so the GUI nows that it needs to update
            }
        }
        

        /*
        * fill the single data sensors
        */
        private void vOrganizeSingleData(string[] data)
        {
            for(int i = 0; i < _sensorsSingle.Count; i++)
            {
                if(i < data.Length && !bCheckNAN(data[i]) && data[i] != "")
                {
                    _sensorsSingle[i].vProcessSingleData(data[i]);
                }
            }
        }


        /*
        * fill the multiple data sensors
        */
        private void vOrganizeMultiData(string[] data)
        {
            for (int i = 0; i < _sensorsMulti.Count; i++)
            {
                _sensorsMulti[i].vProcessMultiData(data);
            }
        }


        /*
        * checks if there is not a number in the data
        */
        private bool bCheckNAN(string data)
        {
            if (data == "nan") return true;
            return false;
        }
    }
}
