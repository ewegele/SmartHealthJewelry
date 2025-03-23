using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public interface IPort
    {
        void vDisconnectHardware();
        void vConnectHardware(SerialDataReceivedEventHandler dataReceivedHandler);
    }

    public class Hardware : IPort
    {
        private const int _baudRate = 115200;
        private SerialPort _serialPort;


        public SerialPort sGetSerialPort()
        {
            return _serialPort;
        }


        /*
         * Call the function to disconnect the Serial Port
        */
        public void vDisconnectHardware()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }


        /*
         * Call the function to connect the Serial Port
        */
        public void vConnectHardware(SerialDataReceivedEventHandler dataReceivedHandler)
        {
            _serialPort = new SerialPort("COM4", _baudRate);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);

            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Öffnen der seriellen Verbindung: " + ex.Message);
            }
        }
    }
}
