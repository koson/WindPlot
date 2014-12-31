using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindPlot
{
    public class GPS : IReport
    {
        double _latitude;
        private double _longitude;
        private double _altitude;
    
        public double Latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                _latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                _longitude = value;
            }
        }

        public double Altitude
        {
            get
            {
                return _altitude;
            }
            set
            {
                _altitude = value;
            }
        }

        public void Report()
        {
            Console.WriteLine("GPS Latitude : " + Latitude);
            Console.WriteLine("GPS Longitude : " + Longitude);
            Console.WriteLine("GPS Altitude : " + Altitude);
        }

        internal void updateForm(Form1 form1)
        {
            form1.updateLatitude(Latitude.ToString());
            form1.updateLongitude(Longitude.ToString());
        }
    }
}
